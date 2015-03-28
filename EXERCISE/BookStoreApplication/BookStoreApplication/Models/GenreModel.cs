using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BookStoreApplication.Models
{
    public class Genre
    {
        [DisplayName("Genre")]
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}