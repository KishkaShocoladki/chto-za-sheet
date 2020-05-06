using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class obSvyaz : Form
    {
        public obSvyaz()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region
            if (textBox1.Text.Length < 20)
            {
                MessageBox.Show("Заполни пожалуйста а");
            }
            if (textBox2.Text.Length < 6) 
            {
                MessageBox.Show("Заполни пожалуйста а");
            }
            #endregion
                MailAddress fromAdress = new MailAddress("kishkashockoladki@gmail.com", "Говно на палке");
                MailAddress toAdress = new MailAddress("kishkashockoladki@gmail.com", "Отправитель");
                MailMessage message = new MailMessage(fromAdress, toAdress);
                message.Subject = "к";
                message.Body = "Раздел: " + comboBox1.Text + Environment.NewLine +
                "Кто все сломал к чертям: " + textBox2.Text + Environment.NewLine +
                "ТЕкст сообщения: " + Environment.NewLine + textBox1.Text;

                if (adres1 != "")
                    message.Attachments.Add(new Attachment(adres1));
                if (adres2 != "")
                    message.Attachments.Add(new Attachment(adres2));
            
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Credentials = new NetworkCredential(fromAdress.Address, "NightmareFredbear");

                smtpClient.Send(message);
                MessageBox.Show("Поздравляю, вы выиграли ничего");
            }

        private void obSvyaz_Load(object sender, EventArgs e)
        {

        }
        string adres1 = "";
        string adres2 = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adres1 = openFileDialog1.FileName;
                pictureBox1.Load(adres1);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adres2 = openFileDialog1.FileName;
                pictureBox2.Load(adres2);
            }
        }
    }
    }

