using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{

    [Header("For Loops")]
    public int numEwoks = 20;
    public int numCows = 15;
    public int numCrabs = 10;
    public int numPigeons = 5;
    public int numCrows = 3;

    [Header("While Loops")]
    public int ducksInPond = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        for(int i = 1; i <= numEwoks; i++) //counts up, will loop till max set ewoks
        {
            Debug.Log("There are " + i + " Ewoks on a log."); //i is number
        }

        for(int i = 0; i <= numCows; i++)
        {
            Debug.Log("There are " + i + " dancing cows");
        }

        for(int i = 10; i >= numCrabs; i--)
        {
            Debug.Log("There are " + i + " angry crabs");
        }

        for(int i = 0; i <= numPigeons; i++)
        {
            Debug.Log("There are " + i + " cooing pigeons");
        }

        for(int i = 1; i <= numCrows; i++)
        {
            Debug.Log("There are " + i + " crows attacking you");
        }
        

        while(ducksInPond > 0)
        {
            Debug.Log(ducksInPond);
            Debug.Log("All of the ducks have flown south for the winter");
            ducksInPond ++; //dont forget or else infinite loop ill occur
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
