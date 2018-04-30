using System.Collections;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class FarmerController : MonoBehaviour {

    public LayerMask movement;

    Camera cam;
    PlayerMotor motor;

    bool enablePlant;

    GameObject plot;

	void Start () {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();

        enablePlant = false;
	}
	
	void Update () {
		
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayo = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(rayo, out hit, 100, movement))
            {
                motor.MoveToPoint(hit.point);
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            // Send message to plot to get the seed going!
            Inventory.UseSeed();
            if (!plot.GetComponent<PlotManager>().IsPlanted())
            {
                plot.AddComponent<Seed>();
                plot.GetComponent<PlotManager>().SetSeed();
            }
        }

    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "GameController")
        {
            Inventory.PickSeeds(3);
        }

        if (c.gameObject.name == "Plot")
        {
            plot = c.gameObject;
        }

        if (c.gameObject.name == "Door")
        {
            // Fadeout
            c.GetComponent<TimeManager>().OneDayMore();
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.gameObject.name == "Plot")
        {
            enablePlant = false;
        }
    }
}
