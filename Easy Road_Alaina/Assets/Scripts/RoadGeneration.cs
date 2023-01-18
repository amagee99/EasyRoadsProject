
/*
 * EasyRoads3D Runtime API example
 * 
 * Important:
 * 
 * It has occured that the terrain was not restored leaving the road shape in the terrain 
 * after exiting Play Mode. This happened after putting focus on the Scene View 
 * window while in Play Mode! In another occasion this consistently happened until the 
 * Scene View window got focus! 
 * 
 * Please check the above using a test terrain and / or backup your terrains before using this code!
 * 
 * You can backup your terrain by simply duplicating the terrain object 
 * in the project folder
 * 
 * Also, check the OnDestroy() code, without this code the shape of the generated roads
 * will certainly remain in the terrain object after you exit Play Mode!
 * 
 * 
 * 
 * 
 * */


using UnityEngine;
using System.Collections;
using EasyRoads3Dv3;


public class RoadGeneration : MonoBehaviour {
	

	public ERRoadNetwork roadNetwork;
	
	public ERRoad road;
	
	//public GameObject go;
	public int currentElement = 0;
	public float distance = 0;
	public float speed = 5f;

	public Vector3 point1;
	public Vector3 point2;
	public Vector3 point3;
	public Vector3 point4;
	//mycode
	 [SerializeField] [Range(1,10)] public int pointsNum;

	public Vector3[] straightRoadMarkers;
	public Vector3[] curvedRoadMarkers;
	void Start () {
	
		Debug.Log("Please read the comments at the top of the runtime script (/Assets/EasyRoads3D/Scripts/runtimeScript) before using the runtime API!");

		// Create Road Network object
		roadNetwork = new ERRoadNetwork();

		// Create road
	//	ERRoad road = roadNetwork.CreateRoad(string name);
	//	ERRoad road = roadNetwork.CreateRoad(string name, Vector3[] markers);
	//	ERRoad road = roadNetwork.CreateRoad(string name, ERRoadType roadType);
	//	ERRoad road = roadNetwork.CreateRoad(string name, ERRoadType roadType, Vector3[] markers);

        // get exisiting road types
    //  ERRoadType[] roadTypes = roadNetwork.GetRoadTypes();
    //  ERRoadType roadType = roadNetwork.GetRoadTypeByName(string name);
        

        // create a new road type
		ERRoadType roadType = new ERRoadType();
		roadType.roadWidth = 6;
		roadType.roadMaterial = Resources.Load("Materials/roads/road material") as Material;
        // optional
        roadType.layer = 1;
        roadType.tag = "Untagged";

		ERRoadType roadType2 = new ERRoadType();
		roadType2.roadWidth = 15;
		roadType2.roadMaterial = Resources.Load("Materials/roads/3Lane Road Material") as Material;
        // optional
        roadType2.layer = 1;
        roadType2.tag = "Untagged";
				
   //   roadType.hasMeshCollider = false; // default is true

//		roadType = roadNetwork.GetRoadTypeByName("Train Rail");
//		Debug.Log(roadType.roadMaterial);

        // create a new road
		//Vector3[] markers = new Vector3[4];
		/*markers[0] = new Vector3(200, 5, 200);
		markers[1] = new Vector3(250, 5, 200);
		markers[2] = new Vector3(250, 5, 250);
		markers[3] = new Vector3(300, 5, 250);*/
		//myCode
		/*markers[0] = point1;
		markers[1] = point2;
		markers[2] = point3;
		markers[3] = point4;*/
		//mycode
		/*int zVal = 0;

		Vector3[] markers = new Vector3[pointsNum];
		for (int i = 0; i < pointsNum; i++)
		{
			markers[i] = new Vector3(500, 5, zVal);
			zVal = zVal + 250;
		}
		road = roadNetwork.CreateRoad("road 1", roadType, markers);
*/	
		
		road = roadNetwork.CreateRoad("road 1", roadType2);//, markers);
		int zVal = 0;
		int zValCurve = 250;//125
		int xValCurve = 470;
		
		straightRoadMarkers = new Vector3[pointsNum * 2];
		curvedRoadMarkers = new Vector3[pointsNum * 2];
		int j = 0;
		int k = 0;
		for (int i = 0; i < pointsNum; i++)
		{
			
			road.AddMarker(new Vector3(500, 0.5f, zVal));//500
			straightRoadMarkers[j] = new Vector3(500, 0.5f, zVal);
			zVal = zVal + 125;
			road.AddMarker(new Vector3(500, 0.5f, zVal));
			++j;
			straightRoadMarkers[j] = new Vector3(500, 0.5f, zVal);
			curvedRoadMarkers[k] = new Vector3(500, 0.5f, zVal);
			zVal = zVal + 125;
			++j;
			++k;
			road.AddMarker(new Vector3(xValCurve, 0.5f, zVal));
			curvedRoadMarkers[k] = new Vector3(xValCurve, 0.5f, zVal);
			++k;
			zVal = zVal + 125;
			if (i % 2 == 0){
				xValCurve = xValCurve + 60;
			}
			else{
				xValCurve = xValCurve - 60;
			}
		}
		


//road2

		road = roadNetwork.CreateRoad("road 2", roadType2);//, markers);
		int zVal2 = 0;
		int zValCurve2 = 125;
		int xValCurve2 = 500;
		
		for (int i = 0; i < pointsNum; i++)
		{
			road.AddMarker(new Vector3(530, 0.5f, zVal2));
			zVal2 = zVal2 + 125;
			road.AddMarker(new Vector3(530, 0.5f, zVal2));
			zVal2 = zVal2 + 125;
			road.AddMarker(new Vector3(xValCurve2, 0.5f, zVal2));
			zVal2 = zVal2 + 125;
			
			if (i % 2 == 0){
				xValCurve2 = xValCurve2 + 60;
			}
			else{
				xValCurve2 = xValCurve2 - 60;
			}
		}


		//road.InsertMarker(new Vector3(275, 5, 125));

     // road.SetResolution(float value):void;


		// Add Marker: ERRoad.AddMarker(Vector3);
		//road.AddMarker(new Vector3(500, 5, 500));

		// Add Marker: ERRoad.InsertMarker(Vector3);
		//road.InsertMarker(new Vector3(275, 5, 235));
    //  road.InsertMarkerAt(Vector3 pos, int index): void;

		// Delete Marker: ERRoad.DeleteMarker(int index);
		road.DeleteMarker(2);


		// Set the road width : ERRoad.SetWidth(float width);
	//	road.SetWidth(10);

		// Set the road material : ERRoad.SetMaterial(Material path);
	//	Material mat = Resources.Load("Materials/roads/single lane") as Material;
	//	road.SetMaterial(mat);

        // add / remove a meshCollider component
   //   road.SetMeshCollider(bool value):void;

        // set the position of a marker
   //   road.SetMarkerPosition(int index, Vector3 position):void;
   //   road.SetMarkerPositions(Vector3[] position):void;
   //   road.SetMarkerPositions(Vector3[] position, int index):void;

        // get the position of a marker
   //   road.GetMarkerPosition(int index):Vector3;

        // get the position of a marker
   //   road.GetMarkerPositions():Vector3[];

        // Set the layer
   //   road.SetLayer(int value):void;

        // Set the tag
       //   road.SetTag(string value):void;

        // set marker control type
        //  road.SetMarkerControlType(int marker, ERMarkerControlType type) : bool; // Spline, StraightXZ, StraightXZY, Circular

        // find a road
        //  public static function ERRoadNetwork.GetRoadByName(string name) : ERRoad;
        
        // get all roads
        //  public static function ERRoadNetwork.GetRoads() : ERRoad[];  

		// snap vertices to the terrain (no terrain deformation)
//		road.SnapToTerrain(true);

		// Build Road Network 
		roadNetwork.BuildRoadNetwork();

		// remove script components
//		roadNetwork.Finalize();

		// Restore Road Network 
	//	roadNetwork.RestoreRoadNetwork();

        // Show / Hide the white surfaces surrounding roads
   //     public function roadNetwork.HideWhiteSurfaces(bool value) : void;

   //   road.GetConnectionAtStart(): GameObject;
   //   road.GetConnectionAtStart(out int connection): GameObject; // connections: 0 = bottom, 1= tip, 2 = left, 3 = right (the same for T crossings)

   //   road.GetConnectionAtEnd(): GameObject;
   //   road.GetConnectionAtEnd(out int connection): GameObject; // connections: 0 = bottom, 1= tip, 2 = left, 3 = right (the same for T crossings)

        // Snap the road vertices to the terrain following the terrain shape (no terrain deformation)
   //   road.SnapToTerrain(bool value): void;
   //   road.SnapToTerrain(bool value, float yOffset): void;

        // get the road length
   //   road.GetLength() : float;

		// create dummy object
		//go = GameObject.CreatePrimitive(PrimitiveType.Cube);


	}
	
