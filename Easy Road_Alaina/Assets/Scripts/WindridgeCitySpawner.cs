using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindridgeCitySpawner : MonoBehaviour
{
    public Transform[] tunnelLeftTransforms;
    bool isCreatedTunnelL;
    [SerializeField] GameObject puddle;
    public int interval; 

    //Vector3[] tunnelLeftPoints = new Vector3[tunnelLeftTransforms.Length / interval];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCreatedTunnelL == false)
        {
           /* for (int i = 0; i < tunnelLeftTransforms.Length; i = i + interval)
            {
                Instantiate(puddle, tunnelLeftTransforms[i].position, Quaternion.identity);
            }
            isCreatedTunnelL = true;*/
        }
    }
}
