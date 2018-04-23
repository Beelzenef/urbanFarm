using UnityEngine;

public class Inventory : MonoBehaviour {

    private static int seedT1;
    private static int seedT2;

	void Start () {
        seedT1 = 5;
	}
	
    public static void PickSeeds(int seeds)
    {
        seedT1 -= seeds;
    }

    public static void LeaveSeeds(int seeds)
    {
        seedT1 += seeds;
    }

    public static void UseSeed()
    {
        seedT1 -= 1;
    }

}
