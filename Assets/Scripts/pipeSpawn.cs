using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    public int maxPipe = 5;

    int i = 0;
    GameObject prePipe;

    // Start is called before the first frame update
    void Start()
    {
        prePipe = Instantiate(pipe, this.transform);
        i++;
    }

    // Update is called once per frame
    void Update()
    {
        if(prePipe.transform.position.x - this.transform.position.x <= -4 && i <= maxPipe)
        {
            prePipe = Instantiate(pipe, this.transform);
            i++;
        }
    }


}
