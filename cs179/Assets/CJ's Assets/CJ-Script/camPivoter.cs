using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camPivoter : MonoBehaviour
{
    public Transform camPivot;
    public Transform cam;
    float heading;
    //  public float jumpForce = 7;
  //  public SphereCollider col;
    //private Rigidbody rb;

    Vector2 input;
    /*
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
    }
    */
    // Update is called once per frame
    void Update()
    {
        heading += Input.GetAxis("Mouse X") * Time.deltaTime * 180;  
        camPivot.rotation = Quaternion.Euler(0, heading,0);
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        input = Vector2.ClampMagnitude(input, 1);

        Vector3 camF = cam.forward;
        Vector3 camR = cam.right;
        camF.y = 0;
        camR.y = 0;
        camF = camF.normalized;
        camR = camR .normalized;

        //transform.position += new Vector3(input.x, 0, input.y) * Time.deltaTime * 5;
        transform.position += ((camF * input.y) + (camR * input.x)) * Time.deltaTime * 15;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            //score = score + 1;
            //SetScoreText();
        }
    }


}
