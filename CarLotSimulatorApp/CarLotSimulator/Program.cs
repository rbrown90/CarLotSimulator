﻿using System;
using System.Collections.Generic;

namespace CarLotSimulator;

  class Program
  {
     static void Main(string[] args)
     {

        Car myCar = new Car();
        myCar.Year = 2018;
        myCar.Make = "Aston Martin";
        myCar.Model = "V12 Vantage";
        myCar.EngineNoise = "Loud";
        myCar.HunkNoise = "weird...weird ";
        myCar.IsDrivable = true;

        var Ferrari = new Car()
        {
            Year = 2008,
            Make = "Ferrari",
            Model = "430 Scuderia",
            EngineNoise = "Boisterous",
            HunkNoise = "low...hunk",
            IsDrivable = false,
        };

        var Ford = new Car(2020, "Ford", "GT", "rambunctious", "squeky... squek", true);

        Ferrari.MakeEngineNoise(Ferrari.EngineNoise);
        myCar.MakeEngineNoise(myCar.EngineNoise);
        Ford.MakeEngineNoise(Ford.EngineNoise);

        Ferrari.MakeHunkNoise(Ferrari.HunkNoise);
        myCar.MakeHunkNoise(myCar.HunkNoise);
        Ford.MakeHunkNoise(Ford.HunkNoise);

        var carList = new List<Car>() { myCar, Ferrari, Ford };

        foreach (var vehicle in carList)
        {
            Console.WriteLine($"{vehicle.Year},{vehicle.Make},{vehicle.Model}");
        }

        Console.WriteLine($"numbers of cars: {CarLot.numberOfCars}");

        


        //TODO

        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property


        //Now that the Car class is created we can instanciate 3 new cars
        //Set the properties for each of the cars
        //Call each of the methods for each car

        //*************BONUS*************//

        // Set the properties utilizing the 3 different ways we learned about, one way for each car

        //*************BONUS X 2*************//

        //Create a CarLot class
        //It should have at least one property: a List of cars
        //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
        //At the end iterate through the list printing each of car's Year, Make, and Model to the console
     }
  }