using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
using TMPro;

public class choice : MonoBehaviour
{
    public SteamVR_Action_Boolean leftTrig;
    public SteamVR_Action_Boolean rightTrig;
    public TextMeshProUGUI question;
    public TextMeshProUGUI choice1;
    public TextMeshProUGUI choice2;
    public PlayerController playerController;
    private int i = -1;
    // Start is called before the first frame update

    private string[] questionArr = {
        "Now as creator what do you want to use in your World? ",
        "What do you want your earth to be composed of?",
        "What do you want your earth to be composed of?",
        "What do you want your earth to be composed of?",
        "What do you want your animals and intelligent beings to be like?",
    };

    private string[] choice1Arr = {
        "Make your base liquid, H2SO4, sulfuric acid. Maybe evolution will make everything on this planet indestructible.",
        "Make the earth’s crust thicker, getting rid of the tectonic plates. Your planet has less earthquakes and no more volcanoes.",
        "Get rid of the Moon.",
        "Birds have dense bones instead of hollow bones and fish only eat land creatures",
        "Give Humans gills.",
    };

    private string[] choice2Arr = {
        "Keep it as is H20, If it's not broken don’t fix it",
        "Make the inner core smaller.",
        "Make the sun bigger but further away",
        "Fish have wings and birds have gills",
        "Have a higher ratio of people to land animals ",
    };

    // Update is called once per frame
    void Update()
    {

        if (leftTrig.stateDown)
        {
            Left();
        } else if (rightTrig.stateDown)
        {
            Right();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Next();
        }

    }

    public void Left()
    {
        print("Left");
    }

    public void Right()
    {
        print("Right");
    }

    public void Next()
    {
        if(i < 4)
        {
            i++;
        }
        playerController.chapter = i + 2;
        if (playerController.chapter == 3)
        {
            playerController.answer = true;
        }
        Invoke("Text", 4.9f);
    }

    public void Text()
    {
        question.SetText(questionArr[i]);
        choice1.SetText(choice1Arr[i]);
        choice2.SetText(choice2Arr[i]);
    }

}
