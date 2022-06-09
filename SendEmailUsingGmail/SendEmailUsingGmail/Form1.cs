using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gmail;
namespace SendEmailUsingGmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_attachment.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GmailClient client = new GmailClient();
            //If you want to send email without attachment, then pass null value in attachment parameter.
            string status=client.send(txt_gmailid.Text, txt_password.Text, txt_toemail.Text, txt_subject.Text, txt_body.Text, txt_attachment.Text==""?null:txt_attachment.Text);
            MessageBox.Show(status);
        }
    }
}
