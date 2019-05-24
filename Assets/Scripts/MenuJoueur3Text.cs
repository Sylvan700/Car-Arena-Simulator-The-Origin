using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuJoueur3Text : MonoBehaviour
{
    // Un Script par joueur ??? 

    public Text personnageText; 

    void Start()
    {
        


    }



    void Update()
    {

        personnageText.text = Manager.nomPersoPlayer3;

    }
}
