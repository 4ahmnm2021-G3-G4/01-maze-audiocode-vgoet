using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public AudioSource collected;

    public AudioSource Audio1;

    public Collider col1;
    public Collider col2;
    public Collider col3;

    void OnTriggerEnter(Collider collider)
    {
        
        if(GetComponent<Collider>().gameObject.tag == "Wisp")
        {
            PickupCounter.coinAmount += 1;
            collected.Play();
          
            Audio1.Stop();

            col1.GetComponent<Collider>().enabled = false;



        }

        if (GetComponent<Collider>().gameObject.tag == "Wisp1")
        {
            PickupCounter.coinAmount += 1;
            collected.Play();

            Audio1.Stop();

            col2.GetComponent<Collider>().enabled = false;


        }

        if (GetComponent<Collider>().gameObject.tag == "Wisp2")
        {
            PickupCounter.coinAmount += 1;
            collected.Play();

            Audio1.Stop();

            col3.GetComponent<Collider>().enabled = false;


        }



    }

    
}
