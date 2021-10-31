using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Banana : MonoBehaviour
{
    public Text Mensaje1;

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "avatargordo")
        {
            Mensaje1.text = "los Bananos protegen el corazon, ayudan a bajar de peso";
            
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "avatargordo")
        {
            Mensaje1.text = "";
            Destroy(this.gameObject);
        }
    }

}
