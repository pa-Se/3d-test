using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceNumberTextScript1 : MonoBehaviour {

	Text text;
	public static int diceNumber1;
	public static int diceNumber2;

	public static int diceNumber3;

	public static int diceNumber4;

	public static int diceNumber5;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {

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
