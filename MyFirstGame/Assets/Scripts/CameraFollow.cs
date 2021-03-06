using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject player;
    
    private Vector3 offset = new Vector3(0,2,-4);

    // Update is called once per frame
    void Update()
    {
        // match the cameras position to player (follow player)
       transform.position = player.transform.position + offset;
    }
}
