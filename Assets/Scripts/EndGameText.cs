using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameText : MonoBehaviour
{

    // Basicaly, this script will look if the text have to change after each round
    // Then, it updates in order to synchronize with the timer

    public Text WinnerText; 

    void Start()
    {
        Manager.Main();
        WinnerText.text = Manager.WinnerPlayer;
    }


    void Update()
    {       
        WinnerText.text = Manager.WinnerPlayer;
    }
}
