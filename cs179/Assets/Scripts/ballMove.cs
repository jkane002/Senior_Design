using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ballMove : MonoBehaviour
{
    public float speed;
    public GameObject forcefield;

    private GameObject[] gameObjectArray;
    private Rigidbody rb;
    private bool ffactive;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //forcefield stuff
        gameObjectArray = GameObject.FindGameObjectsWithTag("SpawnPoint");
        ffactive = false;
        forcefield.SetActive(false);
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Powerup"))
        {
            other.gameObject.SetActive(false);
            forcefield.SetActive(true);
            ffactive = true;
            StartCoroutine(FF());
            foreach (GameObject go in gameObjectArray)
            {
                go.SetActive(false);
            }
        }
    }

    private IEnumerator FF()
    {
        float countDown = 5f;

        while (countDown >= 0)
        {
            countDown -= Time.smoothDeltaTime;
            yield return null;
        }

        if (countDown < 0)
        {
            forcefield.SetActive(false);
            foreach (GameObject go in gameObjectArray)
            {
                go.SetActive(true);
            }
        }

    }
}
