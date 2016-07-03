using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FundacionSembrandoFuturo.Models
{
    public class ContextInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            
            //context.Sessions.Add(
            //        new Session()
            //        {
            //            Title = "I want some food",
            //            Abstract = "Bla bla bla",
            //            Speaker = context.Speakers.Add(
            //                new Speaker()
            //                {
            //                    Name = "Marco Franceschi",
            //                    EmailAddress = "marcofranceschi@hotmail.com"
            //                })
            //        });

            context.SaveChanges();
        }
    }
}