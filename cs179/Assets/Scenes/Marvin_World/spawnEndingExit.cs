using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEndingExit : MonoBehaviour
{
    public GameObject spawn;
    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow3;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 loc = new Vector3(-81.53f, 9.94f, 227.63f);
        Vector3 loc2 = new Vector3(-81.53f, 9.94f, 227.63f);
        Vector3 loc3 = new Vector3(-81.53f, 9.94f, 227.63f);
        Vector3 loc4 = new Vector3(-81.53f, 9.94f, 227.63f);

        Instantiate(spawn, loc, new Quaternion(0, 0, 0, 0));
        Instantiate(spawn, loc2, new Quaternion(0, 0, 0, 0));
        Instantiate(spawn, loc3, new Quaternion(0, 0, 0, 0));
        Instantiate(spawn, loc4, new Quaternion(0, 0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
