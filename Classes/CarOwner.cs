using System.Collections.Generic;

namespace Classes
{
    public class CarOwner
    {
        public string Name { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public CarOwner()
        {
            Vehicles = new List<Vehicle>();
        }
    }
}
