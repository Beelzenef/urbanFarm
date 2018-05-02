using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManager : MonoBehaviour {

    public int daysToGrow;
    public int daysGrowing;

    void Start () {
        daysGrowing = 0;
        daysToGrow = 3;
    }

    public void GrowFruits()
    {
        daysGrowing++;
    }

    public bool IsTreeReady()
    {
        return daysToGrow == daysGrowing;
    }

    public void PickFruits()
    {
        if (IsTreeReady())
        {
            // Give fruits
            daysGrowing = 0;
        }
    }
}
