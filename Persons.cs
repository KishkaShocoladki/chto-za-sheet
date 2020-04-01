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
    public partial class Persons : Form
    {
        public Persons()
        {
            InitializeComponent();
        }

        private void persons1_Click(object sender, EventArgs e)
        {
            Persons1 form4 = new Persons1();
            form4.Show();
        }

        private void persons2_Click(object sender, EventArgs e)
        {
            Persons2 form5 = new Persons2();
            form5.Show();
        }

        private void persons3_Click(object sender, EventArgs e)
        {

        }
    }
}
