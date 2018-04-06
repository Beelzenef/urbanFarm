using UnityEngine;

public class Inventory : MonoBehaviour {

    private static int seedT1;
    private static int seedT2;

	void Start () {
        seedT1 = 1;
        seedT2 = 2;
	}
	
    public static void PickSeeds(int seeds)
    {
        seedT2 -= seeds;
    }

    public static void LeaveSeeds(int seeds)
    {
        seedT1 += seeds;
    }

}
