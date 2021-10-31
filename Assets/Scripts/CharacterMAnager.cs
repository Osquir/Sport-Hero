using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMAnager : MonoBehaviour
{
    public Text txtlife;
    public float Life;
    mecanics mec;
    public float key;
    chekConditions chConditions;
    // Start is called before the first frame upda
    void Start()
    {
        mec = GetComponent<mecanics>();
        chConditions = GetComponent<chekConditions>();
        Life = 100;
    }

    // Update is called once per frame
    void Update()
    {
        //uiCharacter();

        switch (chConditions.currentState)
        {
            case STATES.IDLE:
                mec.Idle();
                break;
            case STATES.WALK:
                mec.Walk();
                break;
            case STATES.RUN:
                mec.Run();
                break;
            case STATES.ISWATER:
                mec.IsWater();
                break;
            case STATES.SWIM:
                mec.Swim();
                break;
            case STATES.WALKBACK:
                mec.Walback();
                break;
            case STATES.LEFT:
                mec.left();
                break;
            case STATES.RIGTH:
                mec.rigth();
                break;
            case STATES.CROUCH:
                mec.Crouch();
                break;
            case STATES.CRAWL:
                mec.Crawl();
                break;
            case STATES.DEATH:
                mec.death();
                break;
            case STATES.CLIMB:
                mec.climb();
                break;
            case STATES.IDLEN:
                mec.IdleN();
                break;
            case STATES.WALK1:
                mec.Walk1();
                break;
            case STATES.ATACK:
                mec.atack();
                break;
            case STATES.BIKE:
                mec.bike();
                break;
            case STATES.JUMP:
                mec.jump();
                break;
            case STATES.PUNCH:
                mec.punch();
                break;
            default:
                break;
        }

    }
    /*   void uiCharacter()
    {
        txtlife.text = "LIFE : " + Life;
    }*/
    
}