	void Update () {
	
		if(roadNetwork != null){
			float deltaT = Time.deltaTime;
			float rSpeed = (deltaT * speed);
		
			distance += rSpeed;

			// pass the current distance to get the position on the road
//			Debug.Log(road);
			Vector3 v = road.GetPosition(distance, ref currentElement);
			v.y += 1;
		
			
			//go.transform.position = v;
			//go.transform.forward = road.GetLookatSmooth(distance, currentElement);;
			//mycode
			//roadNetwork.CreateRoad("myRoad", new Vector3(0, 0, 0));
			
		}

        // spline point info center of the road
        //      public function ERRoad.GetSplinePointsCenter() : Vector3[];

        // spline point info center of the road
        //      public function ERRoad.GetSplinePointsRightSide() : Vector3[];

        // spline point info center of the road
        //      public function ERRoad.GetSplinePointsLeftSide() : Vector3[];

        // Get the selected road in the Unity Editor
        //  public static function EREditor.GetSelectedRoad() : ERRoad;   



	}
	
	void OnDestroy(){

		// Restore road networks that are in Build Mode
		// This is very important otherwise the shape of roads will still be visible inside the terrain!

		if(roadNetwork != null){
			if(roadNetwork.isInBuildMode){
				roadNetwork.RestoreRoadNetwork();
				Debug.Log("Restore Road Network");
			}
		}
	}
}
