using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupPickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision otherObj)
    {
        if (gameObject.name == "Blue Collectible")
        {
            Debug.Log("Blue");
            ballMaterial.material = 1;
        }
        else if (gameObject.name == "Red Collectible")
        {
            Debug.Log("Red");
            ballMaterial.material = 2;
        }
        else if (gameObject.name == "Green Collectible")
        {
            Debug.Log("Green");
            ballMaterial.material = 3;
        }
        Destroy(gameObject);
    }
}
