﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchScene : MonoBehaviour
{
    public Text winText;
    private string sceneName;
    public PlayerController_a pa;
    // Start is called before the first frame update
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
    }

    private void OnTriggerEnter(Collider other)
    {
        //SceneManager.LoadScene(sceneName: "MarvinScene");

        switch(sceneName) {
            case "jonathan_0606":
            {
                SceneManager.LoadScene(sceneName: "Triangle_World_Start");
                break;
            }
            case "Triangle_World_Start":
            {
                if(pa.hasKey == true)
                    {
                        SceneManager.LoadScene(sceneName: "sabrina");
                    }

                break;
            }
            case "sabrina":
            {
                if(string.Compare(winText.text, "You collected all of the hearts!") == 0)
                {
                    SceneManager.LoadScene(sceneName: "MarvinScene");
                  }
                  break;
            }
            case "MarvinScene":
            {
                SceneManager.LoadScene(sceneName: "Level-2");
                break;
            }
            case "Marvin Boss":
            {
                SceneManager.LoadScene(sceneName: "End");
                break;
            }
            //case "Level":
            //{
            //    break;
            //}
            case "Level-2":
            {
                SceneManager.LoadScene(sceneName: "Level-3");
                break;
            }
            case "Level-3":
            {
                SceneManager.LoadScene(sceneName: "Level-4");
                break;
            }
            case "Level-4":
            {
                SceneManager.LoadScene(sceneName: "Marvin Boss");
                break;
            }
            //case "Level-5":
            //{
            //    Application.Quit();
            //    break;
            //}
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            SceneManager.LoadScene(sceneName: "jonathan_0606");
        }
        if (Input.GetKeyDown("2"))
        {
            SceneManager.LoadScene(sceneName: "Triangle_World_Start");
        }
        if (Input.GetKeyDown("3"))
        {
            SceneManager.LoadScene(sceneName: "sabrina");
        }
        if (Input.GetKeyDown("4"))
        {
            SceneManager.LoadScene(sceneName: "MarvinScene");
        }
        if (Input.GetKeyDown("5"))
        {
            SceneManager.LoadScene(sceneName: "Level-2");
        }
        if(Input.GetKeyDown("6"))
        {
            SceneManager.LoadScene("Level-3");
        }
        if (Input.GetKeyDown("7"))
        {
            SceneManager.LoadScene("Level-4");
        }
        if (Input.GetKeyDown("8"))
        {
            SceneManager.LoadScene("Marvin Boss");
        }
    }
}
