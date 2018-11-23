using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]


public class SpearThrowingScript : MonoBehaviour {
    public GameObject obj;
    Rigidbody rb;
    Vector3 spawnPos;
    Quaternion rot;
    // Use this for initialization
    void Start () {
        rot = gameObject.transform.rotation;
        spawnPos = gameObject.transform.position;
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        rot = gameObject.transform.rotation;
        spawnPos = gameObject.transform.position;
    }
    void ThrowSpear()
    {
        if(Input.GetMouseButtonDown(2))
        {
            Instantiate(obj, spawnPos, rot);
        }
    }
}
