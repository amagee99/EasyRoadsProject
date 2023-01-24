using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ModeChangeCode : MonoBehaviour
{
    private FollowWaypointScript FollowWaypointScript;

    void Start()
    {
        //Define the FollowWaypointScript that is already attached to the GameObject_VehicleContainer as FollowWaypointScript
        FollowWaypointScript = GetComponent<FollowWaypointScript>();
        
        //At the beginning of the game, the FollowWaypointScript is disabled.
        FollowWaypointScript.enabled = false;
    }
    
    void Update()
    {
        // If user pressed the M key.
        if (Input.GetKey("m")) 
        {
            //Then, the FollowWaypointScript is enabled.
            FollowWaypointScript.enabled = true;            
        }
    }

    
}
