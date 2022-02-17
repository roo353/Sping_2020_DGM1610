using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{

    public int scoreToGive = 100; // points balloons are worth
    
    public int clicksToPop = 3; // how many clicks till balloon pops
    
    public float scaleToIncrease = 0.10f; // how much the balloon scales per click

    public ScoreManager scoreManager; // A variable to reference the ScoreManager

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        // reduces clicksToPop by 1 per click
        clicksToPop -= 1; 

        //increases scale of balloon per click by one
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clicksToPop == 0)
        {
            scoreManager.IncreaseScoreText(scoreToGive);
            Destroy(gameObject);
        }
        
    }
}
