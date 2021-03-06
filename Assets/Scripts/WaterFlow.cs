using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFlow : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.0f;
    private float zMax = 0f;
    public AudioSource wave;
    public GameObject ocean;
 //starting position
    public static int direction = 0; //positive to start

    void Update()
    {
       
        float zNew = transform.position.z + direction * speed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, transform.position.y, zNew);
        if(zNew < zMax)
        {
            direction = 0;
            EndWave();
            //print("stop");
        }
    }

    public void PlayWave()
    {
        wave.Play();
    }
    public void EndWave()
    {
        wave.Stop();
    }
}
