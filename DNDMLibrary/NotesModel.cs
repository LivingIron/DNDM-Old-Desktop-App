using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDMLibrary
{
    public class NotesModel
     {

     
        public int id { get; set; }

        public string title { get; set; }
        public string descr { get; set; }

        public string ToString()
        {
            return title+"\n"+descr;
        }
    }
}
