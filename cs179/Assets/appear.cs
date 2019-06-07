using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appear : MonoBehaviour
{
    public static bool ready = false; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ready)
        {
            transform.position = new Vector3(transform.position.x, 10, transform.position.z);
        }
    }
}
