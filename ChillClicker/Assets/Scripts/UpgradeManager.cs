using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {

    public Click click;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int count = 0;
    public int clickPower;
    public string itemName;
    public Color standard;
    public Color affordable;

    private float baseCost;
    private Slider _slider;

    void Start()
    {
        baseCost = cost;
        _slider = GetComponentInChildren<Slider>();
    }

    private void Update()
    {
        itemInfo.text = itemName + " (" + count + ")" + "\nCost: " + cost + "\nPower: +" + clickPower;

        /*if (click.chill >= cost)
        {
            GetComponent<Image>().color = affordable;
        } else {
            GetComponent<Image>().color = standard;
        }*/
        _slider.value = click.chill / cost * 100;
        if (_slider.value >= cost)
        {
            GetComponent<Image>().color = affordable;
        }
        else
        {
            GetComponent<Image>().color = standard;
        }
    }

    public void PurchasedUpgrade()
    {
        if (click.chill >= cost)
        {
            click.chill -= cost;
            count += 1;
            click.chillperclick += clickPower;
            cost = Mathf.Round (baseCost * Mathf.Pow(1.15f, count))
                ;
        }
    }

}
