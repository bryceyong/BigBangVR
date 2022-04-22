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


	private string[] narrationArr = {
		"Chapter 1 - Light",
		"Welcome new creator!",
		"I am here to assist the creation of your world by giving you the basic information of a life sustaining world, Earth.",
		"We can’t create in the dark so why don’t you turn the lights on, don’t want to strain your eyes.", 
		"One flashbang should do it but whatever you're feeling.",
	};


	public TextMeshProUGUI narration;
	public TextMeshProUGUI progress;
	public Button yourButton;
	private int i = 0;
	private int j = 0;


    // Update is called once per frame
	public void skip(){
		narration.SetText(narrationArr[i]);
		if(i < 4){
			i++;
		} 
		if(i == 4)
        {
			flash1.SetActive(true);
			flash2.SetActive(true);
			flash3.SetActive(true);
			flash4.SetActive(true);
		}
	}
}
