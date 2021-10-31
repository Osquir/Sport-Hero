using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mecanics : MonoBehaviour
{
    Animator anim;
   
    public float speed = 3;
    public float speedTurn = 100;
    public float trepar = 1;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Idle()
    {
        anim.SetInteger("estado", 0);
    }
    public void Walk()
    {
        anim.SetInteger("estado", 1); //walk 1
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void Run()
    {
        anim.SetInteger("estado", 2);
        transform.Translate(Vector3.forward * speed* 2 * Time.deltaTime);
    }
    public void IsWater()
    {
        anim.SetInteger("estado", 3);
       
    }
    public void Swim()
    {
        anim.SetInteger("estado", 4);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void Walback()
    {
        anim.SetInteger("estado", 5);
        transform.Translate(Vector3.forward * -speed * Time.deltaTime);
    }
    public void Crouch()
    {
        anim.SetInteger("estado", 6);
        
    }
    public void Crawl()
    {
        anim.SetInteger("estado", 7);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void death()
    {
        anim.SetInteger("estado", 8);
    }
    public void punch()
    {
        anim.SetInteger("estado",12);
    }
    public void climb()
    {
        anim.SetInteger("estado", 9);
        transform.Translate(0, Time.deltaTime*trepar, 0);
    }
    public void jump()
    {
        anim.SetInteger("estado", 11);
        transform.Translate(0, Time.deltaTime * trepar, 0);
    }
    public void left()
    {
        transform.Rotate(Vector3.up * -speedTurn * Time.deltaTime);
    }
    public void rigth()
    {
        transform.Rotate(Vector3.up * speedTurn * Time.deltaTime);
    }
    public void key()
    {
        Destroy(this.gameObject);
    }
    public void IdleN()
    {
        anim.SetInteger("Estado", 0);
    }
    public void Walk1()
    {
        anim.SetInteger("estado", 1); //walk 1
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void atack()
    {
        anim.SetInteger("estado", 2); //walk 1
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void bike()
    {
        anim.SetInteger("estado", 10); 
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void box()
    {
        anim.SetInteger("estado", 13);
       
    }
}
