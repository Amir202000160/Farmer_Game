using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalsPerfabs;
    public float spawnRangeX = 16.0f;
    
    void Start()
    {
        InvokeRepeating("spawnanimals", 2, 1.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }

    void spawnanimals()
    {
        int animalIndex = Random.Range(0, animalsPerfabs.Length);
        Vector3 SpawnPos = new Vector3(Random.Range(spawnRangeX, -spawnRangeX), 0, 20);
        Instantiate(animalsPerfabs[animalIndex], SpawnPos, animalsPerfabs[animalIndex].transform.rotation);
    }
}
