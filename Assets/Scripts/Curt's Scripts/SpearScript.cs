using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearScript : MonoBehaviour {
    Rigidbody rb;
    float speed = 20;
    bool stopped = false;
    bool hasFired = false;
    [SerializeField] float throwTimer;
    private float timerReset;
    float DedTimer, dedReset;
    
    // Use this for initialization
    void Start() {
        DedTimer = dedReset = 4;
        rb = GetComponent<Rigidbody>();
        //Thrown();
        timerReset = throwTimer;
    }
    private void Update()
    {
        despawn();
    }
    private void FixedUpdate()
    {
        //    Thrown();
        if (throwTimer > 0)
        {
            throwTimer -= Time.deltaTime;
        }
    }

    //void Thrown()
    //{
    //    if(!stopped)
    //    {
    //        //rb.AddForce(transform.forward * speed, ForceMode.Impulse);
    //    }
        
    //}
    

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("animal") || col.gameObject.CompareTag("ground"))
        {
            hasFired = true;
            stopped = true;
            rb.velocity = Vector3.zero;
        }
    }

    private void PoolMe()
    {
        hasFired = false;
        stopped = false;
        throwTimer = timerReset;
        DedTimer = dedReset;
        PoolManager.Instance.PoolObject(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && throwTimer <= 0)
        {
            Debug.Log("Player Trigger Pooled " + gameObject.name);
            PoolMe();
        }
    }
    void despawn()
    {
        DedTimer -= Time.deltaTime;
        if(DedTimer <= 0)
        {
            Debug.Log("Despawn Pooled " + gameObject.name);
            PoolMe();
        }
    }
}