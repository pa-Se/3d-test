using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DiceCheckZoneScript1 : MonoBehaviour
{

    Vector3 diceVelocity;
    Vector3 diceVelocity2;
    Vector3 diceVelocity3;

    Vector3 diceVelocity4;

    Vector3 diceVelocity5;



    // Update is called once per frame
    void FixedUpdate()
    {
        diceVelocity = DiceScript1.diceVelocity;
        diceVelocity2 = DiceScript1.diceVelocity;
        diceVelocity3 = DiceScript1.diceVelocity;
        diceVelocity4 = DiceScript1.diceVelocity;
        diceVelocity5 = DiceScript1.diceVelocity;
    }

    private void OnTriggerStayDice(Collider col, Vector3 vector, Action<int> fnSetNumber)
    {
        if (vector.x == 0f && vector.y == 0f && vector.z == 0f)
        {
            switch (col.gameObject.name)
            {
                case "Side1":
                    fnSetNumber(6);
                    //diceNumber.diceNumber = 6;
                    break;
                case "Side2":
                    fnSetNumber(5);
                    //diceNumber.diceNumber = 5;
                    break;
                case "Side3":
                    fnSetNumber(4);
                    //diceNumber.diceNumber = 4;
                    break;
                case "Side4":
                    fnSetNumber(3);
                    //diceNumber.diceNumber = 3;
                    break;
                case "Side5":
                    fnSetNumber(2);
                    //diceNumber.diceNumber = 2;
                    break;
                case "Side6":
                    fnSetNumber(1);
                    //diceNumber.diceNumber = 1;
                    break;
            }

        }
    }

    void OnTriggerStay(Collider col)
    {

        if (col.transform.parent != null)
        {
            var diceName = col.transform.parent.gameObject.name;

            if (diceName == "dice")
            {
                OnTriggerStayDice(col, diceVelocity, (value) => DiceNumberTextScript1.diceNumber1 = value);
            }
            if (diceName == "dice2")
            {
                OnTriggerStayDice(col, diceVelocity2, (value) => DiceNumberTextScript1.diceNumber2 = value);
            }

            if (diceName == "dice3")
            {
                OnTriggerStayDice(col, diceVelocity3, (value) => DiceNumberTextScript1.diceNumber3 = value);
            }

            if (diceName == "dice4")
            {
                OnTriggerStayDice(col, diceVelocity4, (value) => DiceNumberTextScript1.diceNumber4 = value);
            }

            if (diceName == "dice5")
            {
                OnTriggerStayDice(col, diceVelocity5, (value) => DiceNumberTextScript1.diceNumber5 = value);
            }

        }
    }




}
