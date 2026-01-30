// TODO: Setup JSON serialization for the Equipment class
// TODO: Add ID property to Equipment class
public class Equipment
{
    // Properties of the Equipment class
    public string Type { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public string Location { get; set; }

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
}
