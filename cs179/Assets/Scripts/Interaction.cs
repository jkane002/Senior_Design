using UnityEngine;

public class Interaction : MonoBehaviour
{
    public float radius = 3f;
    public PlayerController_a pc;

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    private void Start()
    {
        pc = GetComponent<PlayerController_a>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            //GameObject.Find("Player").SendMessage("GameOver");
            gameObject.SetActive(false);

            //GameObject.Find("Player").SendMessage("GameOver");
        }

        if(other.gameObject.tag == "Key")
        {
            pc.hasKey = true;
            other.gameObject.SetActive(false);
        }

        if(other.gameObject.tag == "Door")
        {
            if(pc.hasKey)
            {
                //door open 
                Debug.Log("Door Opens");
            } else
            {
                Debug.Log("Door does not open");
            }
        }
    }

}
