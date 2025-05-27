using System;
using System.Net.Mail;
using System.Net;


namespace DAL_Catering
{
    public class EmailService
    {
        private SmtpClient _smtpServer;
        private MailMessage _mail;

        public EmailService()
        {
            _smtpServer = new SmtpClient("smtp.gmail.com");
            _smtpServer.Port = 587;
            _smtpServer.Credentials = new NetworkCredential("upetecnicasprogramacion@gmail.com", "zxvgkedvszpmrijp");
            _smtpServer.EnableSsl = true;
        }

        private void ArmarCorreo(string emailDestino, string asunto, string cuerpo)
        {       
            _mail = new MailMessage();
            _mail.From = new MailAddress("upetecnicasprogramacion@gmail.com");
            _mail.To.Add(emailDestino);
            _mail.Subject = asunto;
            _mail.Body = cuerpo;
        }

        public void EnviarMail(string emailDestino, string asunto, string cuerpo)
        {
            try
            {
                ArmarCorreo(emailDestino, asunto, cuerpo);
                _smtpServer.Send(_mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
