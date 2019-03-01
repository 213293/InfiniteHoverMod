using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkingSpawn : MonoBehaviour
{
    public GameObject Bomb;
    float randX;
    Vector2 whereToSpawn;
    public float spawneRate = 2f;
    float nextSpawn = 0.0f;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextSpawn)
        {
            {
                nextSpawn = Time.time + spawneRate;
                randX = Random.Range(120f, 120f);
                whereToSpawn = new Vector2(randX, transform.position.y);
                Instantiate(Bomb, whereToSpawn, Quaternion.identity);
            }
        }
    }
}


     