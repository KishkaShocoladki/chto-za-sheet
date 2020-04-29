using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Spravka : Form
    {
        public Spravka()
        {
            InitializeComponent();
        }

        private void персонажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Lines =
                    System.IO.File.ReadAllLines("../../Pictures/" + "Персонажи" + ".txt");
        }

        private void кланыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + "Кланы" + ".txt");
        }

        private void Spravka_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient webC = new WebClient();
            webC.DownloadFileAsync(new Uri("https://royallib.com/get/txt/annette_liu/magistr_dyavolskogo_kulta.zip"),                                                 //"https://www.bookvoed.ru/files/3515/37/07/5.pdf"
                "C:\\Users\\" + Environment.UserName + "\\Downloads\\MDK.zip");
            MessageBox.Show("Сохранено в MDK.zip");
        }
    }
}
