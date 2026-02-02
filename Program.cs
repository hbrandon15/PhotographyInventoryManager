using System.Text.Json;
class Program
{
    static void Main(string[] args)
    {

        List<Equipment> equipmentList = new List<Equipment>();
        while (true)
        {
            Console.WriteLine("Do you want to add new equipment? (yes/no)\n");
            string addNewEquipment = Console.ReadLine().ToLower();
            if (addNewEquipment == "yes")
            {
                Console.WriteLine("Please select the numbered option for the equipment you would like to add:\n");
                Console.WriteLine("1.Camera\n2.Lens\n3.Generic");
                int equipmentSelection = Convert.ToInt32(Console.ReadLine());
                switch (equipmentSelection)
                {
                    case 1:
                        equipmentList.Add(new Camera());
                        break;
                    case 2:
                        equipmentList.Add(new Lens());
                        break;
                    case 3:
                        equipmentList.Add(new Equipment());
                        break;
                    default:
                        equipmentList.Add(new Equipment());
                        break;
                }
            }
            else if (addNewEquipment == "no")
            {
                break;
            }

        }

        string fileName = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "equipmentData.json");
        string jsonString = JsonSerializer.Serialize(equipmentList);
        File.WriteAllText(fileName, jsonString);

        Console.WriteLine(File.ReadAllText(fileName));


    }
}
