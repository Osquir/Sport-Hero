using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour

{
    public Text Mensaje1;
  
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "avatargordo")
        {
            Mensaje1.text = "¡sabias que:! correr reduce el colesterol, mejora el funcionamiento cardiovascular, ayuda a domir mejor en las noches, reduce calorias y estress" ;
        }
            
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "avatargordo")
        {
            Mensaje1.text = "";
        }
    }


}
