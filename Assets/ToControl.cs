using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToControl : MonoBehaviour {

    public GameObject toControl;
    InputManager inputMan;

    private void Start()
    {
        inputMan = GetComponent<InputManager>();
        inputMan.objectToControl = toControl;
    }


}
