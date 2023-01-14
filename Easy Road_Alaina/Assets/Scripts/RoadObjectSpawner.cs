using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadObjectSpawner : MonoBehaviour
{
    public GameObject nailPrefab;
    public GameObject roadNetwork;
    public bool spawnObjects;
    void Start(){
        spawnObjects = false;
    }
    void Update()
    {
        if(spawnObjects)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(132, 873), 5, Random.Range(0, 1400));

            Instantiate(nailPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
