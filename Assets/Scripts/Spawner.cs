using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject enemy1;

    public float spawnRate = 3.0f;

    float nextSpawn = 0f;
    Vector2 whereToSpawn;

    int whatToSpawn;
    int randx, randY;



    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            whatToSpawn = Random.Range(1,2);
            randx = Random.Range(0,9);
            randY = Random.Range(-4, 3);
            whereToSpawn = new Vector2(randx, randY);
            Instantiate(enemy1, whereToSpawn, Quaternion.identity);

        }


    }
}
