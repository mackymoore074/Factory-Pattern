using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType)
            {
                case "Car":
                    return new Car();
                case "Motorcycle":
                    return new Motorcycle();
                case "VehicleType":
                        return new VehicleType();
                default:
                    return new Car();
            }
        }
    }
}
