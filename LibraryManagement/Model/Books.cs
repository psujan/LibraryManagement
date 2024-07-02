using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    public class Books
    {
        
        public int Id {get; set; }
        public String Name { get; set; }

        public String Author { get; set; }
        public String Category { get; set; }

        public int PublishedYear { get; set; }

        public int Pages {  get; set; }


    }
}
