using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController_a : MonoBehaviour
{

    public float speed;

    public Camera cam;
    public bool hasKey = false;
    public float radius = 3f;

    public PlayerManager pm;

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    void Start()
    {
        //setCountText();
        pm.GetComponent<PlayerManager>();
    }

    private void Update()
    {
        //Debug.Log("Health: + " + pm.Health);
        //if(pm.Health < 0)
        //{
        //    pm.GameOver();
        //    //Debug.Log("Health = 0");
        //}
    }

    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        //Get Horizontal and Vertical Movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //camera forward and right vectors:
        Vector3 forward = cam.transform.forward;
        Vector3 right = cam.transform.right;

        //project forward and right vectors on the horizontal plane (y = 0)
        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        //this is the direction in the world space we want to move:
        Vector3 desiredMoveDirection = forward * moveVertical + right * moveHorizontal;

        //now we can apply the movement:
        transform.Translate(desiredMoveDirection * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            pm.score++;
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            //pm.Health -= 10;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(other.gameObject.CompareTag("Bullet"))
        {
            //pm.Health -= 5;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (other.gameObject.tag == "Key")
        {
            hasKey = true;
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Door")
        {
            if (hasKey)
            {
                Debug.Log("Door Opens");
            }
            else
            {
                Debug.Log("Door does not open");
            }
        }

    }

}
