using System.Text.Json;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //var equipment1 = new Equipment();
        //equipment1.createEquipment();
        //equipment1.viewEquipment();
        List<Equipment> equipmentList = new List<Equipment>();
        var camera1 = new Camera();
        camera1.CreateCamera();
        equipmentList.Add(camera1);

        foreach (var equipment in equipmentList)
        {
            equipment.viewEquipment();
        }



        string jsonString = JsonSerializer.Serialize(equipmentList);
        Console.WriteLine(jsonString);

    }
}
