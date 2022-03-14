using System.Collections;
//using System;
//using System.Diagnostics;
using System.Collections.Generic;
using UnityEngine;

public class Dice6CheckZone : MonoBehaviour
{
    public GameObject dice;
    public bool snapped;

    public Dice6CheckZone zone6;

    void Start()
    {

        transform.position = new Vector3(4.61f, -0.45f, 1.8f);
        zone6 = GameObject.Find("Dice6Zone").GetComponent<Dice6CheckZone>();
        snapped = false;

    }


    void Update()
    {


    }

    void set_position(GameObject dice)
    {

        dice.transform.parent.position = new Vector3(4.554376f, 0.4062931f, 2.154026f);
        snapped = true;

    }

    public void OnTriggerStay(Collider col)
    {

        if (col.transform.parent != null)
        {

            dice = col.transform.gameObject;


            if (col.transform.gameObject.name == "Side1")
            {

                set_position(dice);

            }

        }


    }

    public void OnTriggerExit(Collider other)
    {

        snapped = false;
    }


}



