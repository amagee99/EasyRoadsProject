using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindridgeCitySpawner : MonoBehaviour
{
    [SerializeField] GameObject puddle;
    public int interval; 

    public Transform[] tunnelLeftTransforms;
    bool isCreatedTunnelL;
    public Transform[] tunnelRightTransforms;
    bool isCreatedTunnelR;
    public Transform[] curvedPathDenseTransforms;
    bool isCreatedCurvedDense;
    public Transform[] curvedPathSmallTransforms;
    bool isCreatedCurvedSmall;
    public Transform[] curvedPathSparseTransforms;
    bool isCreatedCurvedSparse;
    public Transform[] CityRoadsStraightTransforms;
    bool isCreatedCityRoadStraight;

    public bool spawnCurvedRoads;
    public bool spawnStraightRoads;
    //Vector3[] tunnelLeftPoints = new Vector3[tunnelLeftTransforms.Length / interval];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnStraightRoads)
        {
            TunnelLeftSpawn();
            TunnelRightSpawn();
            CityRoadStraightSpawn();
        }
        if (spawnCurvedRoads)
        {
            CurvedPathDenseSpawn();
            CurvedPathSmallSpawn();
            CurvedPathSparseSpawn();
        }
        
    }

    public void TunnelLeftSpawn()
    {
        if (isCreatedTunnelL == false)
        {
            for (int i = 0; i < tunnelLeftTransforms.Length; i = i + interval)
            {
                Instantiate(puddle, tunnelLeftTransforms[i].position, Quaternion.identity);
            }
            isCreatedTunnelL = true;
        }
    }
    public void TunnelRightSpawn()
    {
        if (isCreatedTunnelR == false)
        {
            for (int i = 0; i < tunnelRightTransforms.Length; i = i + interval)
            {
                Instantiate(puddle, tunnelRightTransforms[i].position, Quaternion.identity);
            }
            isCreatedTunnelR = true;
        }
    }
    public void CurvedPathDenseSpawn()
    {
        if (isCreatedCurvedDense == false)
        {
            for (int i = 0; i < curvedPathDenseTransforms.Length; i = i + interval)
            {
                Instantiate(puddle, curvedPathDenseTransforms[i].position, Quaternion.identity);
            }
            isCreatedCurvedDense = true;
        }
    }
    public void CurvedPathSmallSpawn()
    {
        if (isCreatedCurvedSmall == false)
        {
            for (int i = 0; i < curvedPathSmallTransforms.Length; i = i + interval)
            {
                Instantiate(puddle, curvedPathSmallTransforms[i].position, Quaternion.identity);
            }
            isCreatedCurvedSmall = true;
        }
    }
    public void CurvedPathSparseSpawn()
    {
        if (isCreatedCurvedSparse == false)
        {
            for (int i = 0; i < curvedPathSparseTransforms.Length; i = i + interval)
            {
                Instantiate(puddle, curvedPathSparseTransforms[i].position, Quaternion.identity);
            }
            isCreatedCurvedSparse = true;
        }
    }
    public void CityRoadStraightSpawn()
    {
        if (isCreatedCityRoadStraight == false)
        {
            for (int i = 0; i < CityRoadsStraightTransforms.Length; i = i + interval)
            {
                Instantiate(puddle, CityRoadsStraightTransforms[i].position, Quaternion.identity);
            }
            isCreatedCityRoadStraight = true;
        }
    }

}
