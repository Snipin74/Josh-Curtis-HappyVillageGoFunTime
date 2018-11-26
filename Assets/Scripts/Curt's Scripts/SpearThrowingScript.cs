using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class SpearThrowingScript : MonoBehaviour {
    public GameObject obj, SpawnLoc;
    int maxSpearsOnScreen = 1;
    Vector3 spawn;
    Quaternion rot;
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
        SpearSpawnLoc();
    }
    public void SpearSpawnLoc()
    {
        Debug.DrawRay(transform.position, transform.forward, Color.blue);
        Ray Target = Camera.main.ScreenPointToRay(Input.mousePosition);
        //spear.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);
    }
    //ignore this void
    void SpawnSpear()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject spear = Instantiate(obj, spawn, rot);
        }
    }
 
}
//change camera setting on hunter and possibly all playable characters off of mouse buttons
//make it so the spearScript gets the location of input.mouseposition and and then throws the spear tht way when the throw button is pressed