using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public float distance;
    public float distanceToFollow;
    public GameObject StarPoint;
    public GameObject Character;
    public Animator animator;
    public bool morir;
    
    NavMeshAgent navMeshAgent;

    // Start is called be Nore the first frame update
    void Start()
    {
        distanceToFollow = 8;
        animator = GetComponent < Animator > ();
        navMeshAgent = GetComponent<NavMeshAgent>();
        Character = GameObject.Find("avatargordo");
       

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, Character.transform.position);
        if (distance <= distanceToFollow)
        {
            navMeshAgent.SetDestination(Character.transform.position);
        }

        else
        {
            navMeshAgent.SetDestination(StarPoint.transform.position);

        }
        if(distance<= distanceToFollow)
        {
            animator.SetInteger("Estado",1);
        }
        else
        {
            animator.SetInteger("Estado", 0);
        }

        if (distance < 2)
        {
            animator.SetInteger("Estado", 2);
           //morir= GetComponent<chekConditions>().death = true;
        }
    }
}
