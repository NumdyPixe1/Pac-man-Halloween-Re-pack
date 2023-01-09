using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject gameTitleScene, gameOverScene, youWinScene, quitScene, Ready;
    public static bool IsPaused;
    public int countDownTime = 3;

    void Start()
    {
        StartCoroutine(CountdownToStart());
    }
    IEnumerator CountdownToStart()
    {
        Ready.SetActive(true);
        yield return new WaitForSeconds(0.5f);//หรือ yield return new WaitForSeconds(3f)
        countDownTime--;
        yield return new WaitForSeconds(0.5f);
        countDownTime--;
        yield return new WaitForSeconds(1f);
        countDownTime--;
        Time.timeScale = 0;


        GameObject.Find("Player").GetComponent<Player>().enabled = true;//หา GameObject ที่ชื่อ Payer แล้วทำการเปิด Script ชื่อ Player
        //GameObject.FindWithTag("Ghost").GetComponent<Ghost>().enabled = true;//หา GameObject ที่ Tag ชื่อ Ghost แล้วทำการเปิด Script ชื่อ Ghost
        Ready.SetActive(false);
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))//กด ESC
        {
            IsPaused = !IsPaused;//IsPaused เปลี่ยนจาก flase เป็น true
            pause();//เรียกฟังก์ชัน pause
        }
    }

    //Button
    public void PlayGame()
    {
        SoundManager.PlaySound("GetDot_2");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
    }

    void pause()//ฟังก์ชันหยุดเกม
    {
        quitScene.SetActive(false);//จะยังไม่เรียกใช้งาน Pause(Panel) 
        if (IsPaused)
        {
            Time.timeScale = 0f;
            quitScene.SetActive(true);//เรียกใช้งาน Pause(Panel) 
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void GameOver()
    {
        gameOverScene.SetActive(true);
        Time.timeScale = 0f;
    }

    public void YouWin()
    {
        youWinScene.SetActive(true);
        Time.timeScale = 0f;
    }
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayAgain()
    {
        Debug.Log("PlayAgain");
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        SoundManager.PlaySound("GetDot_2");
        Application.Quit();
        Debug.Log("Quit");
    }

    public void ReturntoGame()
    {
        SoundManager.PlaySound("GetDot_2");
        quitScene.SetActive(false);
        Time.timeScale = 1f;
    }

















}

