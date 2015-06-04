using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class BusStop
    {
        private string _location;
        private DateTime _time = DateTime.Now;

        public String Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }
    }
}
