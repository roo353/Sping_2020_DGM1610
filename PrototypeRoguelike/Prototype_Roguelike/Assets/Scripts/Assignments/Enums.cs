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

    enum HairColor {blonde, ginger, brown, black, gray};
    enum EyeColor {blue, hazel, brown, green};
    enum Gender {woman, man, nonBinary, transWoman, transMan};
    enum Accesories {glasses, hat, braces, necklace, backpack,};
    enum Pet {cat, dog, turtle, bird, lizard, spider, snake};
    enum SkinTone {white, mediumBrown, olive, brown, darkBrown};
    enum Expression {happy, angry, sad, excited, listless, resting};

    // Start is called before the first frame update
    async void Start()
    {

        HairColor hair;
        EyeColor eyes;
        Gender gender;
        Accesories addition;
        Pet companion;
        SkinTone skin;
        Expression look;

        hair = HairColor.brown;
        eyes = EyeColor.green;
        gender = Gender.woman;
        addition = Accesories.glasses;
        companion = Pet.dog;
        skin = SkinTone.white;
        look = Expression.listless;

        print("Your new charcter has " + hair + " hair and " + eyes + " eyes. They are a " + skin + gender + " with a pet " + companion + ". They wear " + addition + " and always have a " + look + " expression.");


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
