using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Speed that player moves
    private Rigidbody2D rb; // Store referenced 2D rigidbody
    Vector2 movement; // Store players x,y position movement

     // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // Inputs left right movement
        movement.y = Input.GetAxis("Vertical"); // Inputs up down movement

    }
    // Set number of calls per frame
    void FixedUpdate()
    {
        // Apply physics and move character
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }
}
