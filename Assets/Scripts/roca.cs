using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roca : MonoBehaviour
    
{
    public Text rock;
    // Start is called before the first frame update
    void Start()
    {
        rock.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Push Rock");
        rock.enabled = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            GetComponent<Animator>().SetBool("Rock", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "OSCAR")
        {
            Debug.Log("presione E");
            rock.enabled = false;

        }
    }

}
