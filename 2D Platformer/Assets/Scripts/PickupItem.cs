using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public enum PickupType {key};
    public PickupType currentPickup;
    public int pickupAmount;
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        //Finds PlayerController script
        playerController = GameObject.Find("PlayerCharacter").GetComponent<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("PlayerCharacter")) //finds object with "key" tag
        {
            if(currentPickup == PickupType.key)
            {
                playerController.key = pickupAmount;
            }
            Destroy(gameObject); //destroys object
        }
    }
    
}
