using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Mail_Gönderme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_mailGonder_Click(object sender, EventArgs e)
        {
            MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();

            istemci.Credentials = new System.Net.NetworkCredential("sumeyyegencer@gmail.com", "");
            istemci.Port=587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;


            mesajım.To.Add(txtTo.Text);
            mesajım.From = new MailAddress("sumeyyegencer@gmail.com");
            mesajım.Subject = txtSubject.Text;
            mesajım.Body = txtMessage.Text;

            istemci.Send(mesajım);
        }
    }
}
