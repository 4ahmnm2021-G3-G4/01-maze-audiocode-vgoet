using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayChestAudio : MonoBehaviour
{

    public AudioClip Chest;
    public AudioSource ChestAudio;



    public void ChestSound()
    {
        ChestAudio.PlayOneShot(Chest);
    }
}
