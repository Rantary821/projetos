using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; 
using System.Net.Mail;


namespace TesteEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void email_send()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("otavio.marques1120@gmail.com");
            mail.To.Add("otavio.marques20@hotmail.com");
            mail.Subject = "Test Mail - 1";
            mail.Body = "aeee carvalho" + "\n" + "Eru Iluvatar";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(@"C:\Fotos\Perfil\1.png");
            mail.Attachments.Add(attachment);
            attachment = new System.Net.Mail.Attachment(@"C:\Fotos\Perfil\2.png");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("otavio.marques1120@gmail.com", "Tpm8Fzx20N11OT");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            email_send();
        }
    }
}
