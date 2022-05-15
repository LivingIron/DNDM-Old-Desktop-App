using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDMLibrary
{
    public class SchoolModel
    {
        public string name { get; set; }
        public int id { get; set; }
        
        public string ToString()
        {
            return name;
        }
    }
}
