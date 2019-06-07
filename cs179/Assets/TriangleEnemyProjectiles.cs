using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TriangleEnemyProjectiles : MonoBehaviour
{
    GameObject spawn;
    GameObject spawnPoint;
    private float waitTime = 600f;
    private float timer;
    public static bool startSpawn = false;
    GameObject cube;

    public float range = 10f;
    public Transform target;

    private void Start()
    {
        //spawn = GameObject.Find("Bullet");
        //timer = waitTime;
    }

    void Update()   
    {
        //float distance = Vector3.Distance(target.position, transform.position);

        //timer += Time.deltaTime;
        //if (distance <= range && timer >= waitTime)
        //{
        //    Debug.Log("In range");
        //    Shoot();
        //    timer = 0;
        //}
    }

    //void Shoot()
    //{
    //    GameObject b = Instantiate(spawn, transform.position, transform.rotation);
    //    b.AddComponent<projectileMovement>();
    //    Destroy(b.gameObject, 0.75f);
    //}
}
