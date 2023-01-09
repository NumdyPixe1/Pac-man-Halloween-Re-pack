using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")//ถ้าชนกับ gameObject tag ชื่อว่า Player
        {

            Destroy(this.gameObject);//ทำลาย gameObject นี้ทิ้ง
        }
    }

}















