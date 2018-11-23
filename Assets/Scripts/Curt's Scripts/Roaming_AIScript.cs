using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]

public class Roaming_AIScript : MonoBehaviour {
    Vector3 currentPos, randomPos;
    public GameObject obj;
    Rigidbody rb;
    public float speed = 20;
    bool isActive = false;
    float graze = 5;

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
        //Vector3 position = new Vector3(Random.Range(0, 500), 0.5f, Random.Range(0, 500));
        Vector3 position = new Vector3(currentPos.x + Random.Range(-10, 10), 0.5f, currentPos.z + Random.Range(-10, 10));

        return position;
    }
    void Roam()
    {
        if (currentPos != randomPos)
        {
            isActive = true;
            rb.AddForce(((randomPos - transform.position).normalized * speed));

        }
        else isActive = false; Grazing(); 
       
         
       
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
    void Grazing()
    {
        if (isActive == false)
        {
            do
            {
                graze--;
            } while (graze > 0);
            if(graze == 0)
            {
                randomPos = GetNewLocal();
                
            }

            graze = 5;
        }
    }
}
