using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    public float speed;
    public float distance;

    private bool moveRight = true;

    public Transform groundDetection;

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime keeps the movement speed consistent
        //Move the enemy to the right
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        //pointing ray down to detect the floor
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);

        //checks for edge
        if(groundInfo.collider == false)
        {
            //checks we are moving right
            if(moveRight == true)
            {
                //flip enemy at edge to move left
                transform.eulerAngles = new Vector3(0, -180, 0);
                moveRight = false;
            }
            else
            {
                //flip enemy at edge to move right
                transform.eulerAngles = new Vector3(0, 0, 0);
                moveRight = true;
            }
        }
    }
}
