using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Chap4 : MonoBehaviour
{
	// Start is called before the first frame update
	private string[] narrationArr2 = {
		"While you were asleep, I generated the sun and the moon",
		"The sun shoots solar flares and due to the distance and earth’s natural magnetic field it is properly shielded.",
		"A planet can have moons and orbit a star at a certain distance.",
		"The sun is just the right distance for heating earth. The moon is tied to the tide rise, the orbit of the moon pulls the ocean on earth towards the moon creating tides, and gravity of the moon creates waves for our ocean.",
		"For reference, the sun is located 92.96 million miles from the earth and the moon is located about 238,900 miles. ",
		"However, due to my limited computation power, I would need you to resize the sun. Use the lever on the left to toggle between night and day.",
		"Use the black ray gun and shoot at your target to enlarge them. Remember this process is irreversible.",
	};

	public TextMeshProUGUI narration;
	public TextMeshProUGUI progress;
	public GameObject lever;
	public GameObject raygun;
	public PlayerController playerController;
	public bool buttonPressed;
	public float timeRemaining = 2;
	public AudioSource buttonClick;
	public AudioSource p1;
	public AudioSource p2;
	public AudioSource p3;
	public AudioSource p4;
	public AudioSource p5;
	public AudioSource p6;
	public AudioSource p7;

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
		if (!buttonPressed && i < 7)
		{
			buttonClick.Play();
			Delay();
			buttonPressed = true;
			timeRemaining = 2;
			i++;
		}
		if(!buttonPressed && i == 7)
        {
			transition();
        }



	}

	public void Delay()
    {
		if (i < 7)
		{
			progress.SetText((i + 1).ToString() + " / 7");
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
        if (i == 5)
        {
            lever.SetActive(true);
        }
		if (i == 6)
		{
			raygun.SetActive(true);
		}
	}
    public void transition()
	{
		playerController.firstTime = true;
		playerController.chapter = 5;
	}
}
