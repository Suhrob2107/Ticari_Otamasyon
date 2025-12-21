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

namespace Ticari_Otamasyon
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }
        public string mail;
        private void FrmMail_Load(object sender, EventArgs e)
        {
            TxtMailAddress.Text = mail;
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            string mail = "tolibjanov05@gmail.com";
            string sifre = "rpqf orps spgz ahku"; // App Password (boşluklar olabilir)

            MailMessage mesajim = new MailMessage();
            SmtpClient istemci = new SmtpClient("smtp.gmail.com", 587);

            istemci.Credentials = new NetworkCredential(mail, sifre);
            istemci.EnableSsl = true;

            mesajim.From = new MailAddress(mail);
            mesajim.To.Add(TxtMailAddress.Text);
            mesajim.Subject = TxtKonu.Text;
            mesajim.Body = TxtMesaj.Text;

            istemci.Send(mesajim);

            MessageBox.Show("Mail Gönderildi");
        }
    }
}
