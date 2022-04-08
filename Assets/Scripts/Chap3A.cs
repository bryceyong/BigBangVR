using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Valve.VR.InteractionSystem;

public class Chap3A : MonoBehaviour
{
	private string[] narrationArr3A = {
		"Looks like that wave really knocked you to the depths.",
		"We need to get back to the surface. Let's see what we're dealing with here.",
		"Earth is composed of multiple layers.",
		"The first layer, the crust, the thinnest of all layers. The crust is where all of civilization is built.",
		"The mantle is the second outermost layer full of molten magma.",
		"The outer layer is composed of iron and nickel in liquid form and the inner core is composed of condensed iron about  ¾ of the moon with an extremely hot surface.",
		"Try stretching out the layers of the earth and we can use them as a set of staircases to get back up!",
		"Stretch them out as evenly as you can to prevent an imbalance",
	};

	public TextMeshProUGUI narration;

	public GameObject redRock;
	public GameObject blackRock;
	public GameObject tp1;
	public GameObject tp2;
	public GameObject tp3;
	public GameObject player;

	private int i = 0;

	public void skip()
	{
		narration.SetText(narrationArr3A[i]);
		if (i < 7)
		{
			i++;
		}  
	}

    public void Update()
    {
		
        if(redRock.GetComponent<LinearMapping>().value > 0.5)
        {
			tp1.GetComponent<TeleportPoint>().SetLocked(false);
		} 
		if (blackRock.GetComponent<LinearMapping>().value > 0.5)
		{
			tp2.GetComponent<TeleportPoint>().SetLocked(false);
		}
		if(player.transform.position.y > 1.9)
        {
			tp3.GetComponent<TeleportPoint>().SetLocked(false);
		}
	}
}
