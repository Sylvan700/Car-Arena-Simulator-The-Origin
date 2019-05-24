using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuJoueur2Text : MonoBehaviour
{

    public Text personnageText; 

    void Start()
    {
        


    }



    void Update()
    {

        personnageText.text = Manager.nomPersoPlayer2;

    }
}
