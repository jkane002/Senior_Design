using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballJump : MonoBehaviour
{
    public float jumpHeight;
    static public bool isGrounded;
    public float GravityStrength;
    Rigidbody rb;

    void Start()
    {
        Physics.gravity = new Vector3(0, GravityStrength, 0);
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
    }

    void Update()
    {
        Vector3 jump = new Vector3(0.0f, 10.0f, 0.0f);
        if(!isGrounded)
        {
            Physics.gravity = new Vector3(0, GravityStrength, 0);
        }
        else
        {
            Physics.gravity = new Vector3(0, -9.8f, 0);
        }
        if (Input.GetKeyDown("space") && isGrounded)
        {
            //rb.AddForce(transform.up * jumpHeight);
            rb.AddForce(jump * jumpHeight);
            isGrounded = false;
        }
    }

    void OnCollisionEnter()
    {
        isGrounded = true;
    }
}