using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int chapter = 0;
    public bool firstTime = true;
    public int grenadeCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        chapter = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if(chapter == 2 && firstTime)
        {
            transform.position = new Vector3(30.0f, 5.0f, -1.5f);
            firstTime = false;
        }
        
    }
}
