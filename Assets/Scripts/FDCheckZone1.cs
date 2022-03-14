using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FDCheckZone1 : MonoBehaviour
{
    public GameObject dice;
    public bool snapped;

    public int actualDiceNumber;

    Dice6CheckZone zone6;
    Dice5CheckZone zone5;



    void Start()
    {
        transform.position = new Vector3(-1.66f, -0.45f, -2.65f);
        zone6 = GameObject.Find("Dice6Zone").GetComponent<Dice6CheckZone>();
        zone5 = GameObject.Find("Dice5Zone").GetComponent<Dice5CheckZone>();
        this.snapped = false;
        actualDiceNumber = 0;
    }

    void set_position(GameObject dice)
    {

        dice.transform.parent.position = new Vector3(-1.574293f, 0.4062f, -2.737124f);
        this.snapped = true;
    }

    public int get_DiceNumber()
    {
        return actualDiceNumber;
    }

    public void OnTriggerStay(Collider col)
    {

        if (col.transform.parent != null && zone5.snapped == true && zone6.snapped == true)
        {

            dice = col.transform.gameObject;


            if (col.transform.gameObject.name != null)
            {
                set_position(dice);

                switch (col.gameObject.name)
                {
                    case "Side1":
                        actualDiceNumber = 6;
                        break;
                    case "Side2":
                        actualDiceNumber = 5;
                        break;
                    case "Side3":
                        actualDiceNumber = 4;
                        break;
                    case "Side4":
                        actualDiceNumber = 3;
                        break;
                    case "Side5":
                        actualDiceNumber = 2;
                        break;
                    case "Side6":
                        actualDiceNumber = 1;
                        break;
                }
            }
        }
    }


    public void OnTriggerExit(Collider other)
    {

        this.snapped = false;

    }



}
