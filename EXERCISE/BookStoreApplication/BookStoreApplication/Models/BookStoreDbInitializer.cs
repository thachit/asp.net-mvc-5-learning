using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookStoreApplication.Models
{
    public class BookStoreDbInitializer : DropCreateDatabaseAlways<BookStoreDB>
    {
        protected override void Seed(BookStoreDB context)
        {
            context.Authors.Add(new Author
            {
                Name = "Thach Nguyen",
                Email = "nguyencothach1989@gmail.com",
                Phone = "0906654208",
                Description = "Author of many books about Python, C#"
            });

            context.Authors.Add(new Author
            {
                Name = "Thao Nguyen",
                Email = "whylove119236@gmail.com",
                Phone = "01213379851",
                Description = "Author of many books about marketing"
            });

            context.Genres.Add(new Genre 
            {
                Name = "Programming"
            });
            context.Genres.Add(new Genre
            {
                Name = "Web Application"
            });
            context.Genres.Add(new Genre
            {
                Name = "Marketing"
            });

            context.Books.Add(new Book
            {
                Title = "Twisted Framework",
                DateRelease = DateTime.Parse("2/20/2012"),
                Author = new Author
                {
                    Name = "Phuc Nguyen",
                    Email = "phuc.nguyen@gmail.com",
                    Phone = "012133722851",
                    Description = "Author of many books about technical"
                },
                Genre = new Genre { Name = "Networking" },
                Price = 99,
                Publish = true,
                Description = "Book teach about network programming using Twisted Framework"
                
            });

            context.Books.Add(new Book
            {
                Title = "Sale More",
                DateRelease = DateTime.Parse("1/22/2013"),
                Author = new Author
                {
                    Name = "Dung Nguyen",
                    Email = "dung.nguyen@gmail.com",
                    Phone = "012133722851",
                    Description = "Author of many books about marketing"
                },
                Genre = new Genre { Name = "Sale" },
                Price = 99,
                Publish = true,
                Description = "Book teach about how to sale more product"

            });

            base.Seed(context);
        }
    }
}