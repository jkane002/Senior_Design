using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossRotate : MonoBehaviour
{
    static public int rotationSpeed = 100;
    private float timer = 0.0f;
    private float waitTime = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer < waitTime)
        {
            transform.Rotate(rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime, 0);
        }
        else
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }
}
