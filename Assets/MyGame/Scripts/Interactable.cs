using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{

    
    void OnTriggerEnter(Collider collider)
    {
        
        if(GetComponent<Collider>().gameObject.tag == "Wisp")
        {
            PickupCounter.coinAmount += 1;
         

            
        }


   
    }

    
}
