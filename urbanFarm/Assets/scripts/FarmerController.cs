using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class FarmerController : MonoBehaviour {

    public LayerMask movement;

    Camera cam;
    PlayerMotor motor;

	void Start () {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
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

	}

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "GameController")
        {
            Inventory.PickSeeds(3);
            Debug.Log("Has recogido semillas");
        }
    }
}
