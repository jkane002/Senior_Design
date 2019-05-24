using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
	GameObject thedoor;

    private void Start()
    {
        thedoor = GameObject.FindWithTag("SF_Door");
        thedoor.GetComponent<Animation>().Play("open");
        Debug.Log("checking"); 
    }
    //void OnTriggerEnter ( Collider obj  ){
    //thedoor = GameObject.Find("SF_door");
	//thedoor.GetComponent<Animation>().Play("open");
//}

//void OnTriggerExit ( Collider obj  ){
	//thedoor= GameObject.FindWithTag("SF_Door");
	//thedoor.GetComponent<Animation>().Play("close");
//}
}