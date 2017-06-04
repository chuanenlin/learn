using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "boundary") {
            Destroy(gameObject);
        }
    }
}
