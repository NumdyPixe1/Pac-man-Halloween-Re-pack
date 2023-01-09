using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip GetDotSound1, GetDotSound2, GetDotSound3, GameOverSound, BackgroundSound;
    static AudioSource audiosrc;
    void Start()
    {
        GetDotSound1 = Resources.Load<AudioClip>("GetDot_1");
        GetDotSound2 = Resources.Load<AudioClip>("GetDot_2");//ตัวแปรชื่อ GetDotSound ไปโหลดไฟล์ที่ชื่อ GetDot ในโฟลเดอร์ชื่อ Resources
        //GetDotSound3 = Resources.Load<AudioClip>("GetDot_3");
        GameOverSound = Resources.Load<AudioClip>("GameOver");

        audiosrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string cilp)
    {
        switch (cilp)
        {
            case "GetDot_1":
                audiosrc.PlayOneShot(GetDotSound1);
                break;
            case "GetDot_2":
                audiosrc.PlayOneShot(GetDotSound2);
                break;
            case "GameOver":
                audiosrc.PlayOneShot(GameOverSound);
                break;
        }
    }
}




