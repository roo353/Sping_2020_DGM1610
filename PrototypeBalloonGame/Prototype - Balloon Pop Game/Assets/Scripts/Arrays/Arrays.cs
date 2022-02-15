using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public string[] friendNames = {"Bob", "Jessica", "Jody", "Arthur", "Randall", "Todd", "Becky"};
    // array                      {0, 1, 2, 3, 4, 5, 6} starts at 0 not 1

    public int[] numbers = {23,46,77,10,42,98,63,81};
    
    public string[] bigCats = {"Lion", "Cheetah", "Panther", "Tiger", "Leopard"};

    
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
