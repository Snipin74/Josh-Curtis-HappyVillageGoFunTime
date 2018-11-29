using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearScript : MonoBehaviour {
    Rigidbody rb;
    float speed = 25;
    bool stopped = false;
    bool hasFired = false;
    [SerializeField] float throwTimer;
    private float timerReset;
    float DedTimer = 7;
    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
        Thrown();
        timerReset = throwTimer;
    }
    private void Update()
    {
        despawn();
    }
    private void FixedUpdate()
    {
        Thrown();
        if (throwTimer > 0)
        {
            throwTimer -= Time.deltaTime;
        }
    }

    void Thrown()
    {
        if(!stopped)
        {
            rb.AddForce(transform.forward * speed, ForceMode.Impulse);
        }
        
    }
    

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player") && throwTimer <= 0)
        {
            PoolManager.Instance.PoolObject(gameObject);
        }
        else if (col.gameObject.CompareTag("animal") || col.gameObject.CompareTag("ground"))
        {
            hasFired = true;
            stopped = true;
            rb.velocity = Vector3.zero;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && throwTimer <= 0)
        {
            PoolManager.Instance.PoolObject(gameObject);
            
        }
    }
    void despawn()
    {
        DedTimer -= Time.deltaTime;
        if(DedTimer <= 0)
        {
            PoolManager.Instance.PoolObject(gameObject);
        }
    }
}