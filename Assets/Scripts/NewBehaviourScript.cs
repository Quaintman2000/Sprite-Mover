using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Mover moveScript;

    //disabled variable
    private bool disabled = false;
    // Start is called before the first frame update
    void Start()
    {
        //grabs the mover component
        moveScript = GetComponent<Mover>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //Disables mover component
            if (disabled == false)
            {
                disabled = true;
                GetComponent<Mover>().enabled = false;
                GetComponent<SpriteRenderer>().color = Color.red;
            }
            else
            {
                disabled = false;
                GetComponent<Mover>().enabled = true;
                GetComponent<SpriteRenderer>().color = Color.white;
            }
        }

        
    }
}
