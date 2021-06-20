using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    [SerializeField] public Animator myAnimationController;
 

    public void Start()
    {
        myAnimationController = GetComponent<Animator>();
       

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("play", true);
        }

        else
        {
            myAnimationController.SetBool("play", false);
        }



    }


}
