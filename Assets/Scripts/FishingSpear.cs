using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingSpear : MonoBehaviour {

    
    // Use this for initialization
    void Start () {
       
	}

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
            transform.Rotate(105, 0, 0);
            
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            transform.Rotate(-105, 0, 0);
        }
    }

}
