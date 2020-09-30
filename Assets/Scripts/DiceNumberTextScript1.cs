using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceNumberTextScript1 : MonoBehaviour {

	Text text;
	public static int diceNumber1;
	public static int diceNumber2;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
			if (text.name == "Text")
		{
			//für die erste Text Box
			text.text = diceNumber1.ToString();
		}
		if (text.name == "Text2")
		{
			text.text = diceNumber2.ToString();
		}
	}
}
