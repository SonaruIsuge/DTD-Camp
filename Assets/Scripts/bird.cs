using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bird : MonoBehaviour
{
    /* 變數宣告在這裡 */
    public float FlySpeed;  //(小數)變數 : 鳥向上飛的速度
    public int score;   //(整數)變數 : 分數
    public Rigidbody2D rigidBody2d; //(2D物理控制器)變數 : 物理控制器
    public Text scoreTxt;   //(文字元件)變數 : 分數文字
    public Text GameOverTxt;    //(文字元件)變數 : 遊戲結束文字
    bool gameOver = false;  //(布林)變數 : 是否遊戲結束


    // 遊戲開始時執行一次
    void Start()
    {
        GameOverTxt.enabled = false;    //遊戲開始時把遊戲結束文字隱藏
    }

    // 遊戲進行中每偵執行
    void Update()
    {
        if (gameOver)                                           //  當遊戲結束時 : 
        {                                                       //  {
            GameOverTxt.enabled = true;                         //      讓GameOver文字顯現
            Time.timeScale = 0;                                 //      遊戲時間暫停

            if (Input.GetMouseButtonDown(0))                    //      當按下滑鼠左鍵時 : 
            {                                                   //      {
                SceneManager.LoadScene("mainScene");            //          載入名為"mainScene"的場景 (會讓程式從新開始運行，變數歸零)
                Time.timeScale = 1;                             //          遊戲時間恢復正常
            }                                                   //      }
        }                                                       //  }
        else                                                    //  當遊戲還沒結束(也就是進行中)
        {                                                       //  {
            if (Input.GetMouseButtonDown(0))                    //      當按下滑鼠左鍵
            {                                                   //      {
                rigidBody2d.velocity = Vector3.up * FlySpeed;   //          讓物理控制器裡面的「速度」 = (向上一個單位) x (鳥飛的速度)
            }                                                   //      }
        }                                                       //  }      
    }

    void OnTriggerEnter2D(Collider2D collider)      //  當與「collider」碰撞時 : 
    {                                               //  {
        if(collider.name == "point")                //      如果「collider」的名稱是"point"(管子中間的得分區)
        {                                           //      {
            score++;                                //          分數加1
            scoreTxt.text = score.ToString();       //          文字元件內的文字 = (轉換成字串的)分數
        }                                           //      }
        else                                        //      如果「collider」的名稱不是"point"(也就是碰到了障礙物)
        {                                           //      {
            gameOver = true;                        //          遊戲結束
        }                                           //      }
    }                                               //  }
}
