using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left_attack : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
    //}
    public GameObject[] lcubes;

    public bool isEntered = false;
    float speedAmt = 10f;

    public void Update()
    {
        if (isEntered)
            AttackLeft();
    }

    //float hi = Random.Range(0.0f, 1.0f);

    public void AttackLeft() {
        foreach (GameObject lcube in lcubes) {
            if (lcube.transform.position.x <= -15f) {
                speedAmt = 10f;
            }

            if (lcube.transform.position.x >= 15f) {
                speedAmt = -10f;
            }

            lcube.transform.Translate(speedAmt * Time.deltaTime, 0,0 );
        }
    }
}
