using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour {

    private int days;
    private List<PlotManager> plotList;
    private List<TreeManager> treeList;

    void Start()
    {
        plotList = new List<PlotManager>();
        treeList = new List<TreeManager>();
        GameObject[] plots = GameObject.FindGameObjectsWithTag("Plot");
        GameObject[] trees = GameObject.FindGameObjectsWithTag("Tree");

        foreach (GameObject item in plots)
        {
            plotList.Add(item.GetComponent<PlotManager>());
        }

        foreach (GameObject item in trees)
        {
            treeList.Add(item.GetComponent<TreeManager>());
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

        foreach (TreeManager item in treeList)
        {
            item.GrowFruits();
        }
    }
}
