using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingSpear : MonoBehaviour {

    

    public GameObject Spear;
    public Vector3 currentPos;
    public Vector3 endPos;
    public Vector3 goBack;

    public float distance = 30f;

    private float LerpTime = 5;
    private float currLerpTime = 0;

    private bool keyHit = false;

    // Use this for initialization
    void Start () {
        currentPos = Spear.transform.position;
        endPos = Spear.transform.position + Vector3.forward * distance;
        goBack = Spear.transform.position + Vector3.forward / distance;

	}

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.Rotate(110, 0, 0);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            transform.Rotate(-110, 0, 0);
        }

        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //    keyHit = true;
        //}

        //if (keyHit == true)
        //{
        //    currLerpTime += Time.deltaTime;
        //    if(currLerpTime >= LerpTime)
        //    {
        //        currLerpTime = LerpTime;
        //    }
        //    float Perc = currLerpTime/LerpTime;
        //    Spear.transform.position = Vector3.Lerp(currentPos, endPos, Perc);
        //}

        //if (Input.GetKeyUp(KeyCode.F))
        //{
        //    keyHit = false;
        //} 
 
    }

}
