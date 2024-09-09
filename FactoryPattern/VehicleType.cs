using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleType : IVehicle
    {
        public VehicleType()
        {
            
        }

        public void Drive()
        {
            Console.WriteLine("I am Driving a three wheeler");
            Console.WriteLine("vroooooooom");
        }
    }
}
