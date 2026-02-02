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
        Type = "Generic Equipment";
        Name = "Unnamed Equipment";
        Manufacturer = "Unknown Manufacturer";
        Description = "No description available.";
        Quantity = 0;
        Location = "Unspecified Location";

    }

    public void createEquipment()
    {
        // Implementation for creating equipment
        Console.WriteLine("Creating equipment...");
        Console.WriteLine("What type of equipment do you want to add?");
        Type = Console.ReadLine();
        Console.WriteLine("What is the name of the equipment?");
        Name = Console.ReadLine();
        Console.WriteLine("Who is the manufacturer of the equipment?");
        Manufacturer = Console.ReadLine();
        Console.WriteLine("Provide a brief description of the equipment:");
        Description = Console.ReadLine();
        Console.WriteLine("How many units of this equipment are available?");
        int intTemp = Convert.ToInt32(Console.ReadLine());
        Quantity = intTemp;
        Console.WriteLine("Where is the equipment located?");
        Location = Console.ReadLine();
        Console.WriteLine("Equipment created.");
    }

    public void viewEquipment()
    {
        Console.WriteLine("Viewing equipment details...");
        // Implementation for viewing equipment details
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Location: {Location}");
    }
}
