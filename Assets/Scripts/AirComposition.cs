using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AirComposition : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI percentage;
    public double nitrogen = 0;
    public double oxygen = 0;
    public double argon = 0;
    public double other = 0;

    public void plusNitrogen(){
        nitrogen += 15.6;
    }

    public void plusOxygen(){
        oxygen += 7.0;
    }

    public void plusArgon(){
        argon += 0.3;
    }

    public void plusOther(){
        other += 0.05;
    }

    public void Update(){
        percentage.SetText( nitrogen.ToString() + " % Nitrogen\n\n" + oxygen.ToString() + " % Oxygen\n\n" + argon.ToString() + "% Argon\n\n" + other.ToString() +  "% Other Gasses");
    }

    public void reset(){
        nitrogen = 0;
        oxygen = 0;
        argon = 0;
        other = 0;
    }







}
