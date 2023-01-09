using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public int Numscore;//ตรวจสอบว่าเก็บ Dot ไปกี่จุดแล้ว
    public int score;//รับคะแนนเป็นตัวเลข 
    public TextMeshProUGUI textScore;//ตัว text
    public bool getScore;//ตรวจสอบว่าได้รับคะแนนมั้ย
    public GameManager gameManager;
    void Start()
    {
    }

    void Update()
    {
        if (Numscore >= 183)
        {
            gameManager.YouWin();
        }
        getScore = false;
        textScore.text = score.ToString();//เปลี่ยน int score ให้เป็น string เอาไปเชื่อมกับ textScore
    }

    void OnTriggerEnter(Collider other)
    {
        if (getScore) return;//เป็น true แล้วกลับเป็น false เหมือนเดิม
        {
            if (other.tag == "Dot")//ชนกับ tag ชื่อ Dot
            {
                getScore = true;//เป็น true
                if (getScore)//เมื่อเป็น true จะเพิ่มคะแนน
                {
                    score += 10; //เพิ่มคะแนน
                    SoundManager.PlaySound("GetDot_1");
                    Numscore++;
                }

            }
            if (other.tag == "Dot_2")
            {
                getScore = true;//เป็น true
                if (getScore)//เมื่อเป็น true จะเพิ่มคะแนน
                {

                    score += 50; //เพิ่มคะแนน
                    SoundManager.PlaySound("GetDot_2");
                    Numscore++;
                }
            }
        }

    }


}