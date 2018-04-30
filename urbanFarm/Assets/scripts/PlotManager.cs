using UnityEngine;

public class PlotManager : MonoBehaviour {

    private Seed seed;
    private bool planted;

	void Start () {
        seed = null;
        planted = false;
	}

    public bool IsPlanted()
    {
        return planted;
    }

    public void SetSeed()
    {
        seed = GetComponent<Seed>();
        GetComponent<Renderer>().material.color = Color.red;
        planted = true;
    }

    public void GrowDaSeed()
    {
        seed.growSeed();
        if (seed.isSeedGrown())
        {
            Debug.Log("Seed is ready! Pick me up!");
            planted = false;
            GetComponent<Renderer>().material.color = Color.green;
            Destroy(GetComponent<Seed>());
        }
    }

}
