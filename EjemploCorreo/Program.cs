using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCorreo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"c:\prueba\archivo.pdf";

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("me@mydomain.com");
            mail.To.Add("u@urdomain.com");
            mail.Subject = filename;
            mail.Body = "Report";
            Attachment attachment = new Attachment(filename);
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 25;
            SmtpServer.Credentials = new System.Net.NetworkCredential("me", "password");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
