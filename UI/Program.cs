using System;
using BusinessLogic;
using Models;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Garage Management System");

            // Sample usage
            var bl = new GarageBusinessLogic();

            // Add an owner
            bl.AddOwner("John Doe");

            // Add a vehicle to the owner
            var vehicle = new Vehicle { Description = "Sedan", LicensePlate = "AB-123-CD" };
            bl.AddVehicle("John Doe", vehicle);

            // Modify a license plate
            bl.ModifyLicensePlate(vehicle, "AB-12-34");

            // View all owners and vehicles
            bl.ViewOwnersAndVehicles();

            // Delete a vehicle
            bl.DeleteVehicle("John Doe", vehicle);
        }
    }
}
