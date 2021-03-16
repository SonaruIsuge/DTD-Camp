using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bird : MonoBehaviour
{
    public float FlySpeed;
    public int score = 0;

    public Rigidbody2D rb;
    public Text scoreTxt;
    public Text GameOverTxt;

    bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        GameOverTxt.enabled = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            GameOverTxt.enabled = true;
            score = 0;
            Time.timeScale = 0;
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("mainScene");
                Time.timeScale = 1;
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector3.up * FlySpeed;
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.name != "point")
        {
            gameOver = true;
        }
        else
        {
            score++;
            scoreTxt.text = score.ToString();
        }
    }
}
