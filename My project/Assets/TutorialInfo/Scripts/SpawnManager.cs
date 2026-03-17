using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Array to hold the animal prefabs
    public GameObject[] animalPrefabs;

    // Variables for the spawn range and position
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    // Start is called before the first frame update
    void Start()
    {
        // For Lesson 2.3, we typically use the 'S' key in Update, 
        // but some versions of the tutorial introduce InvokeRepeating here.
    }

    // Update is called once per frame
    void Update()
    {
        // Step 2 & 3: Spawn a random animal when 'S' is pressed
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }

    // Step 4: Create a dedicated method for spawning
    void SpawnRandomAnimal()
    {
        // Randomly generate animal index and spawn position
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // Instantiate the selected animal prefab at the random position
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}

