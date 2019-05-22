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

    }


    void Update()
    {

        ResetTheGame();

    }


    // Optimized for events
    // Destruction of vehicule when it leaves the arena 
    private void OnTriggerExit2D(Collider2D collision)
    {

        AddPointsAndReset(collision);

        // A timer after a victory
        Manager.timeBetween2Rounds = new WaitForSecondsRealtime(timeBetween2Rounds);

    }

    public static void AddPointsAndReset(Collider2D collision)
    {

        // Add scores if a player fall => Later, it will also do it for HP, not inside this function tho
        if (collision.CompareTag("PlayerOne"))
        {
            Manager.scorePlayer2 += 1;
        }
        else
        {
            Manager.scorePlayer1 += 1;
        }

        // Jusque là le plus simple pour réinitialiser les positions. A voir les contraintes       

        // Reset the scene after each point
        SceneManager.LoadScene(0);

        // A timer after a victory
        // Manager.timeBetween2Rounds = new WaitForSecondsRealtime(timeBetween2Rounds);


    }


    /// <summary>
    /// Look at scores and wait many seconds before restarting the game
    /// </summary>
    private void ResetTheGame()
    {

        if ((Manager.scorePlayer1 >= numberOfRounds || Manager.scorePlayer2 >= numberOfRounds) && !Manager.timeBetween2Rounds.keepWaiting)
        {
            Manager.scorePlayer1 = 0;
            Manager.scorePlayer2 = 0;

            Manager.WinnerPlayer = "";

            SceneManager.LoadScene(0);

        }
    }


}
