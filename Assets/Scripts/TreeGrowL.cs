using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGrowL : MonoBehaviour
{
    public float speed = 0.1f;
    private float xMax = 2.43017f;
    private float yMax = 2.43017f;
    private float zMax = 2.43017f;

    //starting position
    public static int direction = 1; //positive to start
    private void Start()
    {
        transform.localScale = new Vector3(2.187153f, 0, 0);
    }
    void Update()
    {
        Vector3 scale = transform.localScale;

        float xNew = transform.localScale.x + direction * speed / 10 * Time.deltaTime;
        float yNew = transform.localScale.y + direction * speed * Time.deltaTime;
        float zNew = transform.localScale.z + direction * speed * Time.deltaTime;

        transform.localScale = new Vector3(xNew, yNew, zNew);
        if (yNew > yMax)
        {
            direction = 0;
        }
    }
}
