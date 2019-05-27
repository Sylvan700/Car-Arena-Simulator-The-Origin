using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Arena : MonoBehaviour
{
    
    public int numberOfRounds = 3;
    public float timeBetween2Rounds = 1.0F;
    public bool EndOfGame = false;

    //Scene scene = SceneManager.GetActiveScene();


    private void Start()
    {
        


    }


    void Update()
    {

        if (Manager.MesJoueurs.Count <= 0)
        {
            Manager.MesJoueurs.Add("PlayerOne");
            Manager.MesJoueurs.Add("PlayerTwo");
            Manager.MesJoueurs.Add("PlayerThree");
            Manager.MesJoueurs.Add("PlayerFour");
        }

        ResetTheGame();

        if (Manager.MesJoueurs.Count <= 1 && !EndOfGame)
        {
            ResetTheRound();
        }

    }


    // Optimized for events
    // Destruction of vehicule when it leaves the arena 
    private void OnTriggerExit2D(Collider2D collision)
    {

        Destroy(collision.gameObject);

        RemovePointsAndReset(collision);

        // A timer after a victory
        Manager.timeBetween2Rounds = new WaitForSecondsRealtime(timeBetween2Rounds);

    }

    public static void RemovePointsAndReset(Collider2D collision)
    {  

        if (collision.CompareTag("PlayerOne") && Manager.scorePlayer1 != 0)
        {
            Manager.scorePlayer1 -= 1;
            Manager.MesJoueurs.Remove("PlayerOne");
        }
        if (collision.CompareTag("PlayerTwo") && Manager.scorePlayer2 != 0)
        {         
            Manager.scorePlayer2 -= 1;
            Manager.MesJoueurs.Remove("PlayerTwo");
        }
        if (collision.CompareTag("PlayerThree") && Manager.scorePlayer3 != 0)
        {
            Manager.scorePlayer3 -= 1;
            Manager.MesJoueurs.Remove("PlayerThree");
        }
        if (collision.CompareTag("PlayerFour") && Manager.scorePlayer4 != 0)
        {
            Manager.scorePlayer4 -= 1;
            Manager.MesJoueurs.Remove("PlayerFour");
        }

    }

    public void ResetTheRound()
    {
        Scene scene = SceneManager.GetActiveScene();

        // Reset the scene
        Manager.MesJoueurs.Clear();

        if (scene.name == "SampleScene")
        {
            SceneManager.LoadScene("SampleScene");
        }
        else
        {
            SceneManager.LoadScene("4PlayersScene");
        }

    }


    /// <summary>
    /// Look at scores and wait many seconds before restarting the game
    /// </summary>
    private void ResetTheGame()
    {

        Scene scene = SceneManager.GetActiveScene();

        // A big K+U is necessary


        if (Manager.scorePlayer1 == 0 && Manager.scorePlayer2 == 0 && Manager.scorePlayer3 == 0)
        {
            Manager.WinnerPlayer = "Player 4 won";
            EndOfGame = true;
        }
        if (Manager.scorePlayer1 == 0 && Manager.scorePlayer2 == 0 && Manager.scorePlayer4 == 0)
        {
            Manager.WinnerPlayer = "Player 3 won";
            EndOfGame = true;
        }
        if (Manager.scorePlayer4 == 0 && Manager.scorePlayer3 == 0 && Manager.scorePlayer1 == 0)
        {
            Manager.WinnerPlayer = "Player 2 won";
            EndOfGame = true;
        }
        if (Manager.scorePlayer4 == 0 && Manager.scorePlayer2 == 0 && Manager.scorePlayer3 == 0)
        {
            Manager.WinnerPlayer = "Player 1 won";
            EndOfGame = true;
        }

        if(EndOfGame && !Manager.timeBetween2Rounds.keepWaiting)
        {
            Manager.scorePlayer1 = 3;
            Manager.scorePlayer2 = 3;
            Manager.scorePlayer3 = 3;
            Manager.scorePlayer4 = 3;

            Manager.WinnerPlayer = "";

            EndOfGame = false;

            if (scene.name == "SampleScene")
            {
                SceneManager.LoadScene("SampleScene");
            }
            else
            {
                SceneManager.LoadScene("4PlayersScene");
            }
            
        }


        /*(Manager.scorePlayer1 >= numberOfRounds || Manager.scorePlayer2 >= numberOfRounds)*/
        //if ((Manager.scorePlayer1 == 0 || Manager.scorePlayer2 == 0 || Manager.scorePlayer3 == 0 || Manager.scorePlayer4 == 0) && !Manager.timeBetween2Rounds.keepWaiting)
        //{

        //    Manager.scorePlayer1 = 3;
        //    Manager.scorePlayer2 = 3;
        //    Manager.scorePlayer3 = 3;
        //    Manager.scorePlayer4 = 3;

        //    Manager.WinnerPlayer = "";

        //    SceneManager.LoadScene(0);

        //}

    }


}
