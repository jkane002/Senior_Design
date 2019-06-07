using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBallScript : MonoBehaviour
{
    public Transform camPivot;
    public Transform cam;
    float heading;
    public static float multiplier = 1.0f;

    Vector2 input;

    public PlayerManager pm;

    // Update is called once per frame
    void Update()
    {
        heading += Input.GetAxis("Mouse X") * Time.deltaTime * 180;
        camPivot.rotation = Quaternion.Euler(0, heading, 0);
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        input = Vector2.ClampMagnitude(input, 1);

        Vector3 camF = cam.forward;
        Vector3 camR = cam.right;
        camF.y = 0;
        camR.y = 0;
        camF = camF.normalized;
        camR = camR.normalized;

        transform.position += ((camF * input.y) + (camR * input.x)) * Time.deltaTime * 10 * multiplier;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Pickup"))
        {
            pm.score++;
            other.gameObject.SetActive(false);
        }
    }


}