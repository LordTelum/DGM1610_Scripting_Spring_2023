using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
 
    public int balloonIndex;
    //left to right spawn
    public float xSpawnRange;
    //vertical spawn range
    public float ySpawnPos;

    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }

    void SpawnRandomBalloon()
    {
        //Generate the X spawn position Vector3 refers to xyz values
        Vector3 spawnPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), ySpawnPos, 0);
        //Pick a random balloon prefab from the balloon array to spawn
        int balloonIndex = Random.Range(0, balloonPrefabs.Length);
        //Spawn random balloons on the X-axis
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex].transform.rotation); 
        
    }
}
