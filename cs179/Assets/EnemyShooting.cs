using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public EnemyController ec;

    // Start is called before the first frame update
    void Start()
    {
        ec = GetComponent<EnemyController>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (ec.inRange) {//player in range)

            Shoot();
        }
        
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            Debug.Log("here");
            Debug.Log(hit.transform.name);
        }
    }
}
