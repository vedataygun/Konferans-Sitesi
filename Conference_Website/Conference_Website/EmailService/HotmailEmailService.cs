using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using System;
using System.Security.Policy;
using System.Collections.Generic;

namespace Conference_Website.EmailService
{
    public class HotmailEmailService 
    {

        private string _host;
        private int _port;
        private bool _enableSSL;
        private string _username;
        private string _password;

        public HotmailEmailService(string host, int port, bool enableSSL, string username, string password)
        {
            _host = host;
            _port = port;    
            _enableSSL = enableSSL;
            _username = username;
            _password = password;

        }

        public Task SendEmailAsync(string email, string subject, string HtmlMessage,string FileName="")
        {
            var client = new SmtpClient(this._host, this._port)
            {
                Credentials = new NetworkCredential(_username, _password),
                EnableSsl = this._enableSSL,
                UseDefaultCredentials=false
            };

            

            var msg = new MailMessage(this._username, email, subject, HtmlMessage)
            {
                IsBodyHtml = true
            };

            if(!string.IsNullOrEmpty(FileName) )
            {
                System.Net.Mail.Attachment attachement;
                attachement = new System.Net.Mail.Attachment(FileName);
                msg.Attachments.Add(attachement);
            }
            


            return client.SendMailAsync(msg) ;
        }


        public async Task<int> SendVerificationCode(string email)
        {

            int VerificationCode = new Random().Next(100000, 999999);
            string subject = "Hesabınızı Onaylayın.";
           
            var HtmlMessage = $"<div style='color:white;'><h1 >Doğrulama Kodunuz</h1><p>Lütfen Doğrulama kodunu kimseyle paylaşmayın.</p><p style='color:red; font-size:35px;'>{VerificationCode}</p></div>";
            await SendEmailAsync(email, subject, HtmlMessage);

            return VerificationCode;
        }

        public async Task SendCertification(string email,string filePath)
        {

            string subject = "Katılım Sertifikası.";
            var HtmlMessage = $"<div style='color:white;'><h1 >Katılım Sertifikası</h1></div>";
            await SendEmailAsync(email, subject, HtmlMessage, filePath);

        }
    }
}
