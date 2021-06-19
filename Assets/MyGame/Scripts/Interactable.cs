using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public AudioSource collected;

    void OnTriggerEnter(Collider collider)
    {
        
        if(GetComponent<Collider>().gameObject.tag == "Wisp")
        {
            PickupCounter.coinAmount += 1;
            collected.Play();
         

            
        }


   
    }

    
}
