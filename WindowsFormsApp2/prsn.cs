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
        public prsn(PictureBox person)
        {
            InitializeComponent();
            Text = "Информация о " + person.Text;

            try
            {
                pictureBox1.Load("../../Pictures/Persons/" + person.Text + ".jpg");
                pictureBox2.Load("../../Pictures/Persons/" + person.Text + "2" + ".jpg");
                textBox1.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + person.Text + "Б1" + ".txt");
                textBox2.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + person.Text + "Б2" + ".txt");
                textBox3.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + person.Text + ".txt");
            }
            catch (Exception) { }
        }
        public prsn(Button person)
        {
            InitializeComponent();
            Text = "Информация о " + person.Text;

            try
            {
                pictureBox1.Load("../../Pictures/Persons/" + person.Text + ".jpg");
            }
            catch (Exception) { }
            try
            {
                pictureBox2.Load("../../Pictures/Persons/" + person.Text + "2" + ".jpg");
            }
            catch (Exception) { }
            try
            {
                textBox1.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + person.Text + "Б1" + ".txt");
            }
            catch (Exception) { }
            try
            {
                textBox2.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + person.Text + "Б2" + ".txt");
            }
            catch (Exception) { }
            try
            {
                textBox3.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + person.Text + ".txt");
            }
            catch (Exception) { }
        }

        private void prsn_Load(object sender, EventArgs e)
        {

        }
    }
}
