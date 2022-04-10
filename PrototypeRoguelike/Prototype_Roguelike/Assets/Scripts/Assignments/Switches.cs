/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public string npcConv;
    public int socialClass = 1;
    public int pickingPets;
    public string favoriteColor;
    public float playerLevels;
    public string friendConv;
    public int emotions;
    public float food;
    public int dinnerConv;

    public string teacherConv;

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

        switch (pickingPets)
        {
            case 4:
            Debug.Log("I want the parrot");
            break;

            case 3:
            Debug.Log("I want the dog");
            break;

            case 2:
            Debug.Log("I want the cat");
            break;

            case 1:
            Debug.Log("I want the snake");
            break;

            case 0:
            Debug.Log("I want the spider");
            break;

            default:
            Debug.Log("I dont want any. Too much work to take care of.");
        }

        switch (favoriteColor)
        {
            case "Do you like green?":
            print("Yes I love green");
            break;

            case "Do you like blue?":
            print("Yes I love blue");
            break;

            case "Do you like red?":
            print("Yes I love red");
            break;

            default:
            print("I do not like that color");
        }

        switch (playerLevels)
        {
            case 4.0f:
            Debug.Log("You have reached level 4, you can now unlock dragon armor");
            break;

            case 3.0f:
            Debug.Log("You have reached level 3, you can now access the magic library");
            break;

            case 2.0f:
            Debug.Log("You have reached level 2, you may now equip rare items");
            break;

            case 1.0f:
            Debug.Log("You have reached level 1, you may now speak to other players");
            break;

            case 0.0f:
            Debug.Log("You must level up to gain access to better items");
            break;
        }

        switch (friendConv)
        {
            case "Hey! How have you been?":
             print("Ive been great, thank you.");
            break;

            case "See you later!":
             print("Cant wait!");
            break;

            case "Anything od note happen recently?":
             print("Nah not really");
            break;

            case "Would you like some snacks?"
             print("Of course!");
            break;
        }

        switch (emotions)
        {
            case 3:
            Debug.Log("You are feeling angry");
            break;

            case 2:
            Debug.Log("You are feelind sad");
            break;

            case 1:
            Debug.Log("You are feeling happy");
            break;

            case 0:
            Debug.Log("You are excited");
            break;

            default:
            Debug.Log("You are in a neutral mood");
        }

         switch (food)
        {
            case 4.0f:
            Debug.Log("You have chosen the ramen");
            break;

            case 3.0f:
            Debug.Log("You have chosen the mac and cheese");
            break;

            case 2.0f:
            Debug.Log("You have chosen the burger");
            break;

            case 1.0f:
            Debug.Log("You have chosen the taco");
            break;
        }

        switch (dinnerConv)
        {
            case 3:
            print("You and your family talk about the day");
            break;

            case 2:
            print("You and your family compliment the food");
            break;

            case 1:
            print("You and your family argue");
            break;

            case 0:
            print("You and your family sit in silence");
        }

        switch (teacherConv)
        {
            case "Have you done your homework?":
             print("Yes");
            break;

            case "May I use the restroom?":
             print("Yes you may");
            break;

            case "Please stop talking among yourselfs":
             print("the class becomes quiet");
            break;

            case "This assignemt is due next monday":
             print("Yes maam");
            break;
        }
    }  

        if()    //switches are a less messy and easier way than nesting else if statements
        {
            if()
            {
                if()
                {

                }
            }
        }

}
*/