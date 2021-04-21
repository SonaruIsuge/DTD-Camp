using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeController : MonoBehaviour
{
    public float PipeMoveSpeed = -2.0f;
    public float originX = 7.0f;
    public float endX = -9.0f;

    public float MaxHeight = 2.5f;
    public float MinHeight = -4.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(this.transform.position.x , Random.Range(MaxHeight, MinHeight), 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(PipeMoveSpeed * Time.deltaTime, 0, 0);
        if (this.transform.position.x <= endX)
        {
            this.transform.position = new Vector3(originX, Random.Range(MaxHeight, MinHeight), 0);
        }
    }
}
