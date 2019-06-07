using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileMovementSlower : MonoBehaviour
{
    // Adjust the speed for the application.
    public float speed = 10.0f;
    private float timeAlive = 0.0f;
    private float timeAlive2 = 0.0f;

    Transform target;

    private void Start()
    {
        // The target (Player) position.
        target = GameObject.Find("Player").transform;
    }

    void Update()
    {
        if(timeAlive2 >= 0.05f)
        {
            // Move our position a step closer to the target.
            float step = speed * Time.deltaTime; // calculate distance to move
            timeAlive += Time.deltaTime;
            if (timeAlive >= 5.0f) { Destroy(gameObject); }
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            timeAlive2 = 0;
        }
        timeAlive2 += Time.deltaTime;
    }
}
