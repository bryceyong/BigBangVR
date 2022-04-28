using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class choice : MonoBehaviour
{
    public SteamVR_Action_Boolean leftTrig;
    public SteamVR_Action_Boolean rightTrig;
    private Interactable interactable;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
            if (leftTrig.stateDown)
            {
                print("left");
            }
        
    }

}
