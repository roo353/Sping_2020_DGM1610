using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{

    public int sceneToLoad;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Boss"))
        {
            Destroy(GameObject.FindWithTag("Boss"));
        }

        SceneManager.LoadScene(sceneToLoad);
    }
}
