using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToSpawn : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        var spawnPoint = GameObject.Find("Spawn"); //seaches for spawn object

        if(spawnPoint == null)
        {
            Debug.Log("Spawn not found");
        }

        collider2D.gameObject.transform.position = spawnPoint.transform.position; //teleports player to Spawn
    }
}
