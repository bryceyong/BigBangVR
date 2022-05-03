using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSet : MonoBehaviour

    
{
    public bool flyIn;
    public float speed1;
    public float speed2;
    public float zMax;
    public AudioSource chirp;
    public AudioSource flap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Bird.birdCall)
        {

            chirp.Play();
            flap.Play();

            float zNew = transform.position.z - speed1 * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, transform.position.y, zNew);

            print(zNew);

            if (zNew < zMax)
            {
                speed1 = 0;

                Vector3 direction = new Vector3(0, -10, 0);
                Quaternion targetRotation = Quaternion.Euler(direction);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * 20f);
                float zNew2 = transform.position.z - speed2 * Time.deltaTime;
                transform.position = new Vector3(transform.position.x, transform.position.y, zNew2);
                float xNew = transform.position.x + speed2 * Time.deltaTime;
                transform.position = new Vector3(xNew, transform.position.y, transform.position.z);

            }


        }
    }
}
