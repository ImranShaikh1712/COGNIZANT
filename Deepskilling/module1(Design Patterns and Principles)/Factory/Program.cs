using System;

interface IVehicle
{
    void Drive();
}

class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Car Running");
    }
}

class VehicleFactory
{
    public static IVehicle GetVehicle()
    {
        return new Car();
    }
}

class Program
{
    static void Main()
    {
        IVehicle v = VehicleFactory.GetVehicle();
        v.Drive();
    }
}
