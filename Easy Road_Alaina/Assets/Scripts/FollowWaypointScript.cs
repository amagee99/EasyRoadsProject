using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class FollowWaypointScript : MonoBehaviour
{
    public RCC_AIWaypointsContainer PathToFollow;

    
    public int CurrentWayPointID;

    private float speed = 5.0f;
    private float CurrentWayPointIDDistance = 5.0f;
    //reachDistance is the variable that decides when to increase the CurrentWayPointID and therefore rotate the car.
    //If this is too large, then, the car will start to rotate too early before it reaches the next waypoint.
    //In other words, it decides the sensitivity of detecting the next waypoint.
    //If it is 1.0, then, it works well and any smaller value won't make much difference. 
    private float reachDistance = 1.0f;
    private float rotationSpeed = 5.0f;
    public string pathName;

    //Reminder of the last_position variable.
    //Vector3 last_position;
    Vector3 current_position;

    
    void Start()
    {
        //This is a redundant line for getting components of RCC_AIWaypointContainer.
        //The code works well even without this line; but I'm keeping it as an example of getcomponent command.
        //PathToFollow = GameObject.Find(pathName).GetComponent<RCC_AIWaypointsContainer> (); 

        //Getting the car's last position. A reminder of transform.position.
        //last_position = transform.position;


        //Decide the CurrentWaypointID based on the distance between the car and all waypoints.
        //It should be the closest one to the car.

        for (int i = 0; i < 1; i++) //The 5 should be replaced by the size of the RCC_AIWaypointsContainer.
        {
            float eachDistance = Vector3.Distance(PathToFollow.waypoints[i].position, transform.position);
            if (eachDistance <= CurrentWayPointIDDistance)
            {               
                CurrentWayPointID = i + 1;
            }
        }

    }


    void Update()
    {


        //Calculate the distance between the current waypoint and the car's position.
        //In the beginning, the current waypoint is always 0.



        //Move the car toward the current waypoint.  
      transform.position = Vector3.MoveTowards(transform.position, PathToFollow.waypoints[CurrentWayPointID].position, Time.deltaTime * speed);

      //When we move the car, roate the car (instead of sliding it).
      var rotation = Quaternion.LookRotation(PathToFollow.waypoints[CurrentWayPointID].position - transform.position);
      transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);
        
      float distance = Vector3.Distance(PathToFollow.waypoints[CurrentWayPointID].position, transform.position);

        if (distance <= reachDistance)
        {
            
            CurrentWayPointID++; //++ means +1.
            //if (Input.anyKey)
            //{
            //    break;
            //}
            //return;
        }


        if (CurrentWayPointID >= PathToFollow.waypoints.Count)
         {
             CurrentWayPointID = 0;
         }
       
    }
}
