using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class SpearThrowingScript : MonoBehaviour {
    public GameObject obj, SpawnLoc;
    int maxSpearsOnScreen = 1;
    Vector3 spawn;
    Quaternion rot;
    Ray Target;
    Vector3 speartarget;
    // Use this for initialization
    void Start () {
        rot = SpawnLoc.transform.rotation;
        spawn = SpawnLoc.transform.position;
    }
	
	
    private void FixedUpdate()
    {
        rot = SpawnLoc.transform.rotation;
        spawn = SpawnLoc.transform.position;
    }
    void Update()
    {
        
        SpawnSpear();
    }
   
    
    void SpawnSpear()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject spear = Instantiate(obj, spawn , rot);
        }
    }
 
}
