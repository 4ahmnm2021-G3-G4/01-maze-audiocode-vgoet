using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestKey : MonoBehaviour
{

    public GameObject key;

    public void OnTriggerEnter(Collider other)
    {
        key.SetActive(true);
    }
}
