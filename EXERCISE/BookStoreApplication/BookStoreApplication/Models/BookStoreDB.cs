using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookStoreApplication.Models
{
    public class BookStoreDB : DbContext
    {
        public BookStoreDB()
            : base("name=BookStoreDB")
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}