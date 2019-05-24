using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject player;
    public double distance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerInRange())
        {
            // Move in direction of player
            this.transform.position += new Vector3(0.1f, 0, 0.1f);
        }
    }

    private bool PlayerInRange()
    {
        float dist = Vector3.Distance(player.transform.position, this.transform.position);

        return (dist < distance);
    }
}
