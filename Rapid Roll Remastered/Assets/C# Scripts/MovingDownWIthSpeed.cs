using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MovingDownWIthSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed,increaseofSpeed;
    private float timePassed;
    public GameObject platforms;
    public GameObject camera;
    void Start()
    {
        timePassed = Time.deltaTime;
        System.Random rnd = new System.Random();
        //Instantiate(platforms, new Vector3(Random.Range(1f,5.8f), transform.position.y + 2, -1), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        MoveObjectDownward();
        SpawnNewLandingObject();
        /*if (transform.position.y > (camera.transform.position.y + 10f))
        {
            ///Destroy(GetComponent<>);
        }*/

        //Instantiate(platforms, new Vector3((float)rnd.NextDouble()%6, transform.position.y+2, 0), Quaternion.identity);
    }

    private void SpawnNewLandingObject()
    {
        if (timePassed >= (2 / speed))
        {
            timePassed = 0;
            Instantiate(platforms, new Vector3(Random.Range(1f, 5.8f), transform.position.y - 8, -1), Quaternion.identity);
        }
    }

    private void MoveObjectDownward()
    {
        transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        timePassed += Time.deltaTime;
        speed += .0005f;
    }
}
