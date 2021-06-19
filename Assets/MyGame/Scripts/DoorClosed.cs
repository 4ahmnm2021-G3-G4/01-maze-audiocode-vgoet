
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClosed : MonoBehaviour
{
   
    public GameObject Door;
    public bool doorIsOpening;
    public float speed; 
    public Vector3 startpos;

void Start()
{
    startpos = gameObject.transform.position; 
}


public void DoorOpen(){
    StartCoroutine(OpenDoor(true));
}



IEnumerator OpenDoor(bool open)

    {
        if (open == true){

        
        while (Door.transform.position.y > 7f){
            Door.transform.Translate(Vector3.up * Time.deltaTime * 5f);
            yield return new WaitForSeconds(0.1f);
            }
        }
        else{
            while (Door.transform.position.y < 3){
            Door.transform.Translate(-Vector3.up * Time.deltaTime * 5f);
            yield return new WaitForSeconds(0.1f);
            }
         yield return new WaitForSeconds(1);
    }
    }

void OnTriggerEnter(Collider collider){
            StartCoroutine(OpenDoor(true));  
    }
    
}

