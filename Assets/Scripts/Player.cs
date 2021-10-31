using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;
    public float speedTurn = 500;
    Animator anim;
    void Start()
    {
        //Debug.Log(" hola mundo");
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("Walk", true);
            anim.SetBool("Idle", false);
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("Walk", true);
            anim.SetBool("Idle", false);
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        else
        {
            anim.SetBool("Walk", false);
            anim.SetBool("Idle", true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * speedTurn * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -speedTurn * Time.deltaTime);
        }

    }
}

