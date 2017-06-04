using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Rotate : MonoBehaviour {

    private GameObject hamburger;
    private GameObject hat;
    private GameObject rifle;
    private GameObject bust;

    // Use this for initialization
    void Start () {
        hamburger = GameObject.Find("Hambuger");
        hat = GameObject.Find("CowboyHat_Skinned");
        rifle = GameObject.Find("rifle");
        bust = GameObject.Find("JuliusCaesarBust");
    }
	
	// Update is called once per frame
	void Update () {
       hamburger.transform.Rotate(new Vector3(0, Time.deltaTime * 30, 0));
       hat.transform.Rotate(new Vector3(0, Time.deltaTime * 30, 0));
       rifle.transform.Rotate(new Vector3(0, Time.deltaTime * 30, 0));
       bust.transform.Rotate(new Vector3(0, Time.deltaTime * 30, 0));
    }
}
