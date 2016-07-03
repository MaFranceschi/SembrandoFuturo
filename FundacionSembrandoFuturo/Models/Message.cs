using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FundacionSembrandoFuturo.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}