using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public enum PickupType {Key, Coin, Gem};
    public PickupType currentPickup;
    public int pickupQuantity;

    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
       playerController = GameObject.Find("Player").GetComponent<playerController>();

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(currentPickup == PickupType.Key)
            {
                playerController.Key = pickupAmount;

                Debug.Log("You have picked up a Golden Key");
            }
            else if(currentPickup == PickupType.Coin)
            {
                playerController.Coins += pickupAmount;
                
                Debug.Log("You have picked up "+ pickupAmount +" Coins");
            }
            else if(currentPickup == PickupType.Gem)
            {
                playerController.Gems += pickupAmount;

                Debug.Log("You have picked up "+ pickupAmount +" Gems");
            }
            Destroy(gameObject);
        }
    }
}
