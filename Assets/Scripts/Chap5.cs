using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Chap5 : MonoBehaviour
{
	// Start is called before the first frame update
	private string[] narrationArr2 = {
		"The next set is creating the creatures that inhabit this world.",
		"Earth has a selection of animals that are not land tied, have the ability to live underwater, and fly.",
		"Birds have hollow bones that allow for a lighter body making them able to fly. Fish have gills that separate oxygen from water.",
		"Unlock the cage to release the birds into the sky ",
		"Next, knock over the box to allow the fish to swim in the water",
	};

	public TextMeshProUGUI narration;
	public GameObject grass;
	public GameObject shrooms;
	public GameObject rain;
	public PlayerController playerController;
	public bool buttonPressed;
	public float timeRemaining = 2;
	public AudioSource buttonClick;
	public AudioSource p1;
	public AudioSource p2;
	public AudioSource p3;
	public AudioSource p4;
	public AudioSource p5;
	public GameObject bird;
	public GameObject fish;
	private int i = 0;

	// Update is called once per frame
	void Update()
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

	}
	public void skip()
	{
		if (!buttonPressed && i < 5)
		{
			buttonClick.Play();
			Delay();
			buttonPressed = true;
			timeRemaining = 2;
			i++;
		}
		if (!buttonPressed && i == 7)
		{
			transition();
		}



	}

	public void Delay()
	{
		if (i < 5)
		{
			narration.SetText(narrationArr2[i]);
		}
		if (i == 0)
		{
			p1.Play();
		}
		if (i == 1)
		{
			p1.Stop();
			p2.Play();
		}
		if (i == 2)
		{
			p2.Stop();
			p3.Play();
		}
		if (i == 3)
		{
			p3.Stop();
			p4.Play();
		}
		if (i == 4)
		{
			p4.Stop();
			p5.Play();
		}
		if (i == 3)
        {
			bird.SetActive(true);
        }
		if(i == 4)
        {
			fish.SetActive(true);
        }
	}
		public void transition()
	{
		playerController.firstTime = true;
		rain.SetActive(false);
		playerController.chapter = 6;
	}
}
