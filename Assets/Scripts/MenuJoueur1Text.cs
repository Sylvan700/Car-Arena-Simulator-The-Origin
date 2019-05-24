using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuJoueur1Text : MonoBehaviour
{

    public Text personnageText;

    void Start()
    {



    }



    void Update()
    {

        personnageText.text = Manager.nomPersoPlayer1;

    }
}
