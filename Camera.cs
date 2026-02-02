public class Camera : Equipment
{

    public Camera() // Constructor
    {
        Type = "Camera";
        CreateCamera();


    }

    public void CreateCamera()
    {
        createEquipment(); // Call base class method to create common equipment properties
        Console.WriteLine("Camera created with specific properties.");
    }
    public void ViewCamera()
    {
        viewEquipment(); // Call base class method to view common equipment properties
    }
}
