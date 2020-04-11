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
    public partial class Savevfile : Form
    {
        public Savevfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.AppendAllText("Персонажи.txt", 
                Environment.NewLine + textBox1.Text + ", " + comboBox2.Text + ", " + textBox2.Text + ", " + comboBox4.Text + ", " + comboBox5.Text);

            System.IO.File.Copy(FileName, "../../Pictures/Persons/" + textBox1.Text + ".jpg");

            System.IO.File.WriteAllText("../../Pictures/" + textBox1.Text + "Б1" + ".txt", textBox3.Text);
            System.IO.File.WriteAllText("../../Pictures/" + textBox1.Text + "Б2" + ".txt", textBox4.Text);
            System.IO.File.WriteAllText("../../Pictures/" + textBox1.Text + ".txt", textBox5.Text);
        }

       String FileName;

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                pictureBox1.Load(FileName);
            }
        }
    }
}
