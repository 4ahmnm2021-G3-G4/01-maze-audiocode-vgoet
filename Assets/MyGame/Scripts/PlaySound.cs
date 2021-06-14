using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlaySound : MonoBehaviour
{
    
    public AudioSource audioSource;

    //Play default sound
   
    public void PlaySoundButton()
    {
 
     audioSource.Play();
    }
    
}
