using System;
using System.Collections.Generic;
using System.Linq;


namespace CodeFirstNewDatabase
{
    class Program
    {
        private const string Value = "-------------------------------------------------------------------";

        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                // Display all Blog information 
                var allblogs = from b in db.Blogs
                    orderby b.Name
                    select b;
                Console.WriteLine(@"Display Blog Information");
                DisplayBlog(allblogs);

                //  Display all Blog information 
                var allPost = from b in db.Posts
                    orderby b.Title
                    select b;
                Console.WriteLine(@"Display Post Information");
                DisplayBlog(allPost);

                //Console.WriteLine(@"Enter New Name of blog.........");
                //var name = Console.ReadLine();
                //Console.WriteLine(@"Enter New Url of blog.........");
                //var url = Console.ReadLine();

                //var newBlog = new Blog(){Name = name, Url = url};
                //db.Blogs.Add(newBlog);
                //// for changes occur in db call the db.savechanes method
                //db.SaveChanges();
                //DisplayBlog(allblogs);

                Console.WriteLine(@"Enter the BlogId");
                var blogId = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                var updateBlog = db.Blogs.Where(d => d.BlogId == blogId);
                Console.WriteLine(updateBlog);

            }

            Console.ReadKey();
        }

        static void DisplayBlog(dynamic db)
        {
            
            foreach (var item in db)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Value);
        }
    }
}
