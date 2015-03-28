using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStoreApplication.Models
{
    public class Book
    {
        public virtual int ID { get; set; }

        public virtual byte[] Image { get; set; }

        public virtual string Title { get; set; }

        public virtual string BookUrl { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd/MM/yyyy}")]
        public virtual DateTime DateRelease { get; set; }

        public virtual bool Publish { get; set; }

        public virtual string Description { get; set; }

        public virtual decimal Price { get; set; }       
 
        public virtual int AuthorId { get; set; }

        public virtual int GenreId { get; set; }

        public virtual Author Author { get; set; }

        public virtual Genre Genre { get; set; }
    }
}