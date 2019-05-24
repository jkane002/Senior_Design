using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class enterCubeObstacle : MonoBehaviour
{
    public BoxCollider enterGame;
    public left_attack left_attack_script;
    public right_attack right_attack_script;

    void Start()
    {
   }

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject

        if (collision.gameObject.tag == "Player")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            left_attack_script.isEntered = true;
            left_attack_script.Update();

            right_attack_script.isEntered = true;
            right_attack_script.Update();
        }
    }
}
