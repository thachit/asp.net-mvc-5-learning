using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BookStoreApplication.Models
{
    public class Author
    {
        [DisplayName("Author")]
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Email { get; set; }
        public virtual string Description { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}