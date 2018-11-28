using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishCollect : MonoBehaviour {


    public GameObject deadFish;

    public float DelayTime;
    private float MaxTime = 3f;



    private void Start()
    {
     
    }
    private void OnTriggerStay(Collider other)
    {
        
            if (other.gameObject.CompareTag("water"))
            {
                Debug.Log("Fish");
                deadFish.SetActive(true);
            }
            if (other.gameObject.CompareTag("Barrel"))
        {
            deadFish.SetActive(false);
        }
    
    }

}
