using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasVida : MonoBehaviour
{
    Vida playermasVida;
    public int cantidadmas;
    public float masTime;
    float currentMasTime;
    void Start()
    {
        playermasVida = GameObject.FindWithTag("Player").GetComponent<Vida>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            currentMasTime += Time.deltaTime;
            if (currentMasTime > masTime)
            {
                playermasVida.vida += cantidadmas;
                currentMasTime = 0.0f;
            }

        }
    }


}