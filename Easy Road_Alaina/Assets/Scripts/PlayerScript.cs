using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Timer time;
    public int startSpawn;
    public int intervalTime;
    public CityObjectSpawner cityObjectSpawner;
    public bool straightCollider;
    // Start is called before the first frame update
    void Start()
    {
        straightCollider = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (time.seconds == startSpawn){
                cityObjectSpawner.isCreatedStraight = false;   
            }
            if (cityObjectSpawner.isCreatedStraight == false){
                    
            //spawnStraight();
                if (cityObjectSpawner.spawnStraightRoads)
                {
                    cityObjectSpawner.spawnNailsStraight();
                    straightCollider = false;
                }

                startSpawn = startSpawn + intervalTime;
            }
            
        

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CheckpointStraight")
        {
            Debug.Log("Im hit");
            straightCollider = true;
            
                
        }

    }
    
}
