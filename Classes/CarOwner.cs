using System.Collections.Generic;

namespace Classes
{
    public class CarOwner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Vehicle> Vehicles { get; set; } = new list<vehicle>();

        public CarOwner(int id, string name)
        {
            Vehicles = new List<Vehicle>();
            
            id = id;
            name = name;

            
        }
    }
}
