using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDM
{
    public class DiceRollerModel
    {

        public string name { get; set; }
        public int id { get; set; }
        public int D2Amount { get; set; }
        public int D4Amount { get; set; }
        public int D6Amount { get; set; }
        public int D8Amount { get; set; }
        public int D10Amount { get; set; }
        public int D12Amount { get; set; }
        public int D20Amount { get; set; }
        public int D100Amount { get; set; }
        public int D2Mod { get; set; }
        public int D4Mod { get; set; }
        public int D6Mod { get; set; }
        public int D8Mod { get; set; }
        public int D10Mod { get; set; }
        public int D12Mod { get; set; }
        public int D20Mod { get; set; }
        public int D100Mod { get; set; }

        public string ToString()
        {
            return name;
        }
    }
}
