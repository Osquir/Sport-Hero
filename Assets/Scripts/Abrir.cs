using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Abrir : MonoBehaviour
{
    public static bool key;
    public Text mensaje;
    public Text Need;
    // Start is called before the first frame update
    void Start()
    {
        mensaje.enabled = false;
        Need.enabled = false;
        key = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("press key E");
        mensaje.enabled=true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "OSCAR")
        {
            Debug.Log("press key E");
            mensaje.enabled = false;
            Need.enabled = false;
        }
    }

        private void OnTriggerStay(Collider other)
    {
        
        if (other.name == "OSCAR")
        {
            if (key)
            {
                if (Input.GetKey(KeyCode.E))
                {
                GetComponent<Animator>().SetBool("puerta", true);
                }
                
            }
            else
            {
                Need.enabled = true;

            }
        }
    }
}
