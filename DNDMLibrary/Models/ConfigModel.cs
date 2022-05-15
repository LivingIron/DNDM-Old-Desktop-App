using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDMLibrary.Models
{
    class ConfigModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int state { get; set; }
 

        public string ToString()
        {
            return name;
        }
    }
}
