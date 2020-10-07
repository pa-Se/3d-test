using System.Collections;
//using System;
//using System.Diagnostics;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
    
    public GameObject dice;
    public GameObject child;

    public Collider col;
     
    
    // Start is called before the first frame update
    void Start()
    {
      
        
        dice = GameObject.FindWithTag("diceone");
       
        child = dice.transform.GetChild(1).gameObject;
  
        
    transform.position = new Vector3(-4.89f,0.02f,0.84f);
       

        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(child.name == col.gameObject.name) //test
        {
            if((dice.transform.position.x < -4.2f &&  dice.transform.position.x > -5.45f) && (dice.transform.position.y < 1.0f &&  dice.transform.position.y > 0)&&(dice.transform.position.z < 1.35f &&  dice.transform.position.z > 0.12f))
            {

             set_position();

            }
        }



    }

    void set_position()
    {
            dice.transform.position = new Vector3(-4.85f,0.4f,0.8f);
            dice.transform.Rotate(dice.transform.rotation.x, 0.81f, dice.transform.rotation.z, Space.World);

            //dice.transform.rotation = Quaternion.Euler(dice.transform.rotation.x,90,dice.transform.rotation.z);

    
    }

   void OnTriggerStay(Collider col)
	{

            if (col.transform.parent != null)
            {
                
			var  diceName= col.transform.parent.gameObject.name;

            Debug.Log(col.transform.parent.gameObject.name);
            Debug.Log(col.transform.gameObject.name);


            }
                
		
    }
    	


}
