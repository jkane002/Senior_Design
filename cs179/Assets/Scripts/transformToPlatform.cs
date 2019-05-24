using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformToPlatform : MonoBehaviour
{
    //public BoxCollider boxCollider;
    public GameObject player;

     // Start is called before the first frame update
    void OnCollisionEnter(Collision t)
    {
        if (t.gameObject.tag == "Player") 
            player.transform.position = new Vector3(0, 6, 0);
    }

     void OnTriggerEnter(Collider other)
    {
        player.transform.position = new Vector3(0, 6, 0);
    }
}
