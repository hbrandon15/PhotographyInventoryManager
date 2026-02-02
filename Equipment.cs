public class Equipment
{
    // Properties of the Equipment class
    public string Type { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public string Location { get; set; }
    public int ID { get; set; } // Unique identifier for the equipment

    public Equipment() // Constructor
    {
        Console.WriteLine("Equipment created.");
        Type = "Generic Equipment";
        Name = "Unnamed Equipment";
        Manufacturer = "Unknown Manufacturer";
        Description = "No description available.";
        Quantity = 0;
        Location = "Unspecified Location";

    }

    public void createEquipment()
    {
        Console.WriteLine("Creating equipment...");
        // Implementation for creating equipment
        Console.WriteLine("What type of equipment do you want to add?");
        var Type = Console.ReadLine();
        Console.WriteLine("What is the name of the equipment?");
        var Name = Console.ReadLine();
        Console.WriteLine("Who is the manufacturer of the equipment?");
        var Manufacturer = Console.ReadLine();
        Console.WriteLine("Provide a brief description of the equipment:");
        var Description = Console.ReadLine();
        Console.WriteLine("How many units of this equipment are available?");
        var QuantityInput = Console.ReadLine();
        Console.WriteLine("Where is the equipment located?");
        var Location = Console.ReadLine();
        Console.WriteLine("Equipment created.");
    }
}
