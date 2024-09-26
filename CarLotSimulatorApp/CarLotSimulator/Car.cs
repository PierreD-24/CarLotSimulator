using System;
using System.Collections.Generic;

public class Car
{
    public int year{ get; set; }
    public string make{ get; set; }
    public string model{ get; set; }
    public string engineNoise{ get; set; }
    public string honkNoise{ get; set; }
    public bool IsDriveable{ get; set; }

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