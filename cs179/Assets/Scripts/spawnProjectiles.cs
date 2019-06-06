using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnProjectiles : MonoBehaviour
{
    GameObject spawn;
    GameObject spawnPoint;
    private float timer = 0.0f;
    private float waitTime = 0.2f;
    public static bool startSpawn = false;
    GameObject cube;

    private void Start()
    {
        spawn = GameObject.Find("Cube");

    }

    void Update()
    {
        if (startSpawn == true)
        {
            Debug.Log("HERE");
            timer += Time.deltaTime;
            if (timer > waitTime)
            {
                GameObject cube = Instantiate(spawn, transform.position, transform.rotation);
                cube.AddComponent<projectileMovement>();

                timer = 0;
            }
        }
    }
}