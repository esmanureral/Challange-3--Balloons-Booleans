using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private Vector3 spawnPos=new Vector3(85,14,4);
    private float spawnDelay = 2;
    private float spawnInterval = 2;

    private PlayerControllerX playerControllerScript;

    
    void Start()
    {
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

 
    void SpawnObjects ()
    {
        int index = Random.Range(0, objectPrefabs.Length);
        Instantiate(objectPrefabs[index], spawnPos, Quaternion.identity);

    }
}
