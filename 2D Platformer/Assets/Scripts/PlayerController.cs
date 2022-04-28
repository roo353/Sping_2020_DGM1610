using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [Header("PlayerStats")]
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;

    [Header("GroundCheck")]
    private bool isGrounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private float moveVelocity;

    [Header("Sound")]
    private AudioSource source;
    public AudioClip soundEffect;
    public float volume = 1.0f;

    [Header("Key")]
    public int key;

    [Header("Health")]
    public int curHP;
    public int maxHP;
    public HealthBar healthBar;

    [Header("Attack")]
    public float attackRange; //range of attacking
    public float attackRate; //rate of attack
    private float lastAttackTime;
    public LayerMask enemyLayer;
    public int damage;
    private Vector2 direction;

    public int sceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
        //gets rigidbody for us
        isGrounded = true;
        rb = GetComponent<Rigidbody2D>();   

        source = GetComponent<AudioSource>();

        curHP = maxHP;
        healthBar.SetHealth(maxHP);
    }

    //FixedUpdate happens per certain ammount of frames
    void FixedUpdate() 
    {
        //Senses if grounded is true or false
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        //Non-Stick player
        moveVelocity = 0.0f;

        //assigns right movement to D
        if(Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
        }
        //assigns left movement to A
        if(Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }
        //Moves the character left and right
        rb.velocity = new Vector2(moveVelocity, rb.velocity.y);
    }

    void Update()
    {
         //checks for input from and assigns jump to space bar
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            if(Time.time - lastAttackTime >- attackRate)
            {
                Attack();
            }
        }
    }

    public void Jump()
    {
        //maintaining velocity on x and changing 
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight);

        source.PlayOneShot(soundEffect, volume);
    }

    void Attack()
    {
        lastAttackTime = Time.time;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);

        if(hit.collider != null)
        {
            hit.collider.GetComponent<Boss>()?.TakeDamage(damage);
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
      SceneManager.LoadScene(sceneToLoad);
    }
}
