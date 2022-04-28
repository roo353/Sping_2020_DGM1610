using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouDiedMenu : MonoBehaviour
{
    public int sceneToLoad;

    public void RestartGame()
    {
        SceneManager.LoadScene(sceneToLoad); //loads scene
    }

    public void QuitGame()
    {
        Application.Quit(); //quits game
        Debug.Log("Scared huh?"); //prints that you have quit
    }
}
