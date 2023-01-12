using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyRoads3Dv3;

public class Testing : MonoBehaviour
{
  
    public ERRoadNetwork s;
    public ERRoad d;
    public Testing j;
   
    //public static E g;
    // Start is called before the first frame update
    void Start()
    {
        s = new ERRoadNetwork();
        d = new ERRoad();
        

    }

    // Update is called once per frame
    void Update()
    {
        //t.roadNetwork.CreateRoad("Test");
       // s.x.CreateRoad("Test");
       Debug.Log(j.d.GetMarkerPosition(1));
    }
}
