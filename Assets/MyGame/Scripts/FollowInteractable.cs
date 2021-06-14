using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowInteractable : MonoBehaviour
{
    public NavMeshAgent pickup;
    public Transform Player;

    // Start is called before the first frame update
    void Start()
    {
        pickup = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        pickup.SetDestination(Player.position);
    }


    
}
