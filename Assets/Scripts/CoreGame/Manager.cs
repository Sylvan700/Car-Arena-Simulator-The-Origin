using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Manager
{

    public static int scorePlayer1 = 3;
    public static int scorePlayer2 = 3;
    public static int scorePlayer3 = 3;
    public static int scorePlayer4 = 3;

    public static string nomPersoPlayer1;
    public static string nomPersoPlayer2;
    public static string nomPersoPlayer3;
    public static string nomPersoPlayer4;

    public static List<string> MesJoueurs = new List<string>();

    public static string WinnerPlayer;

    public static WaitForSecondsRealtime timeBetween2Rounds;

    // public static Dictionary<string, VehiculeTemplate> characters;

    // It should change, could be modulable with more variables
    public static void Main()
    {

        //if (scorePlayer1 == 0)
        //{
        //    WinnerPlayer = "Player 1 lose";
        //}
        //if (scorePlayer2 == 0)
        //{
        //    WinnerPlayer = "Player 2 lose";
        //}
        //if (scorePlayer3 == 0)
        //{
        //    WinnerPlayer = "Player 3 lose";
        //}
        //if (scorePlayer4 == 0)
        //{
        //    WinnerPlayer = "Player 4 lose";
        //}

        if (MesJoueurs.Count == 1)
            WinnerPlayer = MesJoueurs[0] + " won";



    }

    //public static void MenuChoix()
    //{


    //}

    //public static VehiculeTemplate PickCharacter(VehiculeTemplate vehicule)
    //{

    //    characters.Add("Sodic", vehicule);

    //    // characters.Add("loli Driver")

    //    vehicule.rotationForce = 90.0F;

    //    return vehicule;

    //}

}

