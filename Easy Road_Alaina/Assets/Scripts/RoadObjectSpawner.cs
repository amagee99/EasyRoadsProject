using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadObjectSpawner : MonoBehaviour
{
    public GameObject nailPrefab;
    public GameObject roadNetwork;
    public bool spawnStraightRoads;
    public bool spawnCurvedRoads;
    public Timer time;
    public int startSpawn;
    public int intervalTime;
    int randNum;
    public RoadGeneration roadGeneration;
  
    Vector3[] straightSpawnPoints;
    public bool isCreatedStraight;
    public bool isCreatedCurved;
    public bool inputStraight;
    public bool inputCurved;
    void Start(){
        spawnStraightRoads = false;
        spawnCurvedRoads = false;
        inputStraight = false;
        inputCurved = false;
        isCreatedStraight = false;
        isCreatedCurved = false;
        int j = 0;
        int k = 0; 
    }
    void Update()
    {
        if (time.seconds == startSpawn){
            if (inputStraight)
                spawnStraightRoads = true;
            if (inputCurved)
                spawnCurvedRoads = true;
        }
        else{
            spawnStraightRoads = false;
            spawnCurvedRoads = false;
        }
        
        if (spawnStraightRoads && isCreatedStraight == false)
        {
            spawnNailsStraight();
        }
        if (spawnCurvedRoads && isCreatedCurved == false)
        {
            spawnNailsCurved();
        }
    }

    public void spawnNailsStraight()
    {
       
        int randNum2 = Random.Range(0, roadGeneration.straightRoadMarkers.Length - 1);
        if (randNum2 == roadGeneration.straightRoadMarkers.Length - 1 && randNum2 % 2 != 0){
            --randNum2;
        }
        if (randNum2 % 2 != 0){
            ++randNum2;
        }
        Debug.Log(randNum2);
        Vector3 currPosition = roadGeneration.straightRoadMarkers[randNum2];
        Vector3 nextPosition = roadGeneration.straightRoadMarkers[randNum2 + 1];
       Vector3 spawnPosition = new Vector3(Random.Range(nextPosition.x, currPosition.x), 5, Random.Range(currPosition.z, nextPosition.z));
        
        int i = 0;
        
        Instantiate(nailPrefab, spawnPosition, Quaternion.identity);
            
        isCreatedStraight = true;
 
    }
    public void spawnNailsCurved()
    {
       
        int randNum3 = Random.Range(0, roadGeneration.curvedRoadMarkers.Length - 1);
        if (randNum3 == roadGeneration.curvedRoadMarkers.Length - 1 && randNum3 % 3 == 0){
            --randNum3;
        }
        else if (randNum3 % 3 == 0){
            ++randNum3;
        }
       Debug.Log(randNum3);
        Vector3 currPosition2 = roadGeneration.curvedRoadMarkers[randNum3];
        Vector3 nextPosition2 = roadGeneration.curvedRoadMarkers[randNum3 + 1];

        float xRange = roadGeneration.curvedRoadMarkers[randNum3 + 1].x - roadGeneration.curvedRoadMarkers[randNum3].x;
        float zRange = roadGeneration.curvedRoadMarkers[randNum3 + 1].z - roadGeneration.curvedRoadMarkers[randNum3].z;
        Vector3 spawnPosition = new Vector3(Random.Range(nextPosition2.x, currPosition2.x), 5, Random.Range(currPosition2.z, nextPosition2.z));
        
        // Vector3 spawnPosition = new Vector3(roadGeneration.curvedRoadMarkers[randNum3].x + (xRange * UnityEngine.Random.value), 5, roadGeneration.curvedRoadMarkers[randNum3].z + (zRange * UnityEngine.Random.value));
        int i = 0;
        
        Instantiate(nailPrefab, spawnPosition, Quaternion.identity);
            
        isCreatedCurved = true;
 
    }
}
