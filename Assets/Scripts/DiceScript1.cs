using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript1 : MonoBehaviour {

	static Rigidbody rb;
	public static Vector3 diceVelocity;





	// Use this for initialization
	public void Start () {


			rb = GetComponent<Rigidbody> ();
	

			DiceNumberTextScript1.diceNumber1 = 0;
		DiceNumberTextScript1.diceNumber2 = 0;
		float dirX = Random.Range (0, 500);
			float dirY = Random.Range (0, 500);
			float dirZ = Random.Range (0, 500);
			transform.position = new Vector3 (Random.Range(0,5), Random.Range(0, 5), Random.Range(0, 5));
			transform.rotation = Quaternion.identity;
			rb.AddForce (transform.up * 500);
			rb.AddTorque (dirX, dirY, dirZ);
		
	}
}
