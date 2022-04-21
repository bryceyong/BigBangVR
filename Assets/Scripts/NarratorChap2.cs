using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NarratorChap2 : MonoBehaviour
{
	// Start is called before the first frame update

	private string[] narrationArr2 = {
		"Great! Now that we can see, let's create a planet!",
		"Before we make the rock let's collect the needed gasses and elements to create a bubble for our planet.",
		"First let's recap what's needed to allow for an inhabitable planet.",
		"For reference, Earth’s atmosphere is composed of about 78 percent nitrogen, 21 percent oxygen, 0.9 percent argon, and 0.1 percent other gasses.",
		"Within the atmosphere is a range of layers giving a natural protective layer for its surface, which is dependent on the elemental composition in the atmosphere. So what do you want in your atmosphere?",
		"Use the screen on your left to alter the air composition. Hit done when to you are ready.",
		"Atmosphere created",
		"So we have the atmosphere but we also need to make a life sustaining liquid, a base for your world but will also supports the atmosphere too.",
		"The atmosphere will also serve as a transportation highway for your liquid within our developing world",
		"Spin the wheel on your right to release the water.",
	};

	public TextMeshProUGUI narration;
	public TextMeshProUGUI progress;
	public Button yourButton;
    public int speed;

    public GameObject hoverButtons;
	public GameObject wheel;
	private int i = 0;
	public AudioSource p1;
	public AudioSource p2;
	public AudioSource p3;
	public AudioSource p4;
	public AudioSource p5;
	public AudioSource p6;
	public AudioSource p7;
	public AudioSource p10;
	public AudioSource buttonClick;
	private bool buttonPressed = false;
	private float timeRemaining = 2;
	public int done = 0;
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

	// Update is called once per frame
	public void skip(){
		if (!buttonPressed)
		{
			buttonClick.Play();
			Delay();
			buttonPressed = true;
			timeRemaining = 2;
		}
	}
	public void enableWater(){
		WaterFlow.direction = -1;
	}


	public void Delay()
    {
		narration.SetText(narrationArr2[i]);
		if (i < 10)
		{
			i++;
		}
	
		if (i == 1)
		{
			p1.Play();
		}
		if (i == 2)
		{
			p1.Stop();
			p2.Play();
		}
		if (i == 3)
		{
			p2.Stop();
			p3.Play();
		}
		if (i == 4)
		{
			p3.Stop();
			p4.Play();
		}
		if (i == 5)
		{
			p4.Stop();
			p5.Play();
		}
		if (i == 6)
		{
			p5.Stop();
			p6.Play();
		}
		if (i == 7)
		{
			p6.Stop();
			p7.Play();
		}
		if (i == 10)
        {
			p10.Play();
        }
		if (i == 6)
		{
			hoverButtons.SetActive(true);
		}
		if (i == 7)
        {
			CloudRise.direction = 1;
		}

		if (i == 10)
		{
			wheel.SetActive(true);
		}
	}
}
