using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindridgeSpawner : MonoBehaviour
{
    
    public Timer time;
    public int intervalTime;
    public int startSpawn;

    public Transform[] straightTransforms;
    public GameObject puddle;
   
    public bool isCreated;
    public bool spawnStraight;
    
    // Start is called before the first frame update
    void Start()
    {
        
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
}
