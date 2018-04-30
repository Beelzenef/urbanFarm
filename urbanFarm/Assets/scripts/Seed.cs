using UnityEngine;

public class Seed : MonoBehaviour {

    string seedName;
    public int daysToGrow;
    public int daysGrowing;
    string fruit;

	void Start () {
        seedName = "normal seed";
        daysGrowing = 0;
        daysToGrow = 3;
        fruit = "normal fruit";
	}

    public void growSeed()
    {
        daysGrowing++;
    }

    public bool isSeedGrown()
    {
        return daysToGrow == daysGrowing;
    }
}
