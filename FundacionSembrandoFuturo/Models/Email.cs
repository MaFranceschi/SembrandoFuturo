using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace FundacionSembrandoFuturo.Models
{
    public class Email
    {
        [Display(Name="Nombre")]
        public string Name { get; set; }
        [Display(Name="Correo electrónico")]
        public string Address { get; set; }
        [Display(Name="Título")]
        public string Subject { get; set; }
        [Display(Name="Mensaje")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        public static void SendingEmail(string Subject, string Content,string Address, string Name)
        {
            MailMessage Message = new MailMessage();
            Message.To.Add("");

            Message.Subject = Subject;
            Message.SubjectEncoding = System.Text.Encoding.UTF8;

            Message.Body = Name + ": " +"\n"+ Address  + "\n\n" + Content + " " ;
            Message.BodyEncoding = System.Text.Encoding.UTF8;
            Message.IsBodyHtml = false;

            Message.From = new MailAddress("");

            SmtpClient Client = new SmtpClient();

            Client.Credentials = new System.Net.NetworkCredential("", "");
            Client.Port = 587;
            Client.EnableSsl = true;

            Client.Host = "smtp.live.com";



            try
            {
                Client.Send(Message);
            }
            catch (System.Net.Mail.SmtpException ex)
            {

            }


        }
    }
}