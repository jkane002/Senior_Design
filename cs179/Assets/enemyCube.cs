﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCube : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "enemyCube") {
            player.transform.position = new Vector3(0,0,0);
        }
    }
}
