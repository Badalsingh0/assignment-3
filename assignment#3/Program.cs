// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of vehicles
        Car car1 = new Car("Camry", "Toyota", 2020, 50.00, 5, "V6", "Automatic", false);
        Truck truck1 = new Truck("F-150", "Ford", 2018, 80.00, 2.5, "Pickup", true);
        Motorcycle bike1 = new Motorcycle("Ninja", "Kawasaki", 2019, 40.00, 1000, "Gasoline", true);

        // Display details of vehicles
        car1.DisplayDetails();
        Console.WriteLine();
        truck1.DisplayDetails();
        Console.WriteLine();
        bike1.DisplayDetails();
        Console.WriteLine();

        // Create a rental agency with a fleet capacity of 3
        RentalAgency agency = new RentalAgency(3);

        // Add vehicles to the agency's fleet
        agency.AddVehicle(car1, 0);
        agency.AddVehicle(truck1, 1);
        agency.AddVehicle(bike1, 2);

        // Rent a vehicle
        agency.RentVehicle(1);

        // Display total revenue of the agency
        Console.WriteLine($"Total Revenue: ${agency.TotalRevenue}");
    }
}

