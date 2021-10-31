using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puerta : MonoBehaviour
{ 
    //Animator anim;
    //public Canvas can;
    public Text message;

    

    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();
        message.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name== "OSCAR")
        {
            Debug.Log("presione E");
            message.enabled = true;
          
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "OSCAR")
        {

            if (Input.GetKey(KeyCode.E))
            {
            GetComponent<Animator>().SetBool("open", true);
                
            }

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "OSCAR")
        {
            Debug.Log("presione E");
            message.enabled = false;

        }
    }
}
