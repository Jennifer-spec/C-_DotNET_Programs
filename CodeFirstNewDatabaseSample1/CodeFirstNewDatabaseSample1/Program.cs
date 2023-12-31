﻿using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CodeFirstNewDatabaseSample1
{
    class Program
    {

        static void Main(string[] args)
        {

            using (var db = new BloggingContext())
            {
                //Create school database and save a new student in Students table
                Console.Write("Enter a name for a new Bolg: ");
                var name = Console.ReadLine();

                var student = new Blog { Name = name };
                db.Blogs.Add(student);
                db.SaveChanges();

                //Display all Blogs from the database
                // var query = from b in db.Blogs
                //           orderby b.Name
                //            select b;
                //var query = from b in db.Blogs orderby b.Name select b;

                //Console.WriteLine("All blogs in the database:");
                //foreach (var item in query)
                //{
                //    Console.WriteLine(item.Name);
                //}

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }    
    }
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public virtual List<Post> Posts { get; set; }

    }
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Context { get; set; }

        public int BlogId { get; set; }
        //public int Virtual Blog Blog { get; set; }

    }

    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}
