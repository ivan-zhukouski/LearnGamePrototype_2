using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float animalPosX = 20;
    public float animalPosZ = 20;
    private float startDalay = 2.2f;
    private float repeatTime = 0.6f;
     
    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDalay, repeatTime);
    }
    void Update()
    {

    }
    
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 animalPos = new Vector3(Random.Range(-animalPosX, animalPosX), 0, animalPosZ);

        Instantiate(animalPrefabs[animalIndex], animalPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
