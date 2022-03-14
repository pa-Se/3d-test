using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuEnterName : MonoBehaviour
{

    //public GameObject inputField;
    public TMP_InputField inputField1;
    string text, text2;


    private void Start()
    {
        text = inputField1.GetComponent<TMP_InputField>().text;

        DontDestroyOnLoad(this.gameObject);



    }


    public string GetName()
    {
        return inputField1.GetComponent<TMP_InputField>().text + " ";
    }


}
