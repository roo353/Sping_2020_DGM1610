using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("PlayerCharacter").GetComponent<PlayerController>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("PlayerCharacter") && playerController.key == 1)
        {
            Destroy(gameObject);
        }
    }
}
