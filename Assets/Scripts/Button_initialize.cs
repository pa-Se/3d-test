using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Button_initialize : MonoBehaviour
{
    public UnityEngine.UI.Button button_shuffle;
    public UnityEngine.UI.Button button_reset;

    public int wuerfelversuche;


    void Awake()
    {
        button_shuffle = GameObject.Find("button_shuffle").GetComponent<UnityEngine.UI.Button>();
        button_shuffle.onClick.AddListener(Button_onClick);
        

    }



    void Button_onClick()
    {

        SceneManager.LoadScene("GameScene");
    }



}
