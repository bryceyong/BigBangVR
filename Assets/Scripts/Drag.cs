using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public Vector3 init;
    private float time = 0.0f;
    public float interpolationPeriod = 5.0f;
    public bool once = true;
    public AudioSource dragSound;
    // Start is called before the first frame update
    void Start()
    {
         init = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;

        if (time >= interpolationPeriod)
        {
            time = 0.0f;
            init = transform.position;
            once = true;
        }

        if (transform.position != init && once)
        {
            print("trig");
            dragSound.Play();
            once = false;
        }

    }
}
