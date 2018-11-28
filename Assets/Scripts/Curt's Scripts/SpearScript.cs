using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearScript : MonoBehaviour {
    Rigidbody rb;
    float speed = 15;
    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
        Thrown();
    }
    private void FixedUpdate()
    {
        Thrown();
    }

    void Thrown()
    {
        rb.AddForce(transform.up * speed, ForceMode.Impulse);
    }

    private void OnCollisionStay(Collision col)
    {
        rb.velocity = Vector3.zero;
    }
}