using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityRoadObjectSpawner : MonoBehaviour
{
    public GameObject nailPrefab;
    public GameObject roadNetwork;
    //public bool spawnStraightRoads;
    //public bool spawnCurvedRoads;
    public Timer time;
    public int startSpawn;
    public int intervalTime;
    int randNum;
    public RoadGeneration roadGeneration;
  
    Vector3[] straightSpawnPoints;
    public bool isCreatedStraight;
    public bool isCreatedStraightR2;
    public bool isCreatedCurved;
    public bool isCreatedCurvedR2;
    
    public bool inputStraight;
    public bool inputCurved;

    public int numStraightObjects;
    public int numCurvedObjects;
    void Start(){
        //spawnStraightRoads = false;
       // spawnCurvedRoads = false;
        
        isCreatedStraight = false;
        isCreatedCurved = false;
        int j = 0;
        int k = 0; 

        



    }

    void Update()
    {
        if (isCreatedStraight == false)
        {
            for (int i = 0; i < numStraightObjects; i++)
            {
                spawnNailsStraight();
            }
            isCreatedStraight = true;
        }
        if (isCreatedCurved == false)
        {
            for (int i = 0; i < numCurvedObjects; i++)
            {
                spawnNailsCurved();
            }
            isCreatedCurved = true;
        }
        if (isCreatedStraightR2 == false)
        {
            for (int i = 0; i < numStraightObjects; i++)
            {
                spawnNailsStraightR2();
            }
            isCreatedStraightR2 = true;
        }
        if (isCreatedCurvedR2 == false)
        {
            for (int i = 0; i < numCurvedObjects; i++)
            {
                spawnNailsCurved();
            }
            isCreatedCurvedR2 = true;
        }


    }
    /*
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
            
        //isCreatedStraight = true;
 
    }
    public void spawnNailsStraightR2()
    {
       
        int randNum = Random.Range(0, roadGeneration.straightRoadMarkers2.Length - 1);
        if (randNum == roadGeneration.straightRoadMarkers2.Length - 1 && randNum % 2 != 0){
            --randNum;
        }
        if (randNum % 2 != 0){
            ++randNum;
        }
        Debug.Log("Randnum r2:" + randNum);
        Vector3 currPosition = roadGeneration.straightRoadMarkers2[randNum];
        Vector3 nextPosition = roadGeneration.straightRoadMarkers2[randNum + 1];
       Vector3 spawnPosition = new Vector3(Random.Range(nextPosition.x, currPosition.x), 5, Random.Range(currPosition.z, nextPosition.z));
        
        int i = 0;
        
        Instantiate(nailPrefab, spawnPosition, Quaternion.identity);
            
        //isCreatedStraight = true;
 
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
        else if (randNum3 == 0){
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
 
    }*/

    public void spawnNailsStraight()
    {
        int randNum = Random.Range(0, roadGeneration.straightRoadMarkers.Length - 1);
        Vector3 spawnPosition = roadGeneration.straightRoadMarkers[randNum];
        Instantiate(nailPrefab, spawnPosition, Quaternion.identity);
    }
    public void spawnNailsCurved()
    {
        int randNum = Random.Range(0, roadGeneration.curvedRoadMarkers.Length - 1);
        Vector3 spawnPosition = roadGeneration.curvedRoadMarkers[randNum];
        Instantiate(nailPrefab, spawnPosition, Quaternion.identity);
    }
    public void spawnNailsStraightR2()
    {
        int randNum = Random.Range(0, roadGeneration.straightRoadMarkers2.Length - 1);
        Vector3 spawnPosition = roadGeneration.straightRoadMarkers2[randNum];
        Instantiate(nailPrefab, spawnPosition, Quaternion.identity);
    }
    public void spawnNailsCurvedR2()
    {
        int randNum = Random.Range(0, roadGeneration.curvedRoadMarkers2.Length - 1);
        Vector3 spawnPosition = roadGeneration.curvedRoadMarkers2[randNum];
        Instantiate(nailPrefab, spawnPosition, Quaternion.identity);
    }
   

    
}
