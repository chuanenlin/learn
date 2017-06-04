using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour {

    public Transform FromPortal1;
    public Transform FromPortal2;
    public Transform FromPortal3;
    public Transform FromPortal4;
    public Transform FromPortal5;
    public Transform FromPortal6;

  // public Transform ToPortal1;
  //  public Transform ToPortal2;
  //  public Transform ToPortal3;
  //  public Transform ToPortal4;
  //  public Transform ToPortal5;
  //  public Transform ToPortal6;

    private Transform savePoint;
    private int currentState;

	// Use this for initialization
	void Start () {
        savePoint = FromPortal1;
        currentState = 1;
	}

    private void FixedUpdate()
    {
        if (transform.position.x < -35 || transform.position.x > 35 ||
            transform.position.y < -35 || transform.position.y > 35 ||
            transform.position.z < -35 || transform.position.z > 35) {
            transform.position = savePoint.position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.other.tag == "portal") {

            switch (currentState) {
                case 1:
                    transform.position = FromPortal2.transform.position;
                    currentState = 2;
                    savePoint = FromPortal2;
                    break;
                case 2:
                    transform.position = FromPortal3.transform.position;
                    currentState = 3;
                    savePoint = FromPortal3;
                    break;
                case 3:
                    transform.position = FromPortal4.transform.position;
                    currentState = 4;
                    savePoint = FromPortal4;
                    break;
                case 4:
                    transform.position = FromPortal5.transform.position;
                    currentState = 5;
                    savePoint = FromPortal5;
                    break;
                case 5:
                    transform.position = FromPortal6.transform.position;
                    currentState = 6;
                    savePoint = FromPortal6;
                    break;
                case 6:
                    transform.position = FromPortal1.transform.position;
                    currentState = 1;
                    savePoint = FromPortal1;
                    break;
            }
        }
    }
}
