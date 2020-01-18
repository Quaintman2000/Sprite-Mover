using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //transform variable
    public Transform tf;
    //speed control variable
    public float speed = 0.1f;
   
    // Start is called before the first frame update
    void Start()
    {
        //get the transform component
        tf = GetComponent<Transform>();
       
    }

    // Update is called once per frame
    void Update()
    {
        // changes the vector direction
        Vector3 myVector= new Vector3(2, 4, 12);
        myVector= myVector.normalized;
        //moving the sprite in the vector direction by speed determined by the designer per frame
        tf.position = tf.position + (myVector * speed);
    }
}
