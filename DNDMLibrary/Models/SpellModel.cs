﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDMLibrary.Models
{
    class SpellModel
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public int school_id { get; set; }
        public int lvl { get; set; }
        public string casting_time { get; set; }
        public string range { get; set; }
        public string components { get; set; }
        public string duration { get; set; }

        public string descr { get; set; }


        public string ToString()
        {
            return name;
        }


    }
}