using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;//GameObject ที่กล้องจะติดตาม
    public Vector3 offset;//มุนกล้อง
    void Start()
    {

    }

    void Update()
    {

        transform.position = Target.position + offset;
        // transform.LookAt(Target);
    }
}
