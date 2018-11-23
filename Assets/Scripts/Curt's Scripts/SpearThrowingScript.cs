using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class SpearThrowingScript : MonoBehaviour {
    public GameObject obj;
   
    Vector3 spawnPos;
    Quaternion rot;
    // Use this for initialization
    void Start () {
        rot = obj.transform.rotation;
        spawnPos = gameObject.transform.position;
       
    }
	
	
    private void FixedUpdate()
    {
        rot = obj.transform.rotation;
        spawnPos = gameObject.transform.position;
    }
    void ThrowSpear()
    {
        if(Input.GetKey(KeyCode.F))
        {
            Instantiate(obj, spawnPos, rot);
        }
    }
}
