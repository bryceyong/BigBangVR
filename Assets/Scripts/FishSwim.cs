using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSwim : MonoBehaviour
{
    public static bool boxTilt;
    public float speed1;
    public float zMax;
    public float speed2;
    public float xNew2;
    public bool once = true;
    public bool once2 = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (boxTilt)
        {
            
            float zNew = transform.position.z + speed1 * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, transform.position.y, zNew);
            print(zNew);
            if (zNew > zMax)
            {
                speed1 = 0;
                if (once)
                {
                    Vector3 direction = new Vector3(0, 60, 0);
                    Quaternion targetRotation = Quaternion.Euler(direction);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * 200f);
                   
                }

                float xNew = transform.position.x + speed2 * Time.deltaTime;
                transform.position = new Vector3(xNew, transform.position.y, transform.position.z);
                if(xNew > 35.5f)
                {

                    transform.Rotate(0, 180, 0);
                    speed2 = speed2 * -1;
                    if (once2)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y, -25.5f);
                        once2 = false;
                    }
                    once = false;
                }
            }
        }
    }
}
