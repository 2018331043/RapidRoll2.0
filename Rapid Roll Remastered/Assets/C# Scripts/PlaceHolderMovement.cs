using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceHolderMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 startingPosition;
    public float speed=5f;
    public Rigidbody2D rb;
    private float TimePassed;
    private int flag1 = 1,flag2=1,flag=0;
    void Start()
    {
        startingPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
        TimePassed = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {

        MovingTheBall();
    }
    
    private void MovingTheBall()
    {
        if (Input.touchCount > 0)
        {
            //Debug.Log(Time.deltaTime+"Hello");
            //Debug.Log("Hello\n");
            Touch firstTouch = Input.GetTouch(0);
            Vector3 position = Camera.main.ScreenToWorldPoint(firstTouch.position);
            position.z = -1f;
            if (position.x > startingPosition.x)
            {
                //transform.position+=new Vector3(speed*Time.deltaTime,0,0);
                //transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
                rb.velocity = new Vector3(speed, 10f*Time.deltaTime, 0f);

                //rb.velocity = new Vector3(speed, rb.velocity.y, 0f);
                /*rb.AddForce(Vector3.right*speed);
                
                if (flag == 1)
                {
                    rb.AddForce(Vector3.right * speed*4);
                    Debug.Log("Eterted flag=1");
                    flag = 2;
                }
                flag = 2;*/
                /*flag1++;
                rb.AddForce(Vector3.right * speed * (flag2));
                flag2 = 1;*/

            }
            else if (position.x <= startingPosition.x)
            {
                //rb.velocity = new Vector3(-speed, rb.velocity.y, 0f);
                rb.velocity = new Vector3(-speed, 10f * Time.deltaTime, 0f);

                //transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
                //transform.Translate(Vector3.left * Time.deltaTime*speed, Space.World);
                /*rb.AddForce(Vector3.left * speed);
                
                if (flag == 2)
                {
                    rb.AddForce(Vector3.left * speed*4);
                    Debug.Log("Eterted flag=2");
                    flag = 1;
                }
                flag = 1;*/
                /*flag2++;
                rb.AddForce(Vector3.left * speed * (flag1));
                flag1 = 1;*/
            }
            //transform.position = position;

        }
    }
}
