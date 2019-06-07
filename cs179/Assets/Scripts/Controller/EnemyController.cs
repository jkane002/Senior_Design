using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;

    GameObject spawn;
    private Vector3 startpos;
    Transform target;
    NavMeshAgent agent;

    public float fire_cool_down_period = 2.0f;
    public bool walk;
    public bool shoot;
    bool wait;

    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        startpos = transform.position;

        spawn = GameObject.Find("Bullet");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= lookRadius && walk)
        {
            //FacePlayer();
            agent.SetDestination(target.position);
            if (shoot)
            {
                StartCoroutine(ShootCoroutine(fire_cool_down_period));
            }
        } else if (!walk && shoot)
        {
            FacePlayer();
            if (distance <= lookRadius)
            {
                StartCoroutine(ShootCoroutine(fire_cool_down_period));
            }
        }
    }
    private void FacePlayer()
    {
        Vector3 lookVector = target.position - transform.position;
        lookVector.y = transform.position.y;
        Quaternion rot = Quaternion.LookRotation(lookVector);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, 1);
    }
    private void MoveForward()
    {
        if (startpos.x - transform.position.x <= 5)
            agent.SetDestination(new Vector3(1f, 0, 0));
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }


    IEnumerator ShootCoroutine(float i)
    {
        if (wait)
            yield break;

        wait = true;
        GameObject b = Instantiate(spawn, transform.position, transform.rotation);
        b.AddComponent<projectileMovement>();
        b.GetComponent<projectileMovement>().speed = 7.0f;
        Destroy(b.gameObject, 1.25f);
        yield return new WaitForSeconds(i);
        wait = false;
    }


}
