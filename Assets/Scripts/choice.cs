using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
using TMPro;

public class choice : MonoBehaviour
{
    private Interactable interactable;
    public PlayerController playerController;
    public TextMeshProUGUI question;
    public TextMeshProUGUI choice1;
    public TextMeshProUGUI choice2;
    public GameObject chapter1;
    public GameObject chapter2;
    public GameObject chapter3;
    public GameObject chapter4;
    public GameObject chapter5;
    public GameObject chapter6;
    public GameObject chapter7A;
    public GameObject chapter7B;
    public GameObject player;
    public GameObject dark;
    public GameObject water;
    public GameObject sphere;
    public GameObject bird;
    public GameObject dancers;
    public GameObject anchor;
    public GameObject choiceRoom;
    public AudioSource c6;
    public bool once;
    public int score = 0;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(playerController.chapter == 2)
        {
            question.SetText("Should Earth remain in the dark?");
            choice1.SetText("Yes, it should");
            choice2.SetText("No, it should not");
            dark.SetActive(true);
        }
        if (playerController.chapter == 3)
        {
            question.SetText("Which one of these 2 gasses were higher in percentage?");
            choice1.SetText("Oxygen");
            choice2.SetText("Argon");
            dark.SetActive(false);
            water.SetActive(true);
        }
        if (playerController.chapter == 4)
        {
            question.SetText("What is the name of the first layer of the Earth?");
            choice1.SetText("Crust");
            choice2.SetText("Mantle");
            water.SetActive(false);
            sphere.SetActive(true);
        }
        if (playerController.chapter == 5)
        {
            question.SetText("How far is the sun from the Earth");
            choice1.SetText("92.6 million miles");
            choice2.SetText("238.9 million miles");
            anchor.SetActive(true);
        }
        if (playerController.chapter == 6)
        {
            question.SetText("Which one of these creatures have hollow bones?");
            choice1.SetText("Bird");
            choice2.SetText("Fish");
            bird.SetActive(true);
        }
        if (playerController.chapter == 7)
        {
            question.SetText("People have made themselves the ______ dominating the world?");
            choice1.SetText("prime swimmers");
            choice2.SetText("prime hunters");
            dancers.SetActive(true);
            
        }

    }

    public void toggleGame()
    {
        if (once)
        {
            chapter1.SetActive(false);
            chapter2.SetActive(false);
            chapter3.SetActive(false);
            chapter4.SetActive(false);
            chapter5.SetActive(false);
            chapter6.SetActive(false);
            once = false;
        }
    }

    public void Left()
    {
        once = true;
        if(playerController.chapter == 0)
        {
            chapter1.SetActive(true);
            player.transform.transform.position = new Vector3(0f, 1f, -1f);
        }
        if (playerController.chapter == 2)
        {
            
            chapter2.SetActive(true);
            player.transform.transform.position = new Vector3(29.6f, -0.5f, 0.5f);
            score++;
        }
        if (playerController.chapter == 3)
        {
            
            chapter3.SetActive(true);
            player.transform.transform.position =  new Vector3(63.0f, 0.0f, -7f);
            score++;
        }
        if (playerController.chapter == 4)
        {
            
            chapter4.SetActive(true);
            player.transform.transform.position = new Vector3(-2.34f, 1.5f, -37.74f);

        }
        if (playerController.chapter == 5)
        {
            
            chapter5.SetActive(true);
            player.transform.transform.position = new Vector3(27.78f, 1.5f, -37.91f);
            score++;
        }
        if (playerController.chapter == 6)
        {
            
            chapter6.SetActive(true);
            player.transform.transform.position = new Vector3(0.5f, 1.5f, -72f);
   
        }
        if (playerController.chapter == 7)
        {
            
            if (score > 3)
            {
                chapter7B.SetActive(true);
            }
            else
            {
                chapter7A.SetActive(true);
            }
            player.transform.transform.position = new Vector3(39.45f, -7.1f, -51.54f);
            c6.Stop();
        }

    }

    public void Right()
    {
        once = true;
        if (playerController.chapter == 0)
        {
            chapter1.SetActive(true);
            player.transform.transform.position = new Vector3(0f, 1f, -1f);
            score++;
        }
        if (playerController.chapter == 2)
        {
            chapter1.SetActive(false);
            chapter2.SetActive(true);
            player.transform.transform.position = new Vector3(29.6f, -0.5f, 0.5f);
          
        }
        if (playerController.chapter == 3)
        {
            chapter2.SetActive(false);
            chapter3.SetActive(true);
            player.transform.transform.position = new Vector3(63.0f, 0.0f, -7f);
          
        }
        if (playerController.chapter == 4)
        {
            chapter3.SetActive(false);
            chapter4.SetActive(true);
            player.transform.transform.position = new Vector3(-2.34f, 1.5f, -37.74f);
            score++;
        }
        if (playerController.chapter == 5)
        {
            chapter4.SetActive(false);
            chapter5.SetActive(true);
            player.transform.transform.position = new Vector3(27.78f, 1.5f, -37.91f);
          
        }
        if (playerController.chapter == 6)
        {
            chapter5.SetActive(false);
            chapter6.SetActive(true);
            player.transform.transform.position = new Vector3(0.5f, 1.5f, -72f);
            score++;
        }
        if (playerController.chapter == 7)
        {
            chapter6.SetActive(false);
            if (score > 3)
            {
                chapter7B.SetActive(true);
            }
            else
            {
                chapter7A.SetActive(true);
            }
            player.transform.transform.position = new Vector3(39.45f, -7.1f, -51.54f);
            choiceRoom.SetActive(false);
            c6.Stop();
        }
    }

}
