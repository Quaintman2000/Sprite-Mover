using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Experimental.U2D;

public class NewBehaviourScript1 : MonoBehaviour
{
    public GameObject object1;

    private bool disabled = false;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (disabled == false)
            {
                object1.SetActive(false);
                disabled = true;
                
            }
            else
            {
                object1.SetActive((true));
                disabled = false;
                
            }
        }
        if (Input.GetKeyDown((KeyCode.Escape)))
        {
            Application.Quit();
        }
    }
}
