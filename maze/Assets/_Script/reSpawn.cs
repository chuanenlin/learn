using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reSpawn : MonoBehaviour {

    public Transform spawnPoint;
    public Transform currentPlane;

    public int lowerBound;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (rb.transform.position.y < currentPlane.position.y-lowerBound) {
            rb.position = spawnPoint.position;
        }
	}
}
