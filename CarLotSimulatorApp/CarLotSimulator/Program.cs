﻿using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot carLot = new CarLot();

            Car firstCar = new Car()
            {
                year = 2020,
                make = "Ford",
                model = "Mustang",
                engineNoise = "VROOOM",
                honkNoise = "HONKHONK",
                IsDriveable = true
            };


            Car secondCar = new Car();
            secondCar.year = 2003;
            secondCar.make = "Toyota";
            secondCar.model = "Corolla";
            secondCar.engineNoise = "zoom";
            secondCar.honkNoise = "beep";
            secondCar.IsDriveable = false;
            CarLot.numberOfCars++;

            Car thirdCar = new Car(2024, "Lamborghini", "Aventador", "ZOOMZOOM", "HOOOOOONK", true);


            firstCar.MakeEngineNoise();
            secondCar.MakeEngineNoise();
            thirdCar.MakeEngineNoise();

            firstCar.MakeHonkNoise();
            secondCar.MakeHonkNoise();
            thirdCar.MakeHonkNoise();

            carLot.carList.Add(firstCar);
            carLot.carList.Add(secondCar);
            carLot.carList.Add(thirdCar);

            foreach (var car in carLot.carList)
            {
                Console.WriteLine($"Year: {car.year}, Make: {car.make}, Model: {car.model}");
            }
            Console.WriteLine($"Number of Cars in the lot is {CarLot.numberOfCars}");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            

        }
    }
}
