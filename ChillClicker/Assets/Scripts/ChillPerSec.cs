using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChillPerSec : MonoBehaviour {

    public UnityEngine.UI.Text cpsDisplay;
    public Click click;
    public ItemManager[] items;


    public void Start()
    {
        StartCoroutine(AutoTick());
    }

    private void Update()
    {
        cpsDisplay.text = GetChillPerSec() + " chill/sec";
    }

    public float GetChillPerSec()
    {
        float tick = 0;
        foreach(ItemManager item in items)
        {
            tick += item.count * item.tickValue;
        }
        return tick;
    }

    public void AutoChillPerSec()
    {
        click.chill += GetChillPerSec() / 10;
    }

    IEnumerator AutoTick()
    {
        while(true)
        {
            AutoChillPerSec();
            yield return new WaitForSeconds(0.10f);
        }
    }

}
