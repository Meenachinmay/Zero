using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuuto_VPA_Virtual_Private_Assistant_
{
    class Weather_Info
    {
        public class Coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }

        }

        public class main
        {
            public double temparature { get; set; }
            public double temp_max { get; set; }
            public double temp_min { get; set; }
            public double pressure { get; set; }

            public double humidity { get; set; }
        }

        public class wind
        {
            public double speed { get; set; }
        }

        public class clouds
        {
            public int all { get; set; }
        }

        public class sys
        {
            public string country { get; set; }
        }

        public class root
        {
            public string name { get; set; }
            public sys sys { get; set; }
            public double dt { get; set; }
            public wind wind { get; set; }

            public clouds clouds { get; set; }
            //public weather weather { get; set; }
            public main main { get; set; }
            public List<weather> weather { get; set; }
            public Coord coordinate { get; set; }
        }
    }
}
