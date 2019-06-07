using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossSpawnProjectiles : MonoBehaviour
{
    GameObject spawn;
    GameObject spawnPoint;
    private float timer = 0.0f;
    private float waitTime = 0.05f;
    GameObject cube;

    private void Start()
    {
        spawn = GameObject.Find("Cube");

    }

    void Update()
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
