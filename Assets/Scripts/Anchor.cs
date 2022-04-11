using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anchor : MonoBehaviour
{
    public int direction = 1;
    public float speed = 0.000001f;
    public int trig = 1;
    public bool sun = false;
    public bool moon = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(sun == true)
        {
            Vector3 direction = new Vector3(0, 0, 360);
            Quaternion targetRotation = Quaternion.Euler(direction);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * 20f);
        }
        if(moon == true)
        {
            Vector3 direction = new Vector3(0, 0, 180);
            Quaternion targetRotation = Quaternion.Euler(direction);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * 20f);
        }

    }

    public void day()
    {
        sun = true;
        moon = false;
    }
    public void night()
    {
        moon = true;
        sun = false;
    }
}
