using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageSound : MonoBehaviour {

    public AudioClip dmgSound;
    private AudioSource source;

    private float volLowRange = .5f;
    private float volHighRange = 1.0f;
    // Use this for initialization

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        if (collision.relativeVelocity.magnitude > 2)
            source.Play();
    }
    //

    // Update is called once per frame
    void Update () {
		
	}
}
