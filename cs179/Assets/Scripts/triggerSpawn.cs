using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        spawnProjectiles.startSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
