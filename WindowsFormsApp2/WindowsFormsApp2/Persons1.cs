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
    public partial class Persons1 : Form
    {
        public Persons1(string clan)
        {
            InitializeComponent();
            if (clan == "Лань Линь Цзинь")
            {
                pictureBox1.Load("../../Pictures/Clans/Гу Су Лань.jpg");
            }
            if (clan == "Юн Мэн Цзян")
            {
                pictureBox1.Load("../../Pictures/Clans/Лань Линь Цзинь.jpg");
            }
            if (clan == "Гу Су Лань")
            {
                pictureBox1.Load("../../Pictures/Clans/Лань Линь Цзинь.jpg");
            }
            if (clan == "Ци Шань Вэнь")
            {
                pictureBox1.Load("../../Pictures/Clans/Лань Линь Цзинь.jpg");
            }
            if (clan == "Цин Хэ Нэ")
            {
                pictureBox1.Load("../../Pictures/Clans/Лань Линь Цзинь.jpg");
            }
        }

        private void Persons1_Load(object sender, EventArgs e)
        {

        }
    }
}
