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




    Text text;
    Text player1Points;
    Text roundView;
    public static int diceNumber1;
    public static int diceNumber2;

    public static int diceNumber3;

    public static int diceNumber4;

    public static int diceNumber5;

    public static int[] player1PointCalculation;

    public int rundenAnzahlGesamt;
    public int rundenAnzahl;






    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        player1Points = GameObject.Find("player1").GetComponent<Text>();
        roundView = GameObject.Find("roundOverview").GetComponent<Text>();

        trigger1 = GameObject.Find("FDiceZone1").GetComponent<FDCheckZone1>();
        trigger2 = GameObject.Find("FDiceZone2").GetComponent<FDCheckZone2>();
        trigger3 = GameObject.Find("FDiceZone3").GetComponent<FDCheckZone3>();
        dice1 = GameObject.Find("dice").GetComponent<DiceScript1>();
        player1PointCalculation = new int[5];
        this.rundenAnzahlGesamt = 5;
        this.rundenAnzahl = 0;

    }


    public void pointCalculation(int rundenAnz)
    {
        this.rundenAnzahl = rundenAnz;

        if (trigger1.snapped == true && trigger2.snapped == true && trigger3.snapped == true)
        {

            player1PointCalculation[rundenAnz] = trigger1.get_DiceNumber() + trigger2.get_DiceNumber() + trigger3.get_DiceNumber();


            if (rundenAnz == 0)
            {
                player1Points.text = "Paul " + player1PointCalculation[0].ToString() + " ";

                Debug.Log("Runde1" + player1Points.text);
            }
            else if (rundenAnz == 1)
            {
                player1Points.text = player1Points.text + player1PointCalculation[1].ToString() + " ";

                Debug.Log("Runde2" + player1Points.text);

            }
            else if (rundenAnz == 2)
            {
                Debug.Log("Runde3" + player1Points.text);

                player1Points.text = player1Points.text + player1PointCalculation[2].ToString() + " ";
                //player1Points.text = "Paul " + player1PointCalculation[0].ToString() + " " + player1PointCalculation[1].ToString() + " " + player1PointCalculation[2].ToString();

            }
            else if (rundenAnz == 3)
            {

                player1Points.text = "Paul " + player1PointCalculation[0].ToString() + " " + player1PointCalculation[1].ToString() + " " + player1PointCalculation[2].ToString() + " " + player1PointCalculation[3].ToString();

            }
            else if (rundenAnz == 4)
            {

                player1Points.text = "Paul " + player1PointCalculation[0].ToString() + " " + player1PointCalculation[1].ToString() + " " + player1PointCalculation[2].ToString() + " " + player1PointCalculation[3].ToString() + " " + player1PointCalculation[4].ToString(); ;
            }


        }
        else if (trigger1.snapped == false | trigger2.snapped == false | trigger3.snapped == false)
        {
            player1PointCalculation[rundenAnz] = 0;

        }


    }



    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.rundenAnzahl);
        if (rundenAnzahl == 0)
        {


            roundView.text = "Runde 1";

        }
        else if (rundenAnzahl == 1)
        {

            roundView.text = "Runde 2";


        }
        else if (rundenAnzahl == 2)
        {

            roundView.text = "Runde 3";


        }
        else if (rundenAnzahl == 3)
        {
            roundView.text = "Runde 4";


        }
        else if (rundenAnzahl == 4)
        {
            roundView.text = "Runde 5";
        }




        if (text.name == "Text")
        {
            text.text = diceNumber1.ToString();
        }

        if (text.name == "Text2")
        {
            text.text = diceNumber2.ToString();
        }

        if (text.name == "Text3")
        {
            text.text = diceNumber3.ToString();
        }

        if (text.name == "Text4")
        {
            text.text = diceNumber4.ToString();
        }

        if (text.name == "Text5")
        {
            text.text = diceNumber5.ToString();
        }
    }
}
