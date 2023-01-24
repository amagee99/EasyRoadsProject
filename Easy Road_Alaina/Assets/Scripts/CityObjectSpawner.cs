using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityObjectSpawner : MonoBehaviour
{
    public GameObject nailPrefab;
    
    public bool spawnStraightRoads;
    public bool spawnRightCurve;
    public bool spawnLeftCurve;

    int straightCount = 0;
    int rightCount = 0;
    int leftCount = 0;
    public RoadGeneration roadGeneration;
  
    Vector3[] straightSpawnPoints;
    public bool isCreatedStraight;
    public bool isCreatedRight;
    public bool isCreatedCurved;
    void Start(){
        isCreatedStraight = false;
        isCreatedRight = false;
        int j = 0;
        int k = 0; 
    }


    public void spawnNailsStraight()
    {
       
        
        
        Debug.Log(straightCount);
        if (straightCount < roadGeneration.straightRoadMarkers.Length - 1)
        {
            Vector3 currPosition = roadGeneration.straightRoadMarkers[straightCount];
            Vector3 nextPosition = roadGeneration.straightRoadMarkers[straightCount + 1];
            Vector3 spawnPosition = new Vector3(Random.Range(nextPosition.x, currPosition.x), 5, Random.Range(currPosition.z, nextPosition.z));

            Instantiate(nailPrefab, spawnPosition, Quaternion.identity);
            straightCount = straightCount + 2;
        }
        isCreatedStraight = true;
        
 
    }
    public void spawnNailsRightCurve()
    {
       Debug.Log(rightCount);
        if (rightCount < roadGeneration.curvedRoadMarkers.Length - 1)
        {
            Vector3 currPosition = roadGeneration.curvedRoadMarkers[rightCount];
            Vector3 nextPosition = roadGeneration.curvedRoadMarkers[rightCount + 1];
            Vector3 spawnPosition = new Vector3(Random.Range(nextPosition.x, currPosition.x), 5, Random.Range(currPosition.z, nextPosition.z));

            Instantiate(nailPrefab, spawnPosition, Quaternion.identity);

           //if (roadGeneration.curvedRoadMarkers[rightCount]) +6
           // rightCount = rightCount + 2;
        }
        isCreatedRight = true;
       
 
    }

    
}