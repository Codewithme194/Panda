using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PandaBook.Models
{
    public class Book
    {

        public virtual int BookId { get; set; }
        public virtual string BookName { get; set; }
        public virtual DateTime DatePublished { get; set; }

       

        public virtual string Author { get; set; }

        public virtual string ISBN { get; set; }

        public virtual string ShortDescription { get; set; }

        public virtual int GenereId { get; set; }
        public virtual Genere Genere { get; set; }
    }
}