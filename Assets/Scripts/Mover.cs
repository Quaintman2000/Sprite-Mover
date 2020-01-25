using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //transform variable
    public Transform tf;
    //speed control variable
    public float speed = 0.1f;
    private Vector3 startSpot = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        //get the transform component
        tf = GetComponent<Transform>();
        tf.position = startSpot;

    }

    // Update is called once per frame
    void Update()
    {
        //// changes the vector direction
        //Vector3 myVector= new Vector3(2, 4, 12);
        //myVector= myVector.normalized;
        ////moving the sprite in the vector direction by speed determined by the designer per frame
        //tf.position = tf.position + (myVector * speed);

        if (Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.LeftShift))
        {
            //Move up when up arrow is pressed
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                tf.position = tf.position + (Vector3.up * 1);
            }
            //Move down when down arrow is pressed
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                tf.position = tf.position + (Vector3.down * 1);
            }
            //Move Left when left arrow is pressed
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                tf.position = tf.position + (Vector3.left * 1);
            }
            //Move Right when right arrow is pressed
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                tf.position = tf.position + (Vector3.right * 1);
            }
        }
        else
        {
            //Move up when up arrow is pressed
            if (Input.GetKey(KeyCode.UpArrow))
            {
                tf.position = tf.position + (Vector3.up * speed);
            }

            //Move down when down arrow is pressed
            if (Input.GetKey(KeyCode.DownArrow))
            {
                tf.position = tf.position + (Vector3.down * speed);
            }

            //Move Left when left arrow is pressed
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                tf.position = tf.position + (Vector3.left * speed);
            }

            //Move Right when right arrow is pressed
            if (Input.GetKey(KeyCode.RightArrow))
            {
                tf.position = tf.position + (Vector3.right * speed);
            }
        }

        //Reset position when space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tf.position = startSpot;
        }

       
    }
}
