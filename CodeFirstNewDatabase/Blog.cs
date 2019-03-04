using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNewDatabase
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }

        // Add additional property 
        public string Url { get; set; }
        // Navigational Property : The foreign key contents
        // Lazy loading technique : automatically populate the contents of this property
        public virtual  List<Post> Posts { get; set; }

        public override string ToString()
        {
            return $"Name:{Name}, Url:{Url}";
        }
    }
}
