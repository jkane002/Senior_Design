using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invasion : MonoBehaviour
{

    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        activateInvasion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void activateInvasion()
    {
        coroutine = delay(1.0f);
        StartCoroutine(coroutine);
        //delay

    }

    private IEnumerator delay(float waitTime)
    {
        for(int i = 0; i < transform.childCount; i += 2)
        {
            yield return new WaitForSeconds(waitTime);
            transform.GetChild(i).transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(i + 1).transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
