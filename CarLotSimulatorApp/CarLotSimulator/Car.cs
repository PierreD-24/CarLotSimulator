using System;
using System.Collections.Generic;

public class Car
{
    public int year;
    public string make;
    public string model;
    public string engineNoise;
    public string honkNoise;
    public bool IsDriveable;

    public Car()
    {

    }

     public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
    {
        this.year = year;
        this.make = make;
        this.model = model;
        this.engineNoise = engineNoise;
        this.honkNoise = honkNoise;
        this.IsDriveable = isDriveable;
    }

    public void MakeEngineNoise()
    {
        Console.WriteLine(engineNoise);
    }

    public void MakeHonkNoise()
    {
        Console.WriteLine(honkNoise);
    }
}