using UnityEngine;

public class Seed : MonoBehaviour {

    string seedName;
    int daysToGrow;
    int daysGrowing;
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
