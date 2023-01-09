using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Clyde : MonoBehaviour
{
    Transform targetObject;
    NavMeshAgent navAgent;
    void Start()
    {
        StartCoroutine(Wait());

    }
    IEnumerator Wait()
    {

        yield return new WaitForSeconds(30);
        navAgent = GetComponent<NavMeshAgent>();
        if (targetObject == null)
        {
            targetObject = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    void Update()
    {
        navAgent.SetDestination(targetObject.position);
    }
}
