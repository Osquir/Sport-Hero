using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Desicion : MonoBehaviour

{
    public Text Mensaje1;
    public InputField respuesta;
    public Text Answer;
    public bool Activar;
    public AudioSource playSound;
    bool m_ToggleChange;
    bool m_Play;

    void Start()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "avatargordo")

        {

            playSound.Play();

        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.name == "avatargordo")

        {
            
            Mensaje1.text = "Estas agotado es necesario descansar ¿cuantos minutos lo quieres hacer?";
          
          
        }
        if (respuesta.text == "")
        {

            Answer.text = "";         
        }
        else
        {
            if(respuesta.text == "15")
            {
                Answer.text = "buena decision";
            }

           
            else
            {
                Answer.text = "respuesta erronea";
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "avatargordo")
        {
            Mensaje1.text = "";
            respuesta.text = "";

        }
      

    }


}
