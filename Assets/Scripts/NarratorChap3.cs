using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NarratorChap3 : MonoBehaviour
{
	// Start is called before the first frame update
	private string[] narrationArr2 = {
		"Welcome back to the surface creator.",
		"Now that we have a solid foundation, plants will be able to grow.",
		"Sit back and watch the magic happen.",
	};

	public TextMeshProUGUI narration;
	public TextMeshProUGUI progress;
	public GameObject grass;
	public GameObject shrooms;
	public GameObject rain;
	public PlayerController playerController;
	public bool buttonPressed;
	public AudioSource buttonClick;
	public float timeRemaining = 2;
	public AudioSource p9;
	public AudioSource p10;
	public AudioSource p11;

	private int i = 0;

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
	}

		// Update is called once per frame
		public void skip()
	{
		if (!buttonPressed && i < 3)
		{
			buttonClick.Play();
			Delay();
			buttonPressed = true;
			timeRemaining = 2;
		}
	}

	public void Delay()
    {
		progress.SetText((i + 1).ToString() + " / 3");
		narration.SetText(narrationArr2[i]);
		if (i < 3)
		{
			i++;	
		}
		if(i == 1)
        {
			p9.Play();
        }
		if (i == 2)
		{
			p9.Stop();
			p10.Play();
		}
		if (i == 3)
		{
			p10.Stop();
			p11.Play();
		}

		if (i == 3)
		{
			rain.SetActive(true);
			grass.SetActive(true);
			shrooms.SetActive(true);
			TreeGrow.direction = 1;
			TreeGrowM.direction = 1;
			TreeGrowL.direction = 1;
			TreeGrowSp.direction = 1;
			Invoke("transition", 10f);
		}
	}
	public void transition()
    {
		playerController.firstTime = true;
		
		playerController.chapter = 4;
    }


}
