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
    public partial class Spravka : Form
    {
        public Spravka()
        {
            InitializeComponent();
        }

        private void персонажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Персонажи - юююю";
        }

        private void кланыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Rkfys - юююю";
        }
    }
}
