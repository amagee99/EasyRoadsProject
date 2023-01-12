using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadObjectSpawner : MonoBehaviour
{
    public GameObject nailPrefab;
    public GameObject roadNetwork;
    
    void Start(){
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));

            Instantiate(nailPrefab, roadNetwork.transform.position, Quaternion.identity);
        }
    }
}
