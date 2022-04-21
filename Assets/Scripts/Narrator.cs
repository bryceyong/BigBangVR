using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Narrator : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject flash1;
	public GameObject flash2;
	public GameObject flash3;
	public GameObject flash4;
	public AudioSource p1;
	public AudioSource p2;
	public AudioSource p3;
	public AudioSource p4;
	public AudioSource buttonClick;
	private bool buttonPressed = false;
	private float timeRemaining = 2;



	private string[] narrationArr = {
		"Welcome new creator!",
		"I am here to assist the creation of your world by giving you the basic information of a life sustaining one, Earth.",
		"We can’t create in the dark so why don’t you turn the lights on, I wouldn't want you straining your eyes.", 
		"Use the flashbangs on your left to light up the room.",
	};


	public TextMeshProUGUI narration;
	public TextMeshProUGUI progress;
	public Button yourButton;
	private int i = 0;


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

    public void Delay()
    {
		buttonPressed = true;
		narration.SetText(narrationArr[i]);
		if (i < 4)
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
			flash1.SetActive(true);
			flash2.SetActive(true);
			flash3.SetActive(true);
			flash4.SetActive(true);
		}
	}
}
