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
                button1.Text = "Цзинь Гуанъяо";
                button2.Text = "Цзинь Гуань Шань";
                button3.Text = "Цзинь Лин";
                button4.Text = "Цзинь Цзы Сюань";

                pictureBox1.Load("../../Pictures/Persons/" + button1.Text + ".jpg");
                pictureBox2.Load("../../Pictures/Persons/" + button2.Text + ".jpg");
                pictureBox3.Load("../../Pictures/Persons/" + button3.Text + ".jpg");
                pictureBox4.Load("../../Pictures/Persons/" + button4.Text + ".jpg");
            }
            if (clan == "Юн Мэн Цзян")
            {
                button1.Text = "Цзян Фэн Мянь и Юй Цзы Юань";
                button2.Text = "Цзян Чэн";

                pictureBox1.Load("../../Pictures/Persons/Цзян Фэн Мянь_Юй Цзы Юань.jpg");
                pictureBox2.Load("../../Pictures/Persons/" + button2.Text + ".jpg");
            }
            if (clan == "Гу Су Лань")
            {
                button1.Text = "Лань Ван Цзы";
                button2.Text = "Лань Сичень";
                button3.Text = "Лань Сычжуй и Лань Цзинъи";
                button4.Text = "Лань Цижэнь";

                pictureBox1.Load("../../Pictures/Persons/Лань Ван Цзы(Лань Чжань).jpg");
                pictureBox2.Load("../../Pictures/Persons/" + button2.Text + ".jpg");
                pictureBox3.Load("../../Pictures/Persons/Лань Сычжуй_Лань Цзинъи.jpg");
                pictureBox4.Load("../../Pictures/Persons/" + button4.Text + ".jpg");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            prsn f = new prsn("kkk");
            f.Show();
        }
    }
}
