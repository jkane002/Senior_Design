using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public Text winText;

    public int score;

    void Start()
    {

        SetScoreText();
        winText.text = "";

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");
        if (other.gameObject.CompareTag("Cube"))
        {
            Debug.Log("hit");
            score = score - 1;
            SetScoreText();
        }

        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            score = score + 1;
            SetScoreText();
        }

    }


    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString() + "/20";
        if (score >= 20)
        {
            winText.text = "You collected all of the hearts!";
        }
    }
}
