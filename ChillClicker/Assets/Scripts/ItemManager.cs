using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{

    public UnityEngine.UI.Text itemInfo;
    public Click click;
    public float cost;
    public int tickValue;
    public int count;
    public string itemName;
    public Color standard;
    public Color affordable;

    private float baseCost;

    private void Start()
    {
        baseCost = cost;
    }

    private void Update()
    {
        itemInfo.text = itemName + " (" + count + ")" + "\nCost: " + cost + "\nChill: " + tickValue + "/s";

        if (click.chill >= cost)
        {
            GetComponent<Image>().color = affordable;
        }
        else
        {
            GetComponent<Image>().color = standard;
        }
    }

    public void PurchasedItem()
    {
        if (click.chill >= cost)
        {
            click.chill -= cost;
            count += 1;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.15f, count));
        }
    }

}
