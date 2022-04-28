using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{

    public PlayerController player;

    [Header("Health")]
    public int curHP;
    public int maxHP;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerCharacter").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage;

        if(curHP <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
