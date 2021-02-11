using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceHolderMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 startingPosition;
    public float speed;
    public Rigidbody2D rb;
    private int flag = 0;
    void Start()
    {
        startingPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch firstTouch = Input.GetTouch(0);
            Vector3 position = Camera.main.ScreenToWorldPoint(firstTouch.position);
            position.z = -1f;
            if (position.x > startingPosition.x)
            {
                //transform.position+=new Vector3(speed*Time.deltaTime,0,0);
                //transform.Translate(Vector3.right * Time.deltaTime);
                rb.AddForce(Vector3.right*speed);
                if (flag == 1)
                {
                    rb.AddForce(Vector3.right * speed);
                    flag = 2;
                }
            }
            else if(position.x <= startingPosition.x)
            {
                //transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
                //transform.Translate(Vector3.left * Time.deltaTime, Space.World);
                rb.AddForce(Vector3.left * speed);
                if (flag == 2)
                {
                    rb.AddForce(Vector3.left * speed);
                    flag = 1;
                }
            }
            //transform.position = position;
            
        }
    }
}
