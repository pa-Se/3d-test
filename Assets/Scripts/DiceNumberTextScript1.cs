using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class DiceNumberTextScript1 : MonoBehaviour
{

    DiceScript1 dice1;
    DiceScript2 dice2;
    DiceScript3 dice3;
    DiceScript4 dice4;
    DiceScript5 dice5;

    FDCheckZone1 trigger1;
    FDCheckZone2 trigger2;
    FDCheckZone3 trigger3;


    public ButtonScript buttonScript;

    Text text;
    Text player1Points;
    Text player1Wuerfelversuche;
    Text roundView;
    public static int diceNumber1;
    public static int diceNumber2;

    public static int diceNumber3;

    public static int diceNumber4;

    public static int diceNumber5;

    public static int[] player1PointCalculation;

    public int rundenAnzahlGesamt;
    public int aktuelleRunde;
    public bool gameIsOver;

    int rundenPunktzahl;






    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        player1Points = GameObject.Find("player1").GetComponent<Text>();
        roundView = GameObject.Find("roundOverview").GetComponent<Text>();
        player1Wuerfelversuche = GameObject.Find("NumberOfRolls").GetComponent<Text>();

        trigger1 = GameObject.Find("FDiceZone1").GetComponent<FDCheckZone1>();
        trigger2 = GameObject.Find("FDiceZone2").GetComponent<FDCheckZone2>();
        trigger3 = GameObject.Find("FDiceZone3").GetComponent<FDCheckZone3>();
        dice1 = GameObject.Find("dice").GetComponent<DiceScript1>();
        player1PointCalculation = new int[5];
        rundenPunktzahl = 0;


    }



    public void calculatePoints()
    {




        buttonScript.aktuelleRunde = 0;

    }

    private void getDiceValuesEachRound()
    {
        if (trigger1.snapped == true && trigger2.snapped == true && trigger3.snapped == true)
        {

            player1PointCalculation[buttonScript.aktuelleRunde] = trigger1.get_DiceNumber() + trigger2.get_DiceNumber() + trigger3.get_DiceNumber();

        }
        else
        {
            player1PointCalculation[buttonScript.aktuelleRunde] = 0;
        }
    }





    // Update is called once per frame
    void Update()
    {
        player1Wuerfelversuche.text = buttonScript.wuerfelversuche + " Würfelversuche";

        if (buttonScript.aktuelleRunde == 3)
        {
            gameIsOver = true;
            calculatePoints();
            player1Points.text = "Paul";
            roundView.text = "Runde 1";
        }

        if (buttonScript.aktuelleRunde == 1)
        {
            roundView.text = "Runde 2";
        }
        else if (buttonScript.aktuelleRunde == 2)
        {
            roundView.text = "Runde 3";
        }




        if (buttonScript.aktuelleRunde == 0 && buttonScript.wuerfelversuche == 0)
        {

            getDiceValuesEachRound();
            player1Points.text = "Paul " + player1PointCalculation[0];

        }

        if (buttonScript.aktuelleRunde == 1 && buttonScript.wuerfelversuche == 0)
        {

            getDiceValuesEachRound();
            player1Points.text = "Paul " + player1PointCalculation[0] + " " + player1PointCalculation[1];


        }

        if (buttonScript.aktuelleRunde == 2 && buttonScript.wuerfelversuche == 0)
        {

            getDiceValuesEachRound();
            player1Points.text = "Paul " + player1PointCalculation[0] + " " + player1PointCalculation[1] + " " + player1PointCalculation[2];

        }

    }
}
