using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawnerBoss : MonoBehaviour
{

    public GameObject spawnees;
    public GameObject[] spawnPoints;

    public float radius = 2;

    //int randomInt;
    int randomIntTwo;
    Vector3 randomVec;

    private float timer = 0.0f;
    private float waitTime = 0.2f;

    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            SpawnRandom();
            timer = 0;
        }
    }

    int GetRandom(int count)
    {
        return Random.Range(0, count);
    }

    Vector3 GetRandomVector(Vector3 vec)
    {
        return (Random.insideUnitSphere * radius) + vec;
    }

    void SpawnRandom()
    {
        //randomInt = GetRandom(spawnees.Length);
        randomIntTwo = GetRandom(spawnPoints.Length);
        randomVec = GetRandomVector(spawnPoints[randomIntTwo].transform.position);
        randomVec.y = 10;
        //Instantiate(spawnees[randomInt], randomVec, spawnPoints[randomIntTwo].transform.rotation);
        GameObject spawn = Instantiate(spawnees, randomVec, new Quaternion(0.7071f, 0, 0, 0.7071f));
        spawn.AddComponent<timeAlive>();
    }
}