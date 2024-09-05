namespace Classes
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string LicensePlate { get; set; }

        public Vehicle(int id, string description, string licenseplate)
        {
            Id = id;
            Description = description;
            LicensePlate = licenseplate;
        }
    }
}
