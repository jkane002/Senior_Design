using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rampBoost : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
      Rigidbody rb = other.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0.0f, 200.0f, 200.0f));
    }
}
