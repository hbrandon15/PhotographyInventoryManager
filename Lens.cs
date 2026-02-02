public class Lens : Equipment
{
    public string FocalLength { get; set; }
    public string LowestAperture { get; set; }
    public string MountType { get; set; }

    public Lens() // Constructor
    {
        Console.WriteLine("Lens created.");
    }
}

