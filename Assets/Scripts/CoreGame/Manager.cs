using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Manager
{

    public static int scorePlayer1;
    public static int scorePlayer2;
    public static string WinnerPlayer;
    public static WaitForSecondsRealtime timeBetween2Rounds;


    // It should change, could be modulable with more variables
    public static void Main()
    {

        if (scorePlayer1 == 3)
        {
            WinnerPlayer = "Player 1 won";
        }
        if (scorePlayer2 == 3)
        {
            WinnerPlayer = "Player 2 won";
        }

    }

}

