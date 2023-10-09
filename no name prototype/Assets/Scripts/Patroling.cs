using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patroling : MonoBehaviour
{
    [SerializeField] private NavMeshAgent walkingAgent;
    [SerializeField] private Transform position1;
    [SerializeField] private Transform position2;



    private Vector3 currentTarget;
    void Start()
    {
        walkingAgent.SetDestination(position1.position);
        //currentTarget = position1.position;
    }

    //bool idle = false;

    void Update()
    {
        if (walkingAgent.remainingDistance < 0.35f)
        {
            if (currentTarget == position1.position)
            {
                currentTarget = position2.position;
            }
            else
            {
                currentTarget = position1.position;
            }
            walkingAgent.SetDestination(currentTarget);

        }
    }
}
