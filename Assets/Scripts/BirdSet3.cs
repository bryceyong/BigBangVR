using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSet3 : MonoBehaviour


{
    public bool flyIn;
    public float speed1;
    public float speed2;
    public float zMax;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Bird.birdCall)
        {


            float zNew = transform.position.z - speed1 * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, transform.position.y, zNew);

            print(zNew);

            if (zNew < zMax)
            {
                speed1 = 0;


            }


        }
    }
}
