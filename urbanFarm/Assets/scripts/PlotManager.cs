using UnityEngine;

public class PlotManager : MonoBehaviour {

    Seed seed;

	void Start () {
        seed = null;
	}

    public void setSeed()
    {
        seed = new Seed();
    }

    public void growDaSeed()
    {
        seed.growSeed();
        if (seed.isSeedGrown())
            Debug.Log("Seed is ready! Pick me up!");
    }
}
