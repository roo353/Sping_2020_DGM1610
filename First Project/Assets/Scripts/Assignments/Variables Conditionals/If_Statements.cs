using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statements : MonoBehaviour
{
    //public string lightColor;

    //public string weather;

    //public string hairColor;

    //public int age;

    //public string emotion;

    public int legalAge;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       /*
        if(lightColor == "Red")
        {
            Debug.Log("The light is "+ lightColor +" STOP!!!!");
        }   
        else if(lightColor == "Yellow")
        {
            Debug.Log("The light is "+ lightColor +" Start to stop or clean intersection");
        }
        else if(lightColor == "Green")
        {
            Debug.Log("The light is "+ lightColor +" You can GO!!");
        }
        else
        {
            Debug.Log("Wrong color!");
        }
        */

        /*
        if(weather == "Rain" || weather == "Snow")
        {
            Debug.Log("The weather is bad, you should wear a coat!");
        }
        else if(weather == "Sunny"|| weather == "Partly Cloudy")
        {
            Debug.Log("You do not need a coat!");
        }
        */

        /*
        if(hairColor == "Red" && age == 6)
        {
            Debug.Log("You can ride the Merry Go Round");
        }
        else if(hairColor == "Blonde" && age == 100)
        {
            Debug.Log("You can ride the Fire Dragon!");
        }
        */

        /*
        if(emotion == "Sad" || emotion == "Sick")
        {
            Debug.Log("Give your friend a hug");
        }
        else if(emotion == "Happy" || emotion == "excited")
        {
            Debug.Log("Smile and laugh with your friend");
        }
        */

        if(legalAge == 21)
        {
            Debug.Log("You can legally drink alcohol in the US!!");
        }
        else if(legalAge = 18)
        {
            Debug.Log("You can legally drink alcohol in the UK!!");
        }

    }
}
