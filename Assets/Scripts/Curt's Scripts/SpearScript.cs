using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearScript : MonoBehaviour {
    Rigidbody rb;
    float speed = 15;
    bool stopped = false;
    bool hasFired = false;
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
        if(stopped == false)
        {
            
            rb.AddForce(transform.up * speed, ForceMode.Impulse);
        }
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player") && hasFired == true)
        {
            gameObject.SetActive(false);

        }else if (col.gameObject.CompareTag("animal") || col.gameObject.CompareTag("ground"))
        {
            hasFired = true;
            stopped = true;
            rb.velocity = Vector3.zero;
        }
        
    }
    
}