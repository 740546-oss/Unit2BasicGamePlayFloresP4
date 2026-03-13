using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
 public GameObject[] animalPrefabs;
    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 50.0f;
    private float startDelay = 2;
    private float spawnIntrval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandom Animal", startDelay, spawnIntrval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        int aanimalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
