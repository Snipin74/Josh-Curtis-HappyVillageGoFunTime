using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishCollect : MonoBehaviour {


    public GameObject deadFish;
    
    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.CompareTag("water"))
        {
            Debug.Log("Fish");
            deadFish.SetActive(true);

        }
    }

}
