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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persons form2 = new Persons();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clans form3 = new Clans();
            form3.Show();
        }
    }
}
