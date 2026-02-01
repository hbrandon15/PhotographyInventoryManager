using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var equipment = new Equipment()
        {
            Type = "Laptop",
            Name = "Dell XPS 13",
            Manufacturer = "Dell",
            Description = "A high-end laptop for professionals.",
            Quantity = 10,
            Location = "Warehouse A",
            ID = 1
        };

        string jsonString = JsonSerializer.Serialize(equipment);
        Console.WriteLine(jsonString);

    }
}
