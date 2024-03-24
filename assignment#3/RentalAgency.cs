using System;
// RentalAgency.cs
using System;

public class RentalAgency
{
    // Array to store vehicles
    private Vehicle[] Fleet { get; set; }
    public double TotalRevenue { get; private set; }

    // Constructor
    public RentalAgency(int capacity)
    {
        Fleet = new Vehicle[capacity];
    }

    // Method to add vehicle to fleet
    public void AddVehicle(Vehicle vehicle, int index)
    {
        if (index >= 0 && index < Fleet.Length)
        {
            Fleet[index] = vehicle;
        }
        else
        {
            Console.WriteLine("Invalid index. Vehicle not added to fleet.");
        }
    }

    // Method to remove vehicle from fleet
    public void RemoveVehicle(int index)
    {
        if (index >= 0 && index < Fleet.Length)
        {
            Fleet[index] = null;
        }
        else
        {
            Console.WriteLine("Invalid index. No vehicle removed from fleet.");
        }
    }

    // Method to rent a vehicle
    public void RentVehicle(int index)
    {
        if (index >= 0 && index < Fleet.Length && Fleet[index] != null)
        {
            TotalRevenue += Fleet[index].RentalPrice;
            Fleet[index] = null;
            Console.WriteLine("Vehicle rented successfully.");
        }
        else
        {
            Console.WriteLine("Invalid index or no vehicle available at specified index.");
        }
    }
}
