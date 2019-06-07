using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeAlive : MonoBehaviour
{
    private float timer = 0.0f;
    private float waitTime = 7.0f;

    private void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            Destroy(gameObject);
        }
    }
}
