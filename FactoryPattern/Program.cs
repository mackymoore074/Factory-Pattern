namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of Vehicle you like");
            string vehicleType = Console.ReadLine();
            var vehicle = VehicleFactory.GetVehicle(vehicleType);
            vehicle.Drive();
        }
    }
}
