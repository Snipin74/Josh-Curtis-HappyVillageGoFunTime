using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    public float Hspeed;
    public float Vspeed;
    public float Zspeed;
    public float aplitiude;


    private Vector3 movePosition;
    public float minY = 0.0f, maxY = 10.0f;
    public float minZ = 0.0f, maxZ = 20.0f;

    // Use this for initialization
    void Start()
    {
        //set default to moveposition
        movePosition = transform.position;
    }

    private void FixedUpdate()
    {
        //controls/ set to moveposition
        movePosition.x += Hspeed;
        movePosition.z = Mathf.Sin(Time.realtimeSinceStartup + Zspeed) * aplitiude + maxZ - minZ;
        movePosition.y = Mathf.Sin(Time.realtimeSinceStartup + Vspeed) * aplitiude + maxY - minY;
        transform.position = movePosition;
    }

}