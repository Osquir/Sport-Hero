using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public float vida = 100;
    public Image BarraVida;

    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);
        BarraVida.fillAmount = vida / 100;
        if (vida <1)
        {
            GetComponent<chekConditions>().death = true;
        }
    }
}
