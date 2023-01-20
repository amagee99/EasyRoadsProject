using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacetrackObjectSpawner : MonoBehaviour
{
    public bool straightRoads;
    public bool rightCurves;
    public bool leftCurves;
    public Timer time;
    public int selectSeconds;
    public int startSpawn;

    public GameObject puddle;
    public Transform startPoint;
    public Transform endPoint;
    public bool isCreated;

    public bool spawnRight;
    public bool spawnLeft;
    public bool spawnStraight;

    public Transform[] straightTransforms;
    public Transform[] rightTransforms;
    public Transform[] leftTransforms;
    
    public int intervalTime;
    

    // Start is called before the first frame update
    void Start()
    {
       isCreated = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
        if (time.seconds == startSpawn){
            int i = 0;
            ++i;
            isCreated = false;
           
            
            
        }
            
        if (isCreated == false){
          //spawnStraight();
            if (spawnLeft)
                spawnLeftCurve();
            if (spawnRight)
                spawnRightCurve();
            if (spawnStraight)
                spawnStraightRoad();
            
            startSpawn = startSpawn + intervalTime;
        }
        
        
        

    }

    private void spawnStraightRoad()
    {
        int randNum = Random.Range(0, straightTransforms.Length - 1);
        if (randNum == straightTransforms.Length - 1 && randNum % 2 != 0){
            --randNum;
        }
        else if (randNum % 2 != 0){
            ++randNum;
        }
        Debug.Log(randNum);
        float xRange = straightTransforms[randNum + 1].position.x - straightTransforms[randNum].position.x;
        float yRange = straightTransforms[randNum + 1].position.y - straightTransforms[randNum].position.y;
        float zRange = straightTransforms[randNum + 1].position.z - straightTransforms[randNum].position.z;

        Vector3 spawnPoint = new Vector3(straightTransforms[randNum].position.x + (xRange * UnityEngine.Random.value), straightTransforms[randNum].position.y + (yRange * UnityEngine.Random.value), straightTransforms[randNum].position.z + (zRange * UnityEngine.Random.value));

        Instantiate(puddle, spawnPoint, Quaternion.identity);
        isCreated = true;

    }
    private void spawnRightCurve()
    {
        int randNum = Random.Range(0, rightTransforms.Length - 1);
        if (randNum == rightTransforms.Length - 1){
            --randNum;
        }
        
        Debug.Log(randNum);
        float xRange = rightTransforms[randNum + 1].position.x - rightTransforms[randNum].position.x;
        float yRange = rightTransforms[randNum + 1].position.y - rightTransforms[randNum].position.y;
        float zRange = rightTransforms[randNum + 1].position.z - rightTransforms[randNum].position.z;

        Vector3 spawnPoint = new Vector3(rightTransforms[randNum].position.x + (xRange * UnityEngine.Random.value), rightTransforms[randNum].position.y + (yRange * UnityEngine.Random.value), rightTransforms[randNum].position.z + (zRange * UnityEngine.Random.value));

        Instantiate(puddle, spawnPoint, Quaternion.identity);
        isCreated = true;

    }
    private void spawnLeftCurve()
    {
        int randNum = Random.Range(0, leftTransforms.Length - 1);
        if (randNum == leftTransforms.Length - 1){
            --randNum;
        }
        
        Debug.Log(randNum);
        float xRange = leftTransforms[randNum + 1].position.x - leftTransforms[randNum].position.x;
        float yRange = leftTransforms[randNum + 1].position.y - leftTransforms[randNum].position.y;
        float zRange = leftTransforms[randNum + 1].position.z - leftTransforms[randNum].position.z;

        Vector3 spawnPoint = new Vector3(leftTransforms[randNum].position.x + (xRange * UnityEngine.Random.value), leftTransforms[randNum].position.y + (yRange * UnityEngine.Random.value), leftTransforms[randNum].position.z + (zRange * UnityEngine.Random.value));

        Instantiate(puddle, spawnPoint, Quaternion.identity);
        isCreated = true;

    }

}
