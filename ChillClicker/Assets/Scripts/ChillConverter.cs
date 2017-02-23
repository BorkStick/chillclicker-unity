using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChillConverter : MonoBehaviour {

    private static ChillConverter instance;

    public static ChillConverter Instance
    {
        get
        {
            return instance;
        }
    }
	
    void Awake()
    {
        CreateInstance();
    }	

    void CreateInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public string GetChillIntoString(float valueToConvert, bool chillPerSec, bool chillPerClick) {
        string converted;
        if (valueToConvert >= 1000000)
        {
            converted = (valueToConvert / 1000000f).ToString("f3") + "Mil";
        }
        else if (valueToConvert >= 1000)
        {
            converted = (valueToConvert / 1000f).ToString("f3") + "K";
        }
        else {
            converted = "" + valueToConvert;
        }

        if (chillPerSec == true)
        {
            converted = converted + "";
        }

        if (chillPerClick == true) {
            converted = converted + "";
        }
        return converted;

    }
}

