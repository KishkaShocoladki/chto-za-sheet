using System;
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
    public partial class clan : Form
    {
        public clan(string clan)
        {
            InitializeComponent();
            Text = "Информация о клане " + clan;

            try
            {
               // pictureBox1.Load("../../Pictures/Persons/" + clan + ".jpg");
               //pictureBox2.Load("../../Pictures/Persons/" + clan + "2" + ".jpg");
                textBox1.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + clan + "Б1" + ".txt");
                //textBox2.Lines =
                  //System.IO.File.ReadAllLines("../../Pictures/" + clan + "Б2" + ".txt");
                //textBox3.Lines =
                  //System.IO.File.ReadAllLines("../../Pictures/" + clan + ".txt");
            }
            catch (Exception) { }
        }

        private void clan_Load(object sender, EventArgs e)
        {

        }
    }
}
