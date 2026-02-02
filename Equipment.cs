public class Equipment
{
    // Properties of the Equipment class
    public int ID { get; set; }
    private static int _nextID = 1;
    public string Type { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public string Location { get; set; }


    public Equipment() // Constructor
    {
        ID = _nextID;
        _nextID++;
        Type = "Generic Equipment";
        Name = "Unnamed Equipment";
        Manufacturer = "Unknown Manufacturer";
        Description = "No description available.";
        Quantity = 0;
        Location = "Unspecified Location";

    }

    public void createEquipment()
    {
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
        Console.WriteLine($"{Type} created successfully!\n");
    }

    public void viewEquipment()
    {
        Console.WriteLine("Viewing equipment details...\n");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Location: {Location}");
    }
}
