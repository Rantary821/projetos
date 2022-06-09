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
using System.IO;

namespace Menu_Principal
{
    public partial class Email : Form
    {
        Boolean first = false;
        string EmailPadrap, Senha;
        int Y, X;
        string path = @"C:\Dropbox\FisoBarretos\em.txt";

        public Email()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(label9_MouseDown);
            this.MouseMove += new MouseEventHandler(label9_MouseMove);
        }

        private void Email_Load(object sender, EventArgs e)
        {
            lbl1.Text = "As imagens selecionadas" + Environment.NewLine + "são enviadas como anexos" + Environment.NewLine + "automaticamente";

            if (!System.IO.File.Exists(path))
            {
                pnlEmailPadrao.Visible = true;
                pnlPrincipal.Visible = false;
                btnEnviar.Enabled = false;
                BtnChanceEmail.Enabled = false;
            }
            else
            {
                int counter = 0;
                string line;

                System.IO.StreamReader file = new System.IO.StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    if (counter == 0)
                    {
                        EmailPadrap = line;
                        txtEmailID.Text = line;
                    }
                    if (counter == 1)
                    {
                        Senha = line;
                        txtSenha.Text = line;
                    }
                    counter++;
                }
                file.Dispose();
            }
        }

        private void BtnChanceEmail_Click(object sender, EventArgs e)
        {
            pnlEmailPadrao.Visible = true;
            pnlPrincipal.Visible = false;
            btnEnviar.Enabled = false;
            lbl1.Visible = false;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (txtEmailID.Text != "" && txtSenha.Text != "")
            {
                EmailPadrap = txtEmailID.Text;
                Senha = txtSenha.Text;

                pnlPrincipal.Visible = true;
                pnlEmailPadrao.Visible = false;
                BtnChanceEmail.Enabled = true;
                lblErro.Visible = false;
                btnEnviar.Enabled = true;
                PassWord.Checked = false;

                File.Delete(path);

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(txtEmailID.Text);
                    sw.Dispose();
                }
                string senha = txtSenha.Text + Environment.NewLine;
                File.AppendAllText(path, senha, Encoding.UTF8);
                lbl1.Visible = true;
            }
            else
            {
                lblErro.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (TxtReceiver.Text != "" /*&& TxtSubject.Text != "" && TxtMensagem.Text != ""*/)
            {
                lblErro2.Visible = false;
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                SmtpServer.Timeout = 600000;
                mail.From = new MailAddress(EmailPadrap);
                mail.To.Add(TxtReceiver.Text);
                mail.Subject = TxtSubject.Text;
                mail.Body = TxtMensagem.Text;

                //int counter = 0;
                string line;
                string path = @"C:\Dropbox\FisoBarretos\Paths.txt";

                System.IO.StreamReader file = new System.IO.StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    System.Net.Mail.Attachment attachment;
                    attachment = new System.Net.Mail.Attachment(line);
                    mail.Attachments.Add(attachment);
                }
                file.Dispose();

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(EmailPadrap, Senha);
                SmtpServer.EnableSsl = true;

                MessageBox.Show("O envio pode demorar 1 minuto ou mais" + "\n" + "dependendo de sua conexão com a internet" + "\n" + "e a quantidade de documentos!");
                try
                {
                    SmtpServer.Send(mail);
                    MessageBox.Show("Enviado com sucesso!");
                    TxtReceiver.Text = "";
                    TxtSubject.Text = "";
                    TxtMensagem.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                    string campare = ex.ToString();//		 Learn more at\r\n   em System.Net.Mail.MailCommand.CheckResponse(SmtpStatusCode statusCode, String response)\r\n   em System.Net.Mail.MailCommand.Send(SmtpConnection conn, Byte[] command, MailAddress from, Boolean allowUnicode)\r\n   em System.Net.Mail.SmtpTransport.SendMail(MailAddress sender, MailAddressCollection recipients, String deliveryNotify, Boolean allowUnicode, SmtpFailedRecipientException& exception)\r\n   em System.Net.Mail.SmtpClient.Send(MailMessage message)\r\n   em Menu_Principal.Email.btnEnviar_Click(Object sender, EventArgs e) na C:\\Users\\otavi\\Desktop\\Gerenciado_de_Arquivo\\Menu_Principal\\Email.cs:linha 139"	string

                    
                    if (campare.Contains("System.Net.Mail.SmtpException: The SMTP server requires a secure connection or the client was not authenticated. The server response was: 5.5.1 Authentication Required."))
                    {
                        if(first == false)
                        {
                            MessageBox.Show("Email ou senha incorretos" + "\n" + "Verifique e tente novamente", "PassWord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            BtnChanceEmail_Click(sender, e);
                            PassWord.Checked = true;
                            first = true;
                        }
                        else
                        {
                            MessageBox.Show("Email ou senha incorretos" + "\n" + "Verifique e tente novamente", "PassWord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("Caso o problema persista vá a sua conta do gmail" + "\n" + "e ative a permissão a aplicativos menos seguros", "Permissões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            if (MessageBox.Show("Ir ao Gmail?", "Ativar Permissão", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                            {
                                System.Diagnostics.Process.Start("https://myaccount.google.com/lesssecureapps");
                            }
                            BtnChanceEmail_Click(sender, e);
                            PassWord.Checked = true;
                        }
                    }
                    else
                    if (campare.Contains("System.Net.Mail.SmtpException: O servidor SMTP requer uma conexão segura ou o cliente não foi autenticado. A resposta do servidor foi: 5.5.1 Authentication Required."))
                    {
                        if (first == false)
                        {
                            MessageBox.Show("Email ou senha incorretos" + "\n" + "Verifique e tente novamente", "PassWord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            BtnChanceEmail_Click(sender, e);
                            PassWord.Checked = true;
                            first = true;
                        }
                        else
                        {
                            MessageBox.Show("Email ou senha incorretos" + "\n" + "Verifique e tente novamente", "PassWord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("Caso o problema persista, ative a permissão a aplicativos menos seguros " + "\n" + "na sua conta do gmail!", "Permissões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            if (MessageBox.Show("Ir ao Gmail?", "Ativar Permissão", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                            {
                                System.Diagnostics.Process.Start("https://myaccount.google.com/lesssecureapps");
                            }
                            BtnChanceEmail_Click(sender, e);
                            PassWord.Checked = true;
                        }
                    }
                }
            }
            else
            {
                lblErro2.Visible = true;
            }
        }

        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void PassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (PassWord.Checked)
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }
    }
}
