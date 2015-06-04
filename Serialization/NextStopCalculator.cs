using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class NextStopCalculator
    {
        public int StopsInterval { get; set; }

        public BusStop CalculateNextBusStop(BusStop currentBusStop)
        {
            Console.Out.WriteLine("I'm just a method to calculate the next bus stop. The object that contains me shouldn't be serialized.");
            return new BusStop();
        }
    }
}
