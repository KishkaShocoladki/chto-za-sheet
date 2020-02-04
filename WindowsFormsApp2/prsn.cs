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
            Text = "Информация о " + per; 
            
            try
            {
                pictureBox1.Load("../../Pictures/Persons/" + per + ".jpg");
                pictureBox2.Load("../../Pictures/Persons/" + per + ".jpg");
            }
            catch (Exception) { }

            if (per == "Цзинь Гуанъяо")
            {
                button1.Text = "lflf";
            }
        }

        private void prsn_Load(object sender, EventArgs e)
        {

        }
    }
}
