using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearScript : MonoBehaviour {
    Rigidbody rb;
    float speed = 10;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        Thrown();
    }
	
	
    void Thrown()
    {
        rb.AddForce(transform.forward * speed);
    }
}
