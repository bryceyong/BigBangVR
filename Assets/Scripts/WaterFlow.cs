using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFlow : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.0f;
    private float zMax = 0.0f;

 //starting position
    public static int direction = 0; //positive to start

    void Update()
    {
       
        float zNew = transform.position.z + direction * speed * Time.deltaTime;
        transform.position = new Vector3(30, 1.5f, zNew);
        if(zNew < zMax ){
            direction = 0;
        }
    }
}
