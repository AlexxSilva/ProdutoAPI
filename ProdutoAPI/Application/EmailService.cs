using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using System.Net;
using System.Net.Mail;

namespace ProdutoAPI.Application
{
    public class EmailService : IEmailService
    {
        public void Enviar(string para, string assunto, string corpo)
        {
            //var mensagem = new MailMessage();
            //mensagem.From = new MailAddress("email@gmail.com.br");
            //mensagem.To.Add(para);
            //mensagem.Subject = assunto;
            //mensagem.Body = corpo;
            //mensagem.IsBodyHtml = false;

            //var smtp = new SmtpClient("smtp.gmail.com", 587)
            //{
            //    Credentials = new NetworkCredential("email@gmail.com.br", "senha do email aqui"),
            //    EnableSsl = true
            //};
            //smtp.Send(mensagem); habilitar para envio
        }
    }
}

//https://myaccount.google.com/apppasswords
