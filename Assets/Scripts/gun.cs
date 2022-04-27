using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class gun : MonoBehaviour
{
    public SteamVR_Action_Boolean fireAction;
    public GameObject bullet;
    public Transform barrelPivot;
    public float shootingSpeed = 1;
    private Interactable interactable;
    public AudioSource blaster;
    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<Interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
        
        if(interactable.attachedToHand != null)
        {
            SteamVR_Input_Sources source = interactable.attachedToHand.handType;

            if (fireAction[source].stateDown)
            {
                Fire();
            }
        }
    }

    void Fire()
    {

        Debug.Log("Fire");
        blaster.Play();
        Destroy(Instantiate(bullet, barrelPivot.position , barrelPivot.rotation), 0.15f);
    }
}
