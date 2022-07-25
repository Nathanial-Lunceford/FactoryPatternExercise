using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("You are driving a motorcycle.");
        }
    }
}
