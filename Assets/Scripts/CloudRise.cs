using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudRise : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.0f;
    private float yMax = -4.0f;

 //starting position
    public static int direction = 0; //positive to start

    void Update()
    {
       
        float yNew = transform.position.y + direction * speed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, yNew, transform.position.z);
        if(yNew > yMax ){
            direction = 0;
        }
    }
}
