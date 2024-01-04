using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class MonkMove : MonoBehaviour
{
  
    private Transform target;
    public NavMeshAgent navAgent;

    public void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        navAgent = GetComponent<NavMeshAgent>();
    }

    public void Update()
    {
        navAgent.SetDestination(target.position);
    }
}
