using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuJoueursText : MonoBehaviour
{
    // Un Script par joueur ??? 

    public Text personnageText; 

    void Start()
    {

        // personnageText.text = "coucou";
        personnageText.text = Manager.nomPersoPlayer1;

    }



    void Update()
    {
        
    }
}
