using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header ("Player Health")]
    public int curHP;
    public int maxHP;
    public HealthBar healthBar;

   
    [Header ("Player Movement")]
    public float moveSpeed = 5.0f; // Speed that player moves
    private Rigidbody2D rb; // Store referenced 2D rigidbody
    private Vector2 movement; // Store players x,y position movement
    private Vector2 direction;



    [Header ("Player Combat")]
    public float attackRange; // Range at which the player can attack
    public float attackRate;
    private float lastAttackTime;
    public LayerMask enemyLayer;


    [Header ("Inventory")]
    public int Key;
    public int Coins;
    public int Gems;

    
     // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        curHP = maxHP;
        healthBar.SetHealth(maxHP);

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // Inputs left right movement
        movement.y = Input.GetAxis("Vertical"); // Inputs up down movement

        if(Input.GetKeyDown(KeyCode.x))
        {
            if(Time.time - lastAttackTime >= attackRate)
                Attack();
        }
    }
    // Set number of calls per frame
    void FixedUpdate()
    {
        // Apply physics and move character
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

        UpdateDirection();
    }


    void UpdateDirection()
    {
        Vector2. vel = new Vector2(movement.x,movement.y);

        if(vel.magnitude != 0)
        {
            direction = vel;
        }

        rb.velocity = vel * moveSpeed;

    }

    void Attack()
    {
        lastAttackTime = Time.time;
        // Raycat using the enemyLayer

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);

        if(hit.collider != null)
        {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(damage);
        }
    }
    public void TakeDamage(int damage)
    {
        curHP -= damage;
        healthBar.SetHealth(curHP);

        if(curHP <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        Debug.Log("Player has bit the dust!");
    }
}


    