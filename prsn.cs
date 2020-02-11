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
    public partial class prsn : Form
    {
        public prsn(string person)
        {
            InitializeComponent();
            Text = "Информация о " + person; 
            
            try
            {
                pictureBox1.Load("../../Pictures/Persons/" + person + ".jpg");
                pictureBox2.Load("../../Pictures/Persons/" + person + "2" + ".jpg");
                textBox1.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + person + "Б1" + ".txt");
                textBox2.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + person + "Б2" + ".txt");
                textBox3.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + person + ".txt");
            }
            catch (Exception) { }

        }

        private void prsn_Load(object sender, EventArgs e)
        {

        }
    }
}
