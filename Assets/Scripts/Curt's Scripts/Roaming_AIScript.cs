using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]

public class Roaming_AIScript : MonoBehaviour {
    Vector3 currentPos, randomPos;
    public GameObject obj;
    Rigidbody rb;
    public float speed = 20;
    

    // Use this for initialization
    void Start () {
        currentPos = gameObject.transform.position;
        randomPos = GetNewLocal();
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        raycast();
    }
    private void FixedUpdate()
    {
        
        currentPos = gameObject.transform.position;
        GetNewLocal();
        Roam();
    }
    Vector3 GetNewLocal()
    {
        Vector3 position = new Vector3(Random.Range(0, 500), 0.5f, Random.Range(0, 500));

        return position;
    }
    void Roam()
    {
        
        rb.AddForce(((randomPos - transform.position).normalized * speed));
        if (true)
        {

        }
       
    }
    void raycast()
    {
        RaycastHit hit;
        Physics.SphereCast(currentPos, 5f, transform.forward, out hit);
        Debug.DrawRay(currentPos, transform.forward * 5, Color.blue);
        Debug.DrawRay(currentPos, transform.forward * -5, Color.blue);
        Debug.DrawRay(currentPos, transform.right * 5, Color.blue);
        Debug.DrawRay(currentPos, transform.right * -5, Color.blue);
    }
}
