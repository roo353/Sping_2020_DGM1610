using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int damage = 1;
    public PlayerController player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerCharacter").GetComponent<PlayerController>();
    }

}
