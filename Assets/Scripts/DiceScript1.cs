using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = UnityEngine.Random;


public class DiceScript1 : MonoBehaviour
{
    public static Rigidbody rb;
    public static Vector3 diceVelocity;

    public Dice6CheckZone dcz6;
    public Dice5CheckZone dcz5;

    public FDCheckZone1 fdcz1;
    public FDCheckZone2 fdcz2;
    public FDCheckZone3 fdcz3;
    public bool binded = false;

    // Use this for initialization
    public void Start()
    {

        this.binded = false;
        dcz6 = GameObject.Find("Dice6Zone").GetComponent<Dice6CheckZone>();
        dcz5 = GameObject.Find("Dice5Zone").GetComponent<Dice5CheckZone>();
        fdcz1 = GameObject.Find("FDiceZone1").GetComponent<FDCheckZone1>();
        fdcz2 = GameObject.Find("FDiceZone2").GetComponent<FDCheckZone2>();
        fdcz3 = GameObject.Find("FDiceZone3").GetComponent<FDCheckZone3>();


        DiceNumberTextScript1.diceNumber1 = 0;
        DiceNumberTextScript1.diceNumber2 = 0;
        DiceNumberTextScript1.diceNumber3 = 0;
        DiceNumberTextScript1.diceNumber4 = 0;
        DiceNumberTextScript1.diceNumber5 = 0;

        rb = GetComponent<Rigidbody>();
        float dirX = Random.Range(0, 200);
        float dirY = Random.Range(0, 100);
        float dirZ = Random.Range(0, 100);
        transform.position = new Vector3(Random.Range(-9.5f, -8.5f), Random.Range(0.4f, 0.1f), Random.Range(4f, 3.7f));
        transform.rotation = Quaternion.identity;
        rb.AddForce(transform.up * 350);
        rb.AddTorque(dirX, dirY, dirZ);


    }



    public void Update()
    {



        if (dcz6.dice.name == "Side1" && dcz6.snapped == true && dcz6.dice.transform.parent.name == "dice")
        {

            binded = true;

        }


        else if (dcz5.dice.name == "Side2" && dcz5.snapped == true && dcz5.dice.transform.parent.name == "dice")
        {

            binded = true;

        }



        else if ((fdcz1.dice.name == "Side1" || fdcz1.dice.name == "Side2" || fdcz1.dice.name == "Side3" || fdcz1.dice.name == "Side4" || fdcz1.dice.name == "Side5" || fdcz1.dice.name == "Side6") && fdcz1.snapped == true && fdcz1.dice.transform.parent.name == "dice")
        {

            binded = true;


        }


        else if ((fdcz2.dice.name == "Side1" || fdcz2.dice.name == "Side2" || fdcz2.dice.name == "Side3" || fdcz2.dice.name == "Side4" || fdcz2.dice.name == "Side5" || fdcz2.dice.name == "Side6") && fdcz2.snapped == true && fdcz2.dice.transform.parent.name == "dice")
        {

            binded = true;

        }

        else if ((fdcz3.dice.name == "Side1" || fdcz3.dice.name == "Side2" || fdcz3.dice.name == "Side3" || fdcz3.dice.name == "Side4" || fdcz3.dice.name == "Side5" || fdcz3.dice.name == "Side6") && fdcz3.snapped == true && fdcz3.dice.transform.parent.name == "dice")
        {

            binded = true;


        }
        else
        {
            this.binded = false;
        }

    }

    void bind_check()
    {

    }

    public void dice_unbind()
    {

        this.binded = false;
    }

    public void reset_position()
    {

        this.binded = false;
        rb = GetComponent<Rigidbody>();
        float dirX = Random.Range(0, 100);
        float dirY = Random.Range(0, 100);
        float dirZ = Random.Range(0, 100);
        transform.position = new Vector3(Random.Range(-9.5f, -8.5f), Random.Range(0.4f, 0.1f), Random.Range(4f, 3.7f));
        transform.rotation = Quaternion.identity;
        rb.AddForce(transform.up * 300);
        rb.AddTorque(dirX, dirY, dirZ);


    }



}
