using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class right_attack : MonoBehaviour
{
    public GameObject[] rcubes;

    float speedAmt = -10f;

    public bool isEntered = false;


    public void Update()
    {
        if (isEntered)
            AttackRight();
    }


    public void AttackRight()
    {
        foreach (GameObject rcube in rcubes)
        {
            if (rcube.transform.position.x <= -15f)
            {
                speedAmt = 10f;
            }

            if (rcube.transform.position.x >= 15f)
            {
                speedAmt = -10f;
            }

            rcube.transform.Translate(speedAmt * Time.deltaTime, 0, 0);
        }
    }
}
