using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.eulerAngles.y > 45 && transform.rotation.eulerAngles.y < 46)
        {
           print("ye");
        }

    }
}
