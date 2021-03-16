using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeController : MonoBehaviour
{
    public float PipeMoveSpeed = -2.0f;
    public float originX = 7;

    public float MaxHeight = 2.5f;
    public float MinHeight = -4.0f;

    // Start is called before the first frame update
    void Start()
    {
        //this.transform.position = new Vector3(0, Random.Range(-1.0f, -6.5f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(PipeMoveSpeed * Time.deltaTime, 0, 0);
        if (this.transform.position.x <= -9)
        {
            this.transform.position = new Vector3(originX, Random.Range(MaxHeight, MinHeight), 0);
        }
    }
}
