using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class BusRoute
    {
        public string RouteNumber { get; set; }
        public BusStop Start { get; set; }
        public BusStop Stop { get; set; }

        [NonSerialized]
        private NextStopCalculator calc = new NextStopCalculator();

        public void updateCalcInterval()
        {
            // calc will be null after deserialization from binary.
            // But for XML serialization it will be created with new BusRoute object.
            if (calc == null) calc = new NextStopCalculator();

            calc.StopsInterval = 1337;
        }
    }
}
