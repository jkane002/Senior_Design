using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    //change so it becomes the active scene 
        //    SceneManager.LoadScene("jonathan_new");
        //}

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //SceneManager.LoadScene("jonathan_new");
            Debug.Log("jonathan");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //SceneManager.LoadScene("jonathan_new");

            Debug.Log("andrew");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //SceneManager.LoadScene("jonathan_new");

            Debug.Log("sabrina");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            //SceneManager.LoadScene("jonathan_new");

            Debug.Log("marvin");
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            //SceneManager.LoadScene("jonathan_new");

            Debug.Log("CJ");
        }
    }

}