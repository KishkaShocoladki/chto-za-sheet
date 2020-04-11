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
        Per person;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Filters.team.Contains(person))
                Filters.team.Add(person);
            //Filters.team.Add(person);
        }

        public prsn(Per person1)
        {
            person = person1;
            InitializeComponent();
            Text = "Информация о " + person.name;

            try
            {
                pictureBox1.Load("../../Pictures/Persons/" + person.name + ".jpg");
                pictureBox2.Load("../../Pictures/Persons/" + person.name + "2" + ".jpg");
                textBox1.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + person.name + "Б1" + ".txt");
                textBox2.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + person.name + "Б2" + ".txt");
                textBox3.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + person.name + ".txt");
            }
            catch (Exception) { }
        }

       /* public prsn(Button person)
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
        }*/

        private void prsn_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
