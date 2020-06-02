using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Net.Mail;

namespace Infraestructura
{
    public class Email
    {
        private MailMessage email;

        private SmtpClient smtp;

        public Email()

        {

            smtp = new SmtpClient();

        }

        private void ConfigurarSmt()
        {
            smtp.Host = "smtp.gmail.com";

            smtp.Port = 587;

            smtp.EnableSsl = true;

            smtp.UseDefaultCredentials = false;

            smtp.Credentials = new System.Net.NetworkCredential("Veterinariaelarcapg@gmail.com",

            "Proyectopg");
        }

        private void ConfigurarEmail(Cliente cliente)
        {
            email = new MailMessage();

            email.To.Add(cliente.Correo);

            email.From = new MailAddress("Veterinarielarcapg@gmail.com");

            email.Subject = "Registro de Usuario "

            + DateTime.Now.ToString("dd/MMM/yyy hh:mm:ss");

            email.Body = $"<b>Sr {cliente.Nombre }</b> <br " +

            $" > se ha realizado su registro Sartisfactoriamente " +
            $"Envian: VeterinariaAsociados, lUIS ROCHA Y ANGEL CASADIEGOS";
            email.Attachments.Add(new Attachment(@"C:\Users\Rochety\Desktop\Funciones\Clientes.pdf"));

            email.IsBodyHtml = true;

            email.Priority = MailPriority.Normal;
        }

        public string EnviarEmail(Cliente cliente)
        {
            try
            {
                ConfigurarSmt();
                ConfigurarEmail(cliente);
                smtp.Send(email);
                return ("Correo enviado Satifactoriamente");
            }

            catch (Exception e)
            {
                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }



    }
}
