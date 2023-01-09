using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Blinky : MonoBehaviour
{
    Transform targetObject;
    NavMeshAgent navAgent;

    void Start()
    {
        StartCoroutine(Wait());

    }

    IEnumerator Wait()
    {

        yield return new WaitForSeconds(3);
        navAgent = GetComponent<NavMeshAgent>();
        if (targetObject == null)
        {
            targetObject = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    void Update()
    {
        //navAgent.destination = targetObject.position;
        navAgent.SetDestination(targetObject.position);
    }
}
