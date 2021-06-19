using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupCounter : MonoBehaviour
{

    Text coinText;

    public GameObject TriggerChest;

    public static int coinAmount;



    private void Start()
    {
        coinText = GetComponent<Text>();
    }

    private void Update()
    {
        coinText.text = coinAmount.ToString();

        if (coinAmount == 3)
        {
            TriggerChest.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
