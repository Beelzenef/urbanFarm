using System.Collections;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class FarmerController : MonoBehaviour {

    public LayerMask movement;

    Camera cam;
    PlayerMotor motor;

    bool enablePlant;
    bool enablePickFruits;

    GameObject plot;
    GameObject tree;

	void Start () {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();

        enablePlant = false;
        enablePickFruits = false;
	}
	
	void FixedUpdate () {
		
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
            Inventory.UseSeed();
            if (plot.GetComponent<PlotManager>().IsPlanted())
            {
                // Pick up stuff!
            }
            else
            {
                plot.AddComponent<Seed>();
                plot.GetComponent<PlotManager>().SetSeed();
            }
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            if (tree.GetComponent<TreeManager>().IsTreeReady())
            {
                tree.GetComponent<TreeManager>().PickFruits();
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
            enablePlant = true;
        }

        if (c.gameObject.name == "Door")
        {
            // Fadeout
            c.GetComponent<TimeManager>().OneDayMore();
        }

        if (c.gameObject.name == "Tree")
        {
            tree = c.gameObject;
            enablePickFruits = true;
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.gameObject.name == "Plot")
        {
            enablePlant = false;
        }
        if (c.gameObject.name == "Tree")
        {
            enablePickFruits = false;
        }
    }
}
