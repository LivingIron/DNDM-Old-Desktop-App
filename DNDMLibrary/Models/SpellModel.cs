using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DNDMLibrary.Models
{
    public class SpellModel
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

        public bool Validate()
        {
            bool isCorrect = false;

            if(!name.Equals("") && !casting_time.Equals("") && !range.Equals("") && !components.Equals("") && !duration.Equals("") && !descr.Equals("") )
            {
                Debug.WriteLine(name);
                Debug.WriteLine(casting_time);
                Debug.WriteLine(range);
                Debug.WriteLine(components);
                Debug.WriteLine(duration);
                Debug.WriteLine(descr);


                isCorrect = true;
            }

            Debug.WriteLine(name);
            Debug.WriteLine(casting_time);
            Debug.WriteLine(range);
            Debug.WriteLine(components);
            Debug.WriteLine(duration);
            Debug.WriteLine(descr);

            return isCorrect;
        }


    }
}
