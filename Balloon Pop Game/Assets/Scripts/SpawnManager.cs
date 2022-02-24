using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;
    
    //public int balloonIndex;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnRandomBalloon", startDelay, spawnInterval);
    }


    void SpawnRandomBalloon()
    {
        //Get a randon position on the x axis
        Vector3 spawnPos = new Vector3(Random.Range(-5,5),10,0);
        //pick a random balloon array
        int balloonIndex = Random.Range(0,balloonPrefabs.Length);
        //spawn random balloon at spawn position
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex]);
    }
}
