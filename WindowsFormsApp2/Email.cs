﻿using System;
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
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) ||
                String.IsNullOrEmpty(textBox2.Text) ||
                String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Am I a joke to you?..");
            }
            else
            {
                MailAddress fromAdress = new MailAddress("kishkashockoladki@gmail.com", "Говно на палке");
                MailAddress toAdress = new MailAddress(textBox2.Text, textBox1.Text);
                MailMessage message = new MailMessage(fromAdress, toAdress);
                message.Subject = "НУ китайцы и чо, а чо ты хотел";
                message.IsBodyHtml = true;
                message.Body = System.IO.File.ReadAllText("Шаблон.txt");

                System.IO.File.WriteAllText("TT.csv", "Имя,Клан,Возраст");
                {
                    foreach (Per per in Filters.team)
                    {
                        System.IO.File.AppendAllText("TT.csv", Environment.NewLine +
                            per.name + "," + per.clan + "," + per.age);
                    }

                    System.IO.File.AppendAllText("TT.csv", Environment.NewLine + Environment.NewLine + "Китацы чо");
                    message.Attachments.Add(new Attachment("TT.csv"));
                }
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Credentials = new NetworkCredential(fromAdress.Address, "NightmareFredbear");

                smtpClient.Send(message);

                MessageBox.Show("Поздравляю, " + textBox1.Text + " вы выиграли ничего");
            }
        }

        private void Email_Load(object sender, EventArgs e)
        {

        }
    }
}
