using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

    public UnityEngine.UI.Text cpc;
    public UnityEngine.UI.Text chillDisplay;
    public float chill = 0.00f;
    public int chillperclick = 1;


    void Update()
    {
        chillDisplay.text = "Chill: " + ChillConverter.Instance.GetChillIntoString(chill, false, false);
        cpc.text = ChillConverter.Instance.GetChillIntoString(chillperclick, false, true) + " chill/click";
    }

    public void Clicked()
    {
        chill += chillperclick;
    }




	
}
