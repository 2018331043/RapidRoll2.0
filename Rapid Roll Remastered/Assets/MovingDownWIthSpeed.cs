using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MovingDownWIthSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private float timePassed;
    public GameObject platforms;
    void Start()
    {
        timePassed = Time.deltaTime;
        System.Random rnd = new System.Random();
        //Instantiate(platforms, new Vector3(Random.Range(1f,5.8f), transform.position.y + 2, -1), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        System.Random rnd = new System.Random();
        timePassed += Time.deltaTime;
        if (timePassed >= 2)
        {
            timePassed = 0;
            Instantiate(platforms, new Vector3(Random.Range(1f, 5.8f), transform.position.y - 8, -1), Quaternion.identity);
        }
        
        //Instantiate(platforms, new Vector3((float)rnd.NextDouble()%6, transform.position.y+2, 0), Quaternion.identity);
    }
}
