using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public bool cageOpen;
    public bool once;
    public float yMax;
    public float speed1 = 1f;
    public float speed2 = 1f;
    public float zMax;
    public GameObject cage;
    public static bool birdCall = false;
    public AudioSource chirp;
    public AudioSource flap;
    public bool playOnce = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cage.transform.position.x < 28.0f || cage.transform.position.x > 28.8f || 
            cage.transform.position.y > 3 || 
            cage.transform.position.z < -37.0f || cage.transform.position.z > 36.4f )
        {
            cageOpen = true;
        }

        if (cageOpen && once)
        {
            BirdSounds();
            float yNew = transform.position.y +  speed1 * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, yNew, transform.position.z);
            if (yNew > yMax)
            {
                speed1 = 0;
                Vector3 direction = new Vector3(-20, 0, 0);
                Quaternion targetRotation = Quaternion.Euler(direction);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * 100f);

                float zNew = transform.position.z + speed2 * Time.deltaTime;
                float yNew2 = transform.position.y + speed2 / 2 * Time.deltaTime;
                transform.position = new Vector3(transform.position.x, yNew2, zNew);
                if (zNew > zMax)
                {  
                    speed2 = 0;
                    birdCall = true;
                    playOnce = true;
                }
            }
        }


    }

    public void BirdSounds()
    {
        if (playOnce)
        {
            chirp.Play();
            flap.Play();
            playOnce = false;
        }
    }
}
