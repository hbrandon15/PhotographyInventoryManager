using System.Text.Json;
class Program
{
    static void Main(string[] args)
    {
        //var equipment1 = new Equipment();
        //equipment1.createEquipment();
        //equipment1.viewEquipment();
        List<Equipment> equipmentList = new List<Equipment>();
        var camera1 = new Camera();
        camera1.CreateCamera();
        equipmentList.Add(camera1);
        var equipment2 = new Equipment();
        equipmentList.Add(equipment2);

        //foreach (var equipment in equipmentList)
        //{
        //    equipment.viewEquipment();
        //}

        string fileName = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "equipmentData.json");
        string jsonString = JsonSerializer.Serialize(equipmentList);
        File.WriteAllText(fileName, jsonString);

        Console.WriteLine(File.ReadAllText(fileName));


    }
}
