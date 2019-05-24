using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.localRotation *= new Quaternion(0, 0, 0.1f * Time.deltaTime, 0);
        //transform.Rotate
        //transform.position += new Vector3(1, 0, 0);
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
    }
}
