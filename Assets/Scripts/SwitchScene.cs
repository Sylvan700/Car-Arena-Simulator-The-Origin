using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void Update()
    {


        Scene scene = SceneManager.GetActiveScene();

        {
            // Si la scène se nomme SampleScene, le fait d'appuiyer sur "M" change de scène, et vice versa.
            if (scene.name == "SampleScene")
            {
                // Show a button to allow scene2 to be switched to.
                if (Input.GetKeyDown(KeyCode.M))
                {
                    SceneManager.LoadScene("4PlayersScene");
                    Debug.Log("change pour scène 4");
                }
            }
            else
            {
                // Show a button to allow scene1 to be returned to.
                if (Input.GetKeyDown(KeyCode.M))
                {
                    SceneManager.LoadScene("SampleScene");
                    Debug.Log("change pour scène 1");
                }
            }
        }
    }
}
