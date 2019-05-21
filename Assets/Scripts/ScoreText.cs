using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{

    public Text labelScore;

    void Start()
    {       

    }


    void Update()
    {

        labelScore.text = "Player One " + Manager.scorePlayer1.ToString() + " - " + Manager.scorePlayer2.ToString() + " Player Two";

    }
}
