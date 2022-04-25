using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //dont forget to add

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;
    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad); //loads scene
    }

    public void QuitGame()
    {
        Application.Quit(); //quits game
        Debug.Log("Scared huh?"); //prints that you have quit
    }
}
