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
    public partial class Clans : Form
    {
        public Clans()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            Button btn = (Button)sender;
            clan f = new clan(btn.Text);
            f.Show();
        }

        private void Clans_Load(object sender, EventArgs e)
        {

        }
    }
}
