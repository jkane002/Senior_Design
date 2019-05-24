using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController_a : MonoBehaviour
{

    public float speed;
    public Text countText;

    public bool hasKey = false;

    private int count;

    public 


    void Start()
    {
        speed *= .125f;
        count = 0;
        setCountText();
    }

    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.position += movement * speed;

        //transform.rotation = Quaternion.LookRotation(transform.right * -1f); //look left

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.LookRotation(transform.right); //look right
        }

        if (Input.GetKeyDown("space"))
        {
            //rb.AddForce(jump * jumpheight);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            setCountText();
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            this.gameObject.SetActive(false);

            GameOver();

        }
    }

    void setCountText()
    {
        countText.text = "Score: " + count.ToString();
    }

    [SerializeField] private GameObject gameOverUI;
    void GameOver()
    {
        gameOverUI.SetActive(true);
    }
    //public float speed;
    //public float jumpheight = 10.0f;

    //private Rigidbody rb;

    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //}

    //void FixedUpdate()
    //{
    //    float moveHorizontal = Input.GetAxis("Horizontal");
    //    float moveVertical = Input.GetAxis("Vertical");

    //    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
    //    Vector3 jump = new Vector3(0.0f, 10.0f, 0.0f);

    //    movement = GameObject.Find("Main Camera").transform.TransformDirection(movement);

    //    rb.AddForce(movement * speed);

    //    if (Input.GetKeyDown("space"))
    //    {
    //        rb.AddForce(jump * jumpheight);
    //    }
    //}

}