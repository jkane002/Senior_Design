using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;
    public bool Ai = false;
    public float walkRadius = 5;
    public bool tree = false;


    private Vector3 startpos;
    Transform target;
    NavMeshAgent agent;

    public GameObject bullet;
    public GameObject bulletSpawn;
    public float bulletForwardForce = 2f;

    public bool inRange = false;

    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(!tree)
        {
            moveTowardsPlayer();
        }
        float distance = Vector3.Distance(target.position, transform.position);
    }

    private void moveTowardsPlayer()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
            //shootAtPlayer();
            inRange = true;
        } else
        {
            inRange = false;
        }
    }

    private void MoveForward()
    {
        if(startpos.x - transform.position.x <= 5)
            agent.SetDestination(new Vector3(1,0,0));
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

    private void shootAtPlayer()
    {
        GameObject tempBulletHandler;
        tempBulletHandler = Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation) as GameObject;

        //tempBulletHandler.transform.Rotate(Vector3.left * 90);

        Rigidbody tempRigidBody;
        tempRigidBody = tempBulletHandler.GetComponent<Rigidbody>();

        tempRigidBody.AddForce(transform.forward * bulletForwardForce);

        tempBulletHandler.transform.Translate(new Vector3(1, 0, 0));

        Destroy(tempBulletHandler, 2.0f);
    }
}
