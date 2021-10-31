using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        other.GetComponent<chekConditions>().death = true;
    }
}
