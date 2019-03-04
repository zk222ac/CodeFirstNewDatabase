using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNewDatabase
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        // Navigational Property
        // Enable lazy loading property 
        public virtual Blog Blog { get; set; }

        public override string ToString()
        {
            return $"Title:{Title}, Content:{Content}, BlogName:{Blog.Name}";
        }
    }
}
