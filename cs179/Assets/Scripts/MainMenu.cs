using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(sceneName: "jonathan_0606");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
