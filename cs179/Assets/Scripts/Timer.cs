using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float startTime;
    private bool finished = false;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (finished)
            return;

        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds;

        if (minutes == "0")
        {   
            seconds = (t % 60).ToString("f1");
            timerText.text = seconds + "s";
        }
        else
        {
            seconds = (t % 60).ToString("f0");

            if(t % 60 <= 9)
            {
                seconds = '0' + seconds;
            }
            timerText.text = minutes + "." + seconds;
        }
    }

    public void Finished()
    {
        finished = true;
        timerText.color = Color.yellow;
    }

    public void GameOver()
    {
        finished = true;
        timerText.color = Color.red;
    }
}
