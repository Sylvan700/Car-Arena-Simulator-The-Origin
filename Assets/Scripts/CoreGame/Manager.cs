using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Manager
{

    public static int scorePlayer1;
    public static int scorePlayer2;

    public static string nomPersoPlayer1;
    public static string nomPersoPlayer2;

    public static string WinnerPlayer;
    public static WaitForSecondsRealtime timeBetween2Rounds;
    public static WaitForSecondsRealtime timeCapacity;
    public static WaitForSecondsRealtime cooldown;

    // public static Dictionary<string, VehiculeTemplate> characters;

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

    //public static VehiculeTemplate PickCharacter(VehiculeTemplate vehicule)
    //{

    //    characters.Add("Sodic", vehicule);

    //    // characters.Add("loli Driver")

    //    vehicule.rotationForce = 90.0F;

    //    return vehicule;

    //}

}

