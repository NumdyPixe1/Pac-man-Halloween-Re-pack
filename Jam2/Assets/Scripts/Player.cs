using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 25f;
    private Rigidbody rb;
    private Transform playerRotation;
    public GameManager gameManager;

    void Start()
    {

        rb = GetComponent<Rigidbody>();//เรียกส่วนเสริม Rigidbody
        playerRotation = GetComponent<Transform>();//เรียกส่วนเสริม Transform

    }
    private void LateUpdate
    ()
    {
        ContinuousMovement();//ฟังก์ชันยังเคลื่อนไหวอยู่มั้ย
    }
    void Update()
    {
        Direction();//ฟังก์ชันบังคับทิศทาง


    }

    public void ContinuousMovement()//ฟังก์ชันยังเคลื่อนไหวอยู่มั้ย
    {
        rb.MovePosition(transform.position + transform.forward * moveSpeed * Time.deltaTime);
    }

    public void Direction()//ฟังก์ชันบังคับทิศทาง
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))//กดปุ่มหนึ่งครั้ง
        {
            playerRotation.rotation = Quaternion.Euler(0f, 180f, 0f);//ทำการหมุน แกน y 
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerRotation.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerRotation.rotation = Quaternion.Euler(0f, -90f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerRotation.rotation = Quaternion.Euler(0f, 90f, 0f);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ghost")
        {
            SoundManager.PlaySound("GameOver");
            gameManager.GameOver();

        }
    }


























}
