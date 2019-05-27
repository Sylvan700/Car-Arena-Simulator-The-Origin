using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText2 : MonoBehaviour
{

    public Text labelScore;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        labelScore.text = "Player Three " + Manager.scorePlayer3.ToString() + " - " + Manager.scorePlayer4.ToString() + " Player Four";

    }
}
