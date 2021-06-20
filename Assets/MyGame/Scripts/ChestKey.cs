using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestKey : MonoBehaviour
{

    public GameObject key;
    public GameObject redEffect;
    public GameObject openedEffect;

    public void OnTriggerEnter(Collider other)
    {
        key.SetActive(true);
        redEffect.SetActive(false);
        openedEffect.SetActive(true);
    }
}
