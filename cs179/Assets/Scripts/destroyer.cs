﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour {

    public float lifeTime = 10f;
    public ScoreManager score;

    private void Start()
    {
        //score = GetComponent<ScoreManager>();
    }
    // Update is called once per frame
    void Update () {
        if(lifeTime > 0) {
            lifeTime -= Time.deltaTime;
            if(lifeTime <= 0) {
                Destruction();
            }
        }

        if(this.transform.position.y <= -20) {
            Destruction();
        }
    }
    

    void OnCollisionEnter(Collision coll) {

        if(coll.gameObject.CompareTag("Cube"))
        {
            score.score = score.score - 1;
        }

        if (coll.gameObject.name == "destroyer") {
            Destruction();
        }
    }

    void Destruction() {
        Destroy(this.gameObject);
    }
}