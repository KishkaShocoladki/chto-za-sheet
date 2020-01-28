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
        public prsn(string per)
        {
            InitializeComponent();
            if (per == "kkk")
            {
                pictureBox1.Load("../../Pictures/Clans/Цзинь Гуанъяо.jpg");
                pictureBox2.Load("../../Pictures/Clans/Цзинь Гуанъяо.jpg");

                button1.Text = "lflf";
            }
        }
    }
}
