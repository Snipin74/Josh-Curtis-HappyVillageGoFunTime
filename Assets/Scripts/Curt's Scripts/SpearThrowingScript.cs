using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class SpearThrowingScript : MonoBehaviour {
    public GameObject obj;
    int maxSpearsOnScreen = 1;
    Vector3 spawn;
    Quaternion rot;
    // Use this for initialization
    void Start () {
        rot = transform.rotation;
        spawn = transform.position;
    }
	
	
    private void FixedUpdate()
    {
        rot = obj.transform.rotation;
        spawn = transform.position;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
           GameObject spear = Instantiate(obj, spawn, rot);
            spear.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        }
    }
    
}
//set spear spawn to the game object on player, change spear mechanics.