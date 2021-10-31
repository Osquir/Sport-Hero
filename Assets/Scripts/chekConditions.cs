using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chekConditions : MonoBehaviour
{
    public bool bIsSwimming;
    public bool death;
    public bool craw;
    public bool climb;
    public bool walk1;
    public bool punch;

    public STATES currentState;
    void Start()
    {

        currentState = STATES.IDLE;
        bIsSwimming = false;
        death = false;
        craw = false;
        climb = false;
        walk1 = false;
        punch = false;
}

    void Update()
    {
        if (bIsSwimming)
        {
            if (Input.GetKey(KeyCode.W))
            {
                currentState = STATES.SWIM;
            }
            else
            {
                currentState = STATES.ISWATER;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                currentState = STATES.RIGTH;
            }

            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                currentState = STATES.LEFT;
            }
        }
        /*else if (Input.GetKey(KeyCode.UpArrow))
        {
            currentState = STATES.CLIMB;
        }*/


        else if (Input.GetKey(KeyCode.RightArrow))
        {
            currentState = STATES.RIGTH;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            currentState = STATES.LEFT;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            currentState = STATES.WALKBACK;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            currentState = STATES.WALK;

        }
        else if (Input.GetKey(KeyCode.K))
        {
            currentState = STATES.BOX;
        }

        else if (Input.GetKey(KeyCode.Y))
        {
            currentState = STATES.BIKE;

        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            currentState = STATES.JUMP;

        }
       
        else if (Input.GetKey(KeyCode.R))
        {
            currentState = STATES.CROUCH;

            if (Input.GetKey(KeyCode.T))
            {
                currentState = STATES.CRAWL;

            }
        }
       



        else if (Input.GetKey(KeyCode.LeftShift))
        {
            currentState = STATES.RUN;
        }
        else

        {
            currentState = STATES.IDLE;

        }


             

        if (death)
        {
            currentState = STATES.DEATH;
        }
        if (craw)
        {
            if (Input.GetKey(KeyCode.T))
            {
                currentState = STATES.CRAWL;

            }

        }

        if (climb)
        {
            {
                currentState = STATES.CLIMB;

            }

        }
        if (walk1)
        {
            {
                currentState = STATES.WALK1;

            }

        }
        if (punch)
        {
            currentState = STATES.PUNCH;
        }
    }



}
