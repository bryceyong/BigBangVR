using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGrow : MonoBehaviour
{

    public float speed = 5.0f;
    private float xMax = 44.045f;
    private float yMax = 44.045f;
    private float zMax = 44.045f;

    //starting position
    public static int direction = 1; //positive to start
    private void Start()
    {
        transform.localScale = new Vector3(0,0,0);
    }
    void Update()
    {
        Vector3 scale = transform.localScale;

        float xNew = transform.localScale.x + direction * speed * Time.deltaTime;
        float yNew = transform.localScale.y + direction * speed * Time.deltaTime;
        float zNew = transform.localScale.z + direction * speed * Time.deltaTime;

        transform.localScale = new Vector3(44.045f, yNew, zNew);
        if (yNew > yMax)
        {
            direction = 0;
        }
    }
}
