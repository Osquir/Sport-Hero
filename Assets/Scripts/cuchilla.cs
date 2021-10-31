using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuchilla : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {

    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<chekConditions>().death = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Morir" + other.name);
        if (other.name == "OSCAR")
        {
            //Destroy(this.gameObject);            
            other.GetComponent<chekConditions>().death = true;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        other.GetComponent<chekConditions>().craw = true;
    }
}
