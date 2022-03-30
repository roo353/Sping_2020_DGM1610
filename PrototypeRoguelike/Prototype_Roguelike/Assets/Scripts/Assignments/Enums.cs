using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
    /*
    enum Color {blue, red, yellow, green, orange, purple}; //can be in or outside of class
    enum CarMake {Oldsmobile, Chevrolet, Ford, Masda, Toyota, Dodge, Jeep};
    enum CarModel {Alero, Cruze ,Tacoma, Mustang, Miata, Viper, Cherokee}
    */

    // Start is called before the first frame update
    void Start()
    {
        /*
        Color paint; 
        paint = Color.red;

        Debug.Log(paint);
        

        CarMake make;
        make = CarMake.Jeep;

        CarModel model;
        model = CarModel.Cherokee;

        Debug.Log("Car Manufacture:" + make + " Model:" + model);

        Recall(CarMake.Masda, CarModel.Miata);
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    void Recall(CarMake make, CarModel model)
    {
        /*if(make == CarMake.Oldsmobile && model == CarModel.Alero)
        {
            print("There is a recall on your vehicle due to a faulty ignition.");
        }
        else if(make == CarMake.Ford && model == CarModel.Mustang)
        {
            print("There os a recall on all Mustangs for being too cool.");
        }
        else
        {
            print("There is no recall notice for your vehicle.");
        }       
    }
    */
}
