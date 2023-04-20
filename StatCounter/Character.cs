using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatCounter
{
    public class Character
    {
        public List<string> MainSets { get; set; }
        public List<string> AltSets { get; set; }
        public List<string> SubSets { get; set; }
        public List<string> PerfectStats { get; set; }
        public List<string> GoodStats { get; set; }
        public List<string> OkStats { get; set; }
        //public string[][] MainStats { get; set; }
        public List<string> ClockStats { get; set; }
        public List<string> GobletStats { get; set; }
        public List<string> CrownStats { get; set; }


        public double First { get; set; }
        public double Second { get; set; }
        public double Third { get; set; }

        public string Name { get; set; }
    }
}
