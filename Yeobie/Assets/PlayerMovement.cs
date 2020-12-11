using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Sprite Squir1;
    public Sprite Squir2;
    private Rigidbody2D rb2D;
    float xvel = 0.0f;
    float yvel = 0.0f;
    public float minx;
    public float miny;
    public float maxx;
    public float maxy;


    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();

        rb2D.bodyType = RigidbodyType2D.Kinematic; 
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int number = Random.Range(1,20000);
        if (number % 2 ==0){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Squir1;    
        }
        else {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Squir2;
        }
        
        //Press the Up arrow key to move the RigidBody upwards
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (rb2D.position.y <= maxy)
            {
                yvel = 200.0f; 
            }
                
            else
            {
                yvel = 0.0f;
            }

            rb2D.velocity = new Vector2(xvel, yvel);
        }

        //Press the Down arrow key to move the RigidBody downwards
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (rb2D.position.y >= miny)
            {
                yvel = -200.0f; 
            }

            else
            {
                yvel = 0.0f;
            }

            rb2D.velocity = new Vector2(xvel, yvel);

        }


        //Press the Right arrow key to move the RigidBody downwards
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<SpriteRenderer>().flipX = true;
            if (rb2D.position.x <= maxx)
            {
                xvel = 200.0f; 
            }

            else
            {
                xvel = 0.0f;
            }

            rb2D.velocity = new Vector2(xvel, yvel);

        }

        //Press the Left arrow key to move the RigidBody downwards
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<SpriteRenderer>().flipX = false;
            if (rb2D.position.x >= minx)
            {
                xvel = -200.0f;
            }

            else
            {
                xvel = 0.0f;
            }

            rb2D.velocity = new Vector2(xvel, yvel);
        }

        //One directional movement
        if (!(Input.GetKey(KeyCode.RightArrow)) && !(Input.GetKey(KeyCode.LeftArrow)))
        {
            xvel = 0.0f;
            rb2D.velocity = new Vector2(xvel, yvel);
        }

        if (!(Input.GetKey(KeyCode.UpArrow)) && !(Input.GetKey(KeyCode.DownArrow)))
        {
            yvel = 0.0f;
            rb2D.velocity = new Vector2(xvel, yvel);
        }

    }
}
