using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class ScoreManager : MonoBehaviour
{
    public int score; // Keep track of the score
    public TextMeshProUGUI scoreText; // Text object to be modified

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    public void IncreaseScoreText(int amount) // pass info to variable
    {
        score += amount; // adds to score
        UpdateScoreText();
    }
     public void DecreaseScoreText(int amount) // pass info to variable
    {
        score -= amount; // decreases score
        UpdateScoreText();
    }
    public void UpdateScoreText()
    {
        scoreText.text = "Score: "+ score;
    }

}
