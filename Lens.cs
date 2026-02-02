public class Lens : Equipment
{
    public string FocalLength { get; set; }
    public string LowestAperture { get; set; }
    public string MountType { get; set; }

    public Lens() // Constructor
    {
        Type = "Lens";
        FocalLength = "Unknown";
        LowestAperture = "Unknown";
        MountType = "Unknown";
        CreateLens();
    }

    public void CreateLens()
    {
        createEquipment(); // Call base class method to create common equipment properties
        Console.WriteLine("Enter the focal length of the lens (e.g., 50mm):");
        FocalLength = Console.ReadLine();
        Console.WriteLine("Enter the lowest aperture of the lens (e.g., f/1.8):");
        LowestAperture = Console.ReadLine();
        Console.WriteLine("Enter the mount type of the lens (e.g., Canon EF, Nikon F):");
        MountType = Console.ReadLine();
        Console.WriteLine("Lens created with specific properties.");
    }

    public void ViewLens()
    {
        viewEquipment(); // Call base class method to view common equipment properties
        Console.WriteLine($"Focal Length: {FocalLength}");
        Console.WriteLine($"Lowest Aperture: {LowestAperture}");
        Console.WriteLine($"Mount Type: {MountType}");
    }
}

