// See https://aka.ms/new-console-template for more information
using System;
using FactoryPatternExercise;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many tires do you want your vehicle to have? Write 2 for " +
            "motorcycle, 4 for car, anything else will give you a car.");

        IVehicle vehicle = VehicleFactory.GetVehicle(Console.ReadLine());

        vehicle.Drive();
    }
}