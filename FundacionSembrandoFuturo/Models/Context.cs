using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FundacionSembrandoFuturo.Models
{
    public class Context : DbContext
    {
        DbSet<Person> Persons { get; set; }
        DbSet<Message> Messages { get; set; }
    }
}