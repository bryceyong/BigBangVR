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
		"You can use the buttons on the side to begin adding the desired elements ",
		"The atmosphere has been created ",
		"We next need to make a life-sustaining liquid.",
		"Our atmosphere will now act as the superhighway in the sky that moves water everywhere over the Planet. Water at the planet's surface will evaporate into water vapor which rises up into the sky to become part of a cloud.",
		"Then the water will float off with the winds, eventually releasing water back to Earth as precipitation. ",
		"It's a giant cycle fully dependent on two parts for a thriving planet.",
		"Spin the wheel on the right to release the water.",
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
	public AudioSource p8;
	public AudioSource p9;
	public AudioSource p10;
	public AudioSource p11;
	public AudioSource p12;
	public AudioSource buttonClick;
	public AudioSource steam;
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
		if (!buttonPressed && i < 12)
		{
			buttonClick.Play();
			Delay();
			buttonPressed = true;
			timeRemaining = 2;
			i++;
		}
	}
	public void enableWater(){
		print("trigger");
		WaterFlow.direction = -1;
	}


	public void Delay()
    {
		narration.SetText(narrationArr2[i]);
		progress.SetText((i + 1).ToString() + " / 12");

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
		if (i == 5)
		{
			p5.Stop();
			p6.Play();
		}
		if (i == 6)
		{
			p6.Stop();
			p7.Play();
		}
		if (i == 7)
		{
			p7.Stop();
			p8.Play();
		}
		if (i == 8)
		{
			p8.Stop();
			p9.Play();
		}
		if (i == 9)
		{
			p9.Stop();
			p10.Play();
		}
		if (i == 10)
		{
			p10.Stop();
			p11.Play();
		}
		if (i == 11)
        {
			p11.Stop();
			p12.Play();
        }

		if (i == 5)
		{
			hoverButtons.SetActive(true);
		}
		if (i == 6)
        {
			steam.Play();
			CloudRise.direction = 1;
		}
		if (i == 11)
		{
			wheel.SetActive(true);
		}
	}
}
