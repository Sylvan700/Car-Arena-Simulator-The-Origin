using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Arena : MonoBehaviour
{
    
    public int numberOfRounds = 3;
    public float timeBetween2Rounds = 3.0F;


    void Start()
    {
        Manager.MesJoueurs.Add("PlayerOne");
        Manager.MesJoueurs.Add("PlayerTwo");
        Manager.MesJoueurs.Add("PlayerThree");
    }


    void Update()
    {

        ResetTheGame();

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

        if (collision.CompareTag("PlayerOne"))
        {
            Manager.scorePlayer1 -= 1;
            Manager.MesJoueurs.Remove("PlayerOne");
        }
        if (collision.CompareTag("PlayerTwo"))
        {         
            Manager.scorePlayer2 -= 1;
            Manager.MesJoueurs.Remove("PlayerTwo");
        }
        if (collision.CompareTag("PlayerThree"))
        {
            Manager.scorePlayer3 -= 1;
            Manager.MesJoueurs.Remove("PlayerThree");

        }
        //if (collision.CompareTag("PlayerFour"))
        //{
        //    Manager.scorePlayer4 -= 1;
        //}


        // Reset the scene after each point

        if (Manager.MesJoueurs.Count == 1)
        {
            Manager.MesJoueurs.Clear();
            SceneManager.LoadScene(0);
            // Manager.MesJoueurs.Clear();

        }



    }


    /// <summary>
    /// Look at scores and wait many seconds before restarting the game
    /// </summary>
    private void ResetTheGame()
    {

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

        //if (!Manager.timeBetween2Rounds.keepWaiting)
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
