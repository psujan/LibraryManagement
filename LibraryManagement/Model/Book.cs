using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    public class Book
    {
        
        public int Id {get; set; }
        public String Name { get; set; }

        public String Author { get; set; }
        public String Category { get; set; }

        public int PublishedYear { get; set; }

        public int Pages {  get; set; }

        public override string ToString()
        {
            return $"Id:{Id}\tName: {Name} \tAuthor: {Author} \tCategory: {Category}\tPublished Year: {PublishedYear}\tPages: {Pages}";
        }


    }
}
