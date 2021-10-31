using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoVida : MonoBehaviour
{
    Vida playerVida;
    public int cantidad;
    public float damageTime;
    float currentDamageTime;
    void Start()
    {
        playerVida = GameObject.FindWithTag("Player").GetComponent<Vida>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            currentDamageTime += Time.deltaTime;
            if (currentDamageTime > damageTime)
            {
                playerVida.vida -= cantidad;
                currentDamageTime = 0.0f;
                Destroy(this.gameObject);
            }
           
        }
    }


}
