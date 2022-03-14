using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class ButtonScript : MonoBehaviour
{
    public UnityEngine.UI.Button button_shuffle;
    public UnityEngine.UI.Button button_reset;

    public int wuerfelversuche;
    public int aktuelleRunde;


    DiceNumberTextScript1 numberCalculation;
    DiceScript1 dice1;
    DiceScript2 dice2;
    DiceScript3 dice3;
    DiceScript4 dice4;
    DiceScript5 dice5;

    void Start()
    {

        dice1 = GameObject.Find("dice").GetComponent<DiceScript1>(); dice1.dice_unbind();
        dice2 = GameObject.Find("dice2").GetComponent<DiceScript2>(); dice2.dice_unbind();
        dice3 = GameObject.Find("dice3").GetComponent<DiceScript3>(); dice3.dice_unbind();
        dice4 = GameObject.Find("dice4").GetComponent<DiceScript4>(); dice4.dice_unbind();
        dice5 = GameObject.Find("dice5").GetComponent<DiceScript5>(); dice5.dice_unbind();

        numberCalculation = GameObject.Find("Text").GetComponent<DiceNumberTextScript1>();

        this.wuerfelversuche = 2;
        this.aktuelleRunde = 0;

    }


    void Awake()
    {
        button_shuffle = GameObject.Find("button_shuffle").GetComponent<UnityEngine.UI.Button>();
        button_shuffle.onClick.AddListener(Button_onClick);
        button_reset = GameObject.Find("button_reset").GetComponent<UnityEngine.UI.Button>();
        button_reset.gameObject.transform.localScale = new Vector3(0, 0, 0);
        button_reset.onClick.AddListener(Reset);

    }


    private void Update()
    {

        if (this.wuerfelversuche < 1)
        {
            button_reset.gameObject.transform.localScale = new Vector3(1, 1, 1);
            button_shuffle.gameObject.transform.localScale = new Vector3(0, 0, 0);
        }

    }

    void Reset()
    {

        button_reset.gameObject.transform.localScale = new Vector3(0, 0, 0);
        button_shuffle.gameObject.transform.localScale = new Vector3(1, 1, 1);
        this.wuerfelversuche = 2;

        dice1.Start();
        dice2.Start();
        dice3.Start();
        dice4.Start();
        dice5.Start();
        this.aktuelleRunde += 1;
        numberCalculation.pointCalculation(this.aktuelleRunde);



    }

    void Button_onClick()
    {
        this.wuerfelversuche = this.wuerfelversuche - 1;


        if (dice1.binded == false)
        {
            dice1.Start();
        }

        if (dice2.binded == false)
        {
            dice2.Start();
        }

        if (dice3.binded == false)
        {
            dice3.Start();
        }

        if (dice4.binded == false)
        {
            dice4.Start();
        }

        if (dice5.binded == false)
        {
            dice5.Start();
        }


    }



}
