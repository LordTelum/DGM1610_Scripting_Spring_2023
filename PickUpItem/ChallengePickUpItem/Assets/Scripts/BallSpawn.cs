using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public GameObject[] ballPrefabs; // Array to store balls
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0,spawnPosZ);
            int ufoIndex = Random.Range(0,ufoPrefabs.Length); //Picks a random ball from the array
            Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation); //spawns a indexed UFO from the array 
        }
    }
}
