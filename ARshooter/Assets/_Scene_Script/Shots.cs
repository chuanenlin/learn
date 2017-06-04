using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shots : MonoBehaviour {

    public Transform shotSpawn;
    public GameObject bullet;
    public float factor;

    public AudioClip shootSound;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;
	// Use this for initialization
	void Awake() {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)) {
            float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(shootSound,vol);
            GameObject shot = Instantiate(bullet, shotSpawn.position, shotSpawn.rotation) as GameObject;
            shot.GetComponent<Rigidbody>().AddForce(shotSpawn.forward * factor, ForceMode.Impulse);
        }


	}
}
