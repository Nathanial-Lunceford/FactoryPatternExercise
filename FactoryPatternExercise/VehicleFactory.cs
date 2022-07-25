using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public class VehicleFactory
    {
        static public IVehicle GetVehicle(string tires)
        {
            if(tires == "4")
            {
                Car newCar = new Car();
                return newCar;
            }
            else if(tires == "2")
            {
                Motorcycle newMotorcycle = new Motorcycle();
                return newMotorcycle;
            }
            else
            {
                Car newCar = new Car();
                return newCar;
            }
        }
    }
}
