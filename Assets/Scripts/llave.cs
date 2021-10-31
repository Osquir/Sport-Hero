using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llave : MonoBehaviour
{
    public static bool key;
    // Start is called before the first frame update
    void Start()
    {
        key = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Llave1" + other.name);
        if (other.name == "OSCAR")
        {
            Destroy(this.gameObject);
            key = true;
            
            
        }
    }

}

