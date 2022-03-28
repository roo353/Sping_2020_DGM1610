using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public string npcConv;
  //public int socialClass = 1;

    void Start()
    {
        switch (npcConv)
        {
            case "Hello":
             print("Hello good citizen! May the blessings be with you");
            break;

            case "Goodbye":
             print("Goobye! Safe travels.");
            break;

            case "We are being attacked":
             print("You run away in shame you coward.");
            break;


        }

        switch (socialClass)
        {
            case 5:
            Debug.Log("Hello, your Majesty!");
            break;

            case 4:
            Debug.Log("Hello my princess");
            break;

            case 3:
            Debug.Log("Good morning my Lord");
            break;

            case 2:
            Debug.Log("Hello, Mayor!");
            break;

            case 1:
            Debug.Log("May I purchase some goods?");
            break;

            case 0:
            Debug.Log("Shoo you peasant!");
            break;

            default:
            Debug.Log("I do not speech with strangers");

        }
    
    }  

      /*if()    //switches are a less messy and easier way than nesting else if statements
        {
            if()
            {
                if()
                {

                }
            }
        }*/

}
