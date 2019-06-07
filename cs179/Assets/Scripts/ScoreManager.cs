using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public Text winText;
    public PlayerManager pm;

    private int s;

    void Start()
    {


        s = 0;
        winText.text = "";
        SetScoreText();
        //if(s > 20)
        //{
        //    SetScoreText();
        //}

    }
    void Update()
    {
        Debug.Log("s: " + s);
    }

    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            pm.score = pm.score + 1;
            //pm.Health = pm.Health + 5;
            s = s + 1;
            SetScoreText();
        }

    }


    void SetScoreText()
    {
        //scoreText.text = "Score: " + score.ToString() + "/20";
        if (s >= 20)
        {
            winText.text = "You collected all of the hearts!";
        }
    }
}
