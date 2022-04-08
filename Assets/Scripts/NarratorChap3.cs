using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NarratorChap3 : MonoBehaviour
{
	// Start is called before the first frame update
	private string[] narrationArr2 = {
		"Welcome back to the surface creator",
		"Now that we have a solid base, plants would be able to grow",
		"Sit back watch the magic happen ",
	};

	public TextMeshProUGUI narration;
	public GameObject grass;
	public GameObject shrooms;

	private int i = 0;



	// Update is called once per frame
	public void skip()
	{
		narration.SetText(narrationArr2[i]);
		if (i < 2)
		{
			i++;
		}
		if(i == 2)
        {
			grass.SetActive(true);
			shrooms.SetActive(true);
			TreeGrow.direction = 1;
			TreeGrowM.direction = 1;
			TreeGrowL.direction = 1;
			TreeGrowSp.direction = 1;
        }


	}
}
