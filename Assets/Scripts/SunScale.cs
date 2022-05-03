using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunScale : MonoBehaviour
{
    public float speed = 0;
    public float i = 0;
    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xNew = transform.localScale.x + speed * Time.deltaTime;
        float yNew = transform.localScale.y + speed * Time.deltaTime;
        float zNew = transform.localScale.z + speed * Time.deltaTime;

        transform.localScale = new Vector3(xNew, yNew, zNew);
    }

    public void Enlarge()
    {
        speed = 30;
        Invoke("Stop", 3);
    }

    public void Stop()
    {
        i++;
        if(i == 3)
        {
            playerController.chapter = 5;
            playerController.firstTime = true;
        }
        speed = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            print("hit");
            Enlarge();
        }
    }
}
