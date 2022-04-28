using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    
    private Transform player;

    private Vector2 target;

    private PlayerController playerController;

    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("PlayerCharacter").GetComponent<Transform>();
        target = new Vector2(player.position.x, player.position.y);

        playerController = GameObject.Find("PlayerCharacter").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
{
    if(other.CompareTag("PlayerCharacter"))
    {
        DestroyProjectile(); 
        playerController.TakeDamage(damage);
    }
}
    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}