﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DoorExit : MonoBehaviour
{
   
    public GameObject Door;
    public bool doorIsOpening;
    public float speed; 
    public Vector3 startpos;

    public AudioClip doorOpen;
    public AudioClip doorClose;
    public AudioClip key;
    public AudioSource TheDoor;

    public bool alreadyPlayed = false;


    void Start()
{
    startpos = gameObject.transform.position; 
}


public void DoorOpen(){
    StartCoroutine(OpenDoor(false));

        TheDoor.PlayOneShot(doorOpen);
        TheDoor.PlayOneShot(key);
    }


 

IEnumerator OpenDoor(bool open)

    {
        if (open == true){

        
        while (Door.transform.position.y < 7f){
            Door.transform.Translate(Vector3.up * Time.deltaTime * 5f);
            yield return new WaitForSeconds(0.1f);


            }
        }
        else{
            while (Door.transform.position.y > -2){
            Door.transform.Translate(-Vector3.up * Time.deltaTime * 5f);
            yield return new WaitForSeconds(0.1f);
            }
         yield return new WaitForSeconds(1);
    }
    }

void OnTriggerEnter(Collider collider){

        
        StartCoroutine(OpenDoor(true));

        if (!alreadyPlayed)
        {
            TheDoor.PlayOneShot(doorOpen);
            TheDoor.PlayOneShot(key);
            
            alreadyPlayed = true;

        }

    }

    
}
