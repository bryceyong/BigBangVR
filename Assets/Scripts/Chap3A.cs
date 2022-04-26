using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Valve.VR.InteractionSystem;

public class Chap3A : MonoBehaviour
{
	private string[] narrationArr3A = {
		"We need to get back to the surface! Let's see what we are dealing with!",
		"The first layer, the crust, the thinnest of all layers. The crust is where all of civilization is built.",
		"The mantle is the second outermost layer full of molten magma.",
		"The outer layer is composed of iron and nickel in liquid form and the inner core is composed of condensed iron about  � of the moon with an extremely hot surface.",
		"Try stretching out the layers of the earth and we can use them as a staircase to get back up!",
		"Stretch them out evenly so there won�t be an imbalance.",
	};

	public TextMeshProUGUI narration;

	public GameObject redRock;
	public GameObject blackRock;
	public GameObject tp1;
	public GameObject tp2;
	public GameObject tp3;
	public GameObject player;
	public bool buttonPressed;
	public float timeRemaining;
	public AudioSource buttonClick;
	public AudioSource p1;
	public AudioSource p2;
	public AudioSource p3;
	public AudioSource p4;
	public AudioSource p5;
	public AudioSource p6;

	private int i = 0;

	public void skip()
	{
		if (!buttonPressed)
		{
			buttonClick.Play();
			Delay();
			buttonPressed = true;
			timeRemaining = 2;
		}
	}

	public void Delay()
    {
		narration.SetText(narrationArr3A[i]);
		if (i < 6)
		{
			i++;
		}

	}

    public void Update()
    {
		if (buttonPressed)
		{
			if (timeRemaining > 0)
			{
				timeRemaining -= Time.deltaTime;
			}
			else
			{
				buttonPressed = false;
			}
		}

		if (redRock.GetComponent<LinearMapping>().value > 0.5)
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
