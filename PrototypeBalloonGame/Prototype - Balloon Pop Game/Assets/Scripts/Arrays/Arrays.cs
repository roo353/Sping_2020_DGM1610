using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public string[] friendNames = {"Bob", "Jessica", "Jody", "Arthur", "Randall", "Todd", "Becky"};
    // array                      {0, 1, 2, 3, 4, 5, 6} starts at 0 not 1

    public int[] numbers = {23,46,77,10,42,98,63,81};
    
    public string[] bigCats = {"Lion", "Cheetah", "Panther", "Tiger", "Leopard"};

    public string[] birds = {"Pigeon", "Chicken", "Canary", "Wood Pecker", "Eagle", "Swan", "Emu"};

    public string[] bears = {"Black Bears", "Brown Bears", "Sun Bears", "Panda Bears"};

    public string[] flowers = {"Rose", "Tulip", "Lily", "Sun flower"};

    public string[] marvelHeroes = {"Captain America", "Hawk Eye", "Captain Marvel", "Iron Man", "Black Panther"};

    public string[] dcHeroes = {"Batman", "Flash", "Wonder Woman", "Wolverine"};

    public string[] candy = {"KitKat", "Snickers", "Smarties", "Milky Way", "Jolley Rancher"};

    public string[] games = {"Witcher 3", "Life is Strange", "Sally Face", "Dying Light 2"};
     
    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log("Former friend " + friendNames[0]);
        Debug.Log(friendNames[3]+" says hi as he walks past");
        friendNames[0] = "Veronica";
        Debug.Log("New friend " + friendNames[0]);
        */

        /*
            foreach(int numbers in numbers)
        {
            print(numbers);
        }
        */

        Debug.Log(bigCats[2] + "s are actually really good at swimming.");

        Debug.Log("My favorite bird is the " + birds[0] + ".");

        Debug.Log(bears[2] + " are the smallest bear species.");

        Debug.Log("Did you know that " + flowers[3] + "s always face the sun?");

        Debug.Log("My favorite marvel super hero is " + marvelHeroes[4] + ".");

        Debug.Log("I think " + dcHeroes[0] + " is super cool.");

        Debug.Log("I think " + candy[0] + " are overrated." );

        Debug.Log("I am obsessed with " + games[3] + " right now.");
    
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }

}

