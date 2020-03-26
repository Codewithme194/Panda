using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PandaBook.Models
{
    public class Genere
    {
        public virtual int GenereId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
   
}