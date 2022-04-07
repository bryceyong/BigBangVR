using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NarratorChap3 : MonoBehaviour
{
	// Start is called before the first frame update
	private string[] narrationArr2 = {
		"Earth is composed of multiple layers.",
		"The first layer, the crust, the thinnest of all layers. The crust is where all of civilization is built.",
		"The mantle is the second outermost layer full of molten magma.",
		"
		"The outer layer is composed of iron and nickel in liquid form and the inner core is composed of condensed iron about  ¾ of the moon with an extremely hot surface.",
	};

	public TextMeshProUGUI narration;
	public TextMeshProUGUI progress;
	public Button yourButton;
	public int speed;

	public GameObject hoverButtons;
	public GameObject wheel;
	private int i = 0;
	private int j = 0;
	void Start()
	{
	}

	// Update is called once per frame
	public void skip()
	{
		narration.SetText(narrationArr2[i]);
		if (i < 7)
		{
			i++;
		}
		if (i == 4)
		{
			hoverButtons.SetActive(true);
		}
		if (i == 5)
		{
			CloudRise.direction = 1;
		}
		if (i == 7)
		{
			wheel.SetActive(true);
		}
	}
}
