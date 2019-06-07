﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ballMove : MonoBehaviour
{

    public float speed;
    public Text scoreText;
    public Text winText;

    private Rigidbody rb;
    private int score;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetScoreText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        movement = GameObject.Find("Main Camera").transform.TransformDirection(movement);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
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
