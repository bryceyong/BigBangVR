using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NarratorChap4 : MonoBehaviour
{
	// Start is called before the first frame update
	private string[] narrationArr2 = {
		"Chapter 4 - light in the sky",
		"While you were asleep, I generated the sun and the moon",
		"The sun is located 92.96 million mi from the earth and the moon is located about 238,900 mi. ",
		"The sun shoots solar flares and due to the distance and earth’s natural magnetic field it is properly shielded.",
		"The sun is just the right distance for heating earth. The moon is tied to the tide rise, the orbit of the moon pulls the ocean on earth towards the moon creating tides, and gravity of the moon creates waves to the ocean.",
		"However, due to my limited computation power, I would need you to resize the sun.",
		"Use the lever on the left to toggle between night and day.",
		"Use the black ray gun and shoot at your target to enlarge them. Remember this process is irreversible.",
		"Hit next when you are done",

	};

	public TextMeshProUGUI narration;
	public GameObject grass;
	public GameObject shrooms;
	public GameObject rain;
	public PlayerController playerController;

	private int i = 0;



	// Update is called once per frame
	public void skip()
	{

		if (i < 8)
		{
			playerController.chapter = 5;
			playerController.firstTime = true;
			i++;
			narration.SetText(narrationArr2[i]);
		}

	}
	public void transition()
	{
		playerController.firstTime = true;
		rain.SetActive(false);
		playerController.chapter = 4;
	}
}
