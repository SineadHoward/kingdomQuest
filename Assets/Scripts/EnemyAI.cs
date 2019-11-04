using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour

{ 
    private Transform goal;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        goal = Camera.main.transform;
        agent = GetComponent<NavMeshAgent>();
        //set the navmesh agent's desination equal to the main camera's position (our first person character)
        agent.destination = goal.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
       // GetComponent<CapsuleCollider>().enabled = false;
        //stop the zombie from moving forward by setting its destination to it's current position
        agent.destination = gameObject.transform.position;
    }

    }
