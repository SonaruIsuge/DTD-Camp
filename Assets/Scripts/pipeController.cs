using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeController : MonoBehaviour
{
    public float PipeMoveSpeed = 2.0f; //(小數)變數 : 管子移動的速度
    public float originX = 7.0f;    //(小數)變數 : 管子生成的X位置
    public float endX = -9.0f;  //(小數)變數 : 管子移動的終點X位置

    public float MaxHeight = 2.5f;  //隨機管子高度的上限
    public float MinHeight = -4.0f; //隨機管子高度的下限

    // 遊戲開始時執行一次
    void Start()
    {
        // 管子的初始高度 = 三維座標向量 (自身X高度 , 從 MaxHeight 與 MinHeight 中取隨機值 , 0)
        this.transform.position = new Vector3(this.transform.position.x , Random.Range(MaxHeight, MinHeight), 0);
    }

    // 遊戲進行中每偵執行
    void Update()
    {
        this.transform.Translate(-PipeMoveSpeed * Time.deltaTime, 0, 0);                            //  管子每秒往左移 PipeMoveSpeed 單位
        if (this.transform.position.x <= endX)                                                      //  如果管子的X座標比移動的終點還左邊 : 
        {                                                                                           //  {
            this.transform.position = new Vector3(originX, Random.Range(MaxHeight, MinHeight), 0);  //      把這根管子的座標移回 (初始X , 隨機Y , 0)
        }                                                                                           //  }
    }
}
