using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Chap6 : MonoBehaviour
{
	// Start is called before the first frame update
	private string[] narrationArr2 = {
		"Now that you have created the sea and sky creatures we need to make our homosapiens and land animals.",
		"Earth has a range of animals that are vegetarian, carnivorous and herbivores.",
		"People have made themselves the prime hunter dominating the world, leaving the other animals to adapt to new environments and situations.",
		"The creation of humans is a difficult task! But I know you are up to the challenge creator. Go ahead and pull the lever to begin the process!",
	};

	public TextMeshProUGUI narration;
	public TextMeshProUGUI progress;
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
	public GameObject lever;
	public GameObject dancers;
	public AudioSource music;
	public AudioSource c6;
	public GameObject dancersObj;
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
		if (!buttonPressed && i < 4)
		{
			buttonClick.Play();
			Delay();
			buttonPressed = true;
			timeRemaining = 2;
			i++;
		}
	}

	public void Delay()
	{
		if (i < 4)
		{
			progress.SetText((i + 1).ToString() + " / 4");
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
		if (i == 4)
		{
			p4.Stop();
			p5.Play();
		}
		if (i == 3)
		{
			lever.SetActive(true);
			Invoke("transition", 60);
		}
		if (i == 4)
        {
			transition();
        }
	}
	public void transition()
	{
		playerController.firstTime = true;
		playerController.chapter = 7;
	}

	public void Dance()
    {
		dancers.SetActive(true);
		music.Stop();
		c6.Play();
	}
}
