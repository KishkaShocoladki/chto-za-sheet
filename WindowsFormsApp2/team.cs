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
    public partial class TEAM : Form
    {
        public TEAM()
        {
            InitializeComponent();
            int x = 10;
            int y = 10;
            foreach (Per per in Filters.team)
            {
                PictureBox pix = new PictureBox();
                Button but = new Button();

                pix.Text = per.pix.Text;
                pix.Size = per.pix.Size;
                pix.SizeMode = per.pix.SizeMode;
                pix.Location = new Point(x, y);
                pix.Click += new EventHandler(Filters.button2_Click);
                //pix.Location = per.pix.Location;
                pix.Image = per.pix.Image;

                but.Location = per.b.Location;
                but.Size = per.b.Size;
                but.Text = per.b.Text;

                Controls.Add(pix);
                x = x + 100;
                if (x + 100 > Width)
                {
                    x = 10;
                    y = y + 110;
                }
            }
        }

        
        
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TEAM_Load(object sender, EventArgs e)
        {

        }
    }
}
