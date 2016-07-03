using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FundacionSembrandoFuturo.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual List<Message> Messages { get; set; } 
    }
}