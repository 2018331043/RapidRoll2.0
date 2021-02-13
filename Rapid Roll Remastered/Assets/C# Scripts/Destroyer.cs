using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    // public GameObject camera;
    public Transform camera;
    void Start()
    {
        camera = GameObject.Find("Main Camera").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > (camera.position.y + 10f))
        {
            Destroy(this.gameObject);
        }
        
    }
}
