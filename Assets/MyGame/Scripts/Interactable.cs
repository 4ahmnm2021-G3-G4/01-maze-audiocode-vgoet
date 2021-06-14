using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{



    void OnTriggerEnter(Collider other)
    {
        if(GetComponent<Collider>().gameObject.tag == "Altar")
        {
            Destroy(gameObject);
        }


    }
}
