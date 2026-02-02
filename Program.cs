class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var equipment1 = new Equipment();
        equipment1.createEquipment();
        equipment1.viewEquipment();

        //string jsonString = JsonSerializer.Serialize(equipment);
        //Console.WriteLine(jsonString);

    }
}
