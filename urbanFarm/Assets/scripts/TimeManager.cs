using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour {

    private int days;
    private List<PlotManager> plotList;

    void Start()
    {
        plotList = new List<PlotManager>();
        GameObject[] plots = GameObject.FindGameObjectsWithTag("Plot");

        foreach (GameObject item in plots)
        {
            plotList.Add(item.GetComponent<PlotManager>());
        }

    }

    public void OneDayMore()
    {
        Debug.Log("One day more, another day another destiny...");
        foreach (PlotManager item in plotList)
        {
            if (item.IsPlanted())
            {
                item.GrowDaSeed();
            }
        }
    }
}
