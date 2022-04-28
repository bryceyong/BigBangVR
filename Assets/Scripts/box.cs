using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public bool tilt = false;
    public GameObject fish;
    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tilt)
        {
            Vector3 direction = new Vector3(90, 0, 0);
            Quaternion targetRotation = Quaternion.Euler(direction);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * 50f);
            fish.SetActive(true);
        }
        
    }

    public void Tilt()
    {
        print("tilt");
        tilt = true;
        FishSwim.boxTilt = true;
        Invoke("transition", 5);
    }

    public void transition()
    {
        playerController.firstTime = true;
        playerController.chapter = 6;
    }
}
