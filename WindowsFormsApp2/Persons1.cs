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
        void drawPicture(Button button, PictureBox pictureBox)
        {
            if (button.Text != "")
            {
                pictureBox.Load("../../Pictures/Persons/" + button.Text + ".jpg");
            }
            else
            {
                button.Visible = false;
                pictureBox.Visible = false;
            }
        }


        public Persons1(string clan)
        {
            InitializeComponent();
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";

            if (clan == "Лань Линь Цзинь")
            {
                button1.Text = "Цзинь Гуанъяо";
                button2.Text = "Цзинь Гуань Шань";
                button3.Text = "Цзинь Лин";
                button4.Text = "Цзинь Цзы Сюань";
            }
            if (clan == "Юн Мэн Цзян")
            {
                button1.Text = "Цзян Фэн Мянь и Юй Цзы Юань";
                button2.Text = "Цзян Чэн";
                button3.Text = "Вей Усянь";
                button4.Text = "Цзян Яньли";
            }
            if (clan == "Гу Су Лань")
            {
                button1.Text = "Лань Ван Цзы";
                button2.Text = "Лань Сичень";
                button3.Text = "Лань Сычжуй и Лань Цзинъи";
                button4.Text = "Лань Цижэнь";
            }
            if (clan == "Ци Шань Вэнь")
            { 
                button1.Text = "Лань Ван Цзы";
                button2.Text = "Лань Сичень";
                button3.Text = "Лань Сычжуй и Лань Цзинъи";
                button4.Text = "Лань Цижэнь";
            }
           // if (clan == "Цин Хэ Нэ")
           // {
           //     
          //  }

            drawPicture(button1, pictureBox1);
            drawPicture(button2, pictureBox2);
            drawPicture(button3, pictureBox3);
            drawPicture(button4, pictureBox4);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            prsn f = new prsn("kkk");
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            prsn f = new prsn(((Button)sender).Text);
            f.Show();
        }
    }
}
