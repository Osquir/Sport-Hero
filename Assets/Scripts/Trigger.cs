using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Permanecer" + other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Salir" + other.name);
        if (other.name == "Boy")
        {
            //Destroy(this.gameObject);
            other.GetComponent<chekConditions>().bIsSwimming = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entrar" + other.name);
        if (other.name == "Boy")
        {
            //Destroy(this.gameObject);            
            other.GetComponent<chekConditions>().bIsSwimming = true;
        }
    }
}
