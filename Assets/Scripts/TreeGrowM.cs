using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGrowM : MonoBehaviour
{
    public float speed = 0.1f;
    private float xMax = 1.5219f;
    private float yMax = 1.5219f;
    private float zMax = 1.5219f;

    //starting position
    public static int direction = 1; //positive to start
    private void Start()
    {
        transform.localScale = new Vector3(1.36971f, 0, 0);
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
