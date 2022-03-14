using System.Collections;
//using System;
//using System.Diagnostics;
using System.Collections.Generic;
using UnityEngine;

public class Dice5CheckZone : MonoBehaviour
{

    public GameObject dice;

    public bool snapped;
    Dice5CheckZone zone5;
    Dice6CheckZone zone6;

    void Start()
    {
        transform.position = new Vector3(-3.16f, -0.45f, 0.72f);
        zone5 = GameObject.Find("Dice5Zone").GetComponent<Dice5CheckZone>();
        zone6 = GameObject.Find("Dice6Zone").GetComponent<Dice6CheckZone>();
        snapped = false;
    }
    void Update()
    {


    }

    void set_position(GameObject dice)
    {

        dice.transform.parent.position = new Vector3(-3.216981f, 0.4062f, 0.7615873f);
        snapped = true;

    }

    public void OnTriggerStay(Collider col)
    {

        if (col.transform.parent != null && zone6.snapped == true)
        {

            dice = col.transform.gameObject;


            if (col.transform.gameObject.name == "Side2")
            {

                set_position(dice);
                snapped = true;

            }





        }


    }

    public void OnTriggerExit(Collider other)
    {

        snapped = false;

    }



}
