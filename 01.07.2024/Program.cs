using System;


namespace _01._07._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW bmw = new BMW("BMW", "Sedan", "M3", "Red", "100000m", 52225, 2030);
            Console.WriteLine("Car Type: " + bmw.Type);

            Console.WriteLine("Car Information: " + bmw.InformationCar());

            Console.WriteLine(bmw.StartEngine());

            Console.WriteLine(bmw.StopEngine());

            Console.WriteLine("Car Make: " + bmw.Make);
        }
    }
}
