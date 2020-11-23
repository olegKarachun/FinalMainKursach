using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Diagnostics;
using System.Threading.Tasks;


namespace WebPWrecover.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration configuration;
        public EmailSender(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public async Task SendEmailAsync(string email, string subject, string message)
        {           
            string key = Environment.GetEnvironmentVariable("gridKey");
            await Execute(key, subject, message, email);            
        }

        public async Task Execute(string apiKey, string subject, string message, string email)
        {            
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("commezg@gmail.com", "Oleg"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email));
            msg.SetClickTracking(false, false);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
