using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NarratorChap2 : MonoBehaviour
{
	// Start is called before the first frame update

	private string[] narrationArr2 = {
		"Chapter 2 - Sky",
		"Now that we can see, let's create a planet!",
		"Before we make the rock let's collect the needed gasses and elements to create a bubble for our planet.",
		"Let's cover what is needed to allow for an inhabitable planet?", 
		"Earth’s atmosphere is composed of about 78 percent nitrogen, 21 percent oxygen, 0.9 percent argon, and 0.1 percent other gasses. Use the buttons on your left to adjust the air composition. Hit the done button when you are done.",
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
	private int j = 0;
	public int done = 0;
    void Start()
    {
    }

    // Update is called once per frame
	public void skip(){
		
		if(i < 5){
			narration.SetText(narrationArr2[i]);
			i++;
		} 
		if(i == 5)
        {
			hoverButtons.SetActive(true);
		}
		if(i < 9 && done == 1)
        {
			narration.SetText(narrationArr2[i]);
			i++;
        }
		if(i == 9){
			wheel.SetActive(true);
		}
	}
	public void enableWater(){
		WaterFlow.direction = -1;
	}

	public void Done()
    {
		if(done == 0)
        {
			done = 1;
			narration.SetText(narrationArr2[i]);
			i++;
			CloudRise.direction = 1;
		}
	}
}
