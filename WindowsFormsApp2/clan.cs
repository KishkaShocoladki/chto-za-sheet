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
    /*public partial class clan : Form
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
        public clan(string clan)
        {
            InitializeComponent();
            Text = "Информация о клане " + clan;

            try
            {
                // pictureBox1.Load("../../Pictures/Persons/" + clan + ".jpg");
                //pictureBox2.Load("../../Pictures/Persons/" + clan + "2" + ".jpg");
                textBox1.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + clan + "Б1" + ".txt");
                //textBox2.Lines =
                //System.IO.File.ReadAllLines("../../Pictures/" + clan + "Б2" + ".txt");
                //textBox3.Lines =
                //System.IO.File.ReadAllLines("../../Pictures/" + clan + ".txt");
            }
            catch (Exception) { }
            Button[] bttn = new Button[4];
            bttn[0] = button1;
            bttn[1] = button2;
            bttn[2] = button3;
            bttn[3] = button4;

            PictureBox[] pctbox = new PictureBox[5];
            pctbox[0] = pictureBox1;
            pctbox[1] = pictureBox2;
            pctbox[2] = pictureBox3;
            pctbox[3] = pictureBox4;
            pctbox[4] = pictureBox5;



            if (clan == "Лань Линь Цзинь")
            {
                pctbox[0].Load("../../Pictures/Clans/" + clan + ".jpg");
                button1.Text = "Цзинь Гуанъяо";
                button2.Text = "Цзинь Гуань Шань";
                button3.Text = "Цзинь Лин";
                button4.Text = "Цзинь Цзы Сюань";
            }
            else if (clan == "Юн Мэн Цзян")
            {

                button1.Text = "Цзян Фэн Мянь";
                button2.Text = "Цзян Чэн";
                button3.Text = "Вей Усянь";
                button4.Text = "Цзян Янь Ли";
            }
            else if (clan == "Гу Су Лань")
            {

                button1.Text = "Лань Ван Цзы";
                button2.Text = "Лань Сичень";
                button3.Text = "Лань Сычжуй и Лань Цзинъи";
                button4.Text = "Лань Цижэнь";
            }
            else if (clan == "Ци Шань Вэнь")
            {

                button1.Text = "Вэнь Жо Хань";
                button2.Text = "Вэнь Нин";
                button3.Text = "Вэнь Цин";
                button4.Text = "Вэнь Чжао";
            }
            else if (clan == "Цин Хэ Нэ")
            {

                button1.Text = "Не Хуай Сан";
                button2.Text = "Не Мин Цзюэ";
                for (int i = 2; i < 4; i = i + 1)
                {
                    bttn[i].Visible = false;
                    pctbox[i].Visible = false;
                }
            }
            else
            {
                for (int i = 0; i < 4; i = i + 1)
                {
                    bttn[i].Visible = false;
                    pctbox[i].Visible = false;
                }
            }

            drawPicture(button1, pictureBox5);
            drawPicture(button2, pictureBox2);
            drawPicture(button3, pictureBox3);
            drawPicture(button4, pictureBox4);
        }

        private void clan_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
               
        }
    }
}*/

    public partial class clan : Form
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
        public clan(string clan)
        {
            InitializeComponent();
            /* int x = 10;
             int y = 10;
             foreach (Per per in Filters.persons)
             {
                 if (per.clan == clan)
                 {
                     PictureBox pix = new PictureBox();
                     Label but = new Label();


                     pix.Text = per.pix.Text;
                     pix.Size = new Size(100, 100);
                     pix.SizeMode = per.pix.SizeMode;
                     pix.Location = new Point(x, y);
                     pix.Click += new EventHandler(Filters.button2_Click);
                     pix.Image = per.pix.Image;

                     but.Location = new Point(x, y + 100);
                     but.Size = new Size(100, 15);
                     but.Text = per.b.Text;
                     but.TextAlign = ContentAlignment.MiddleCenter;
                     but.Font = new Font("Arial", 8);

                     Controls.Add(pix);
                     Controls.Add(but);

                     x = x + 10;
                     if (x + 10 > Width)
                     {
                         x = 10;
                         y = y + 150;
                     }
                 }
             }*/
            Text = "Информация о клане " + clan;

            try
            {
                // pictureBox1.Load("../../Pictures/Persons/" + clan + ".jpg");
                //pictureBox2.Load("../../Pictures/Persons/" + clan + "2" + ".jpg");
                textBox1.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + clan + "Б1" + ".txt");
                //textBox2.Lines =
                //System.IO.File.ReadAllLines("../../Pictures/" + clan + "Б2" + ".txt");
                //textBox3.Lines =
                //System.IO.File.ReadAllLines("../../Pictures/" + clan + ".txt");
            }
            catch (Exception) { }

            Button[] bttn = new Button[4];
            bttn[0] = button1;
            bttn[1] = button2;
            bttn[2] = button3;
            bttn[3] = button4;

            PictureBox[] pctbox = new PictureBox[5];
            pctbox[0] = pictureBox1;
            pctbox[1] = pictureBox2;
            pctbox[2] = pictureBox3;
            pctbox[3] = pictureBox4;
            pctbox[4] = pictureBox5;



            if (clan == "Лань Линь Цзинь")
            {
                pctbox[0].Load("../../Pictures/Clans/" + clan + ".jpg");
                button1.Text = "Цзинь Гуанъяо";
                button2.Text = "Цзинь Гуань Шань";
                button3.Text = "Цзинь Лин";
                button4.Text = "Цзинь Цзы Сюань";
            }
            else if (clan == "Юн Мэн Цзян")
            {

                button1.Text = "Цзян Фэн Мянь";
                button2.Text = "Цзян Чэн";
                button3.Text = "Вей Усянь";
                button4.Text = "Цзян Янь Ли";
            }
            else if (clan == "Гу Су Лань")
            {

                button1.Text = "Лань Ван Цзы";
                button2.Text = "Лань Сичень";
                button3.Text = "Лань Сычжуй и Лань Цзинъи";
                button4.Text = "Лань Цижэнь";
            }
            else if (clan == "Ци Шань Вэнь")
            {

                button1.Text = "Вэнь Жо Хань";
                button2.Text = "Вэнь Нин";
                button3.Text = "Вэнь Цин";
                button4.Text = "Вэнь Чжао";
            }
            else if (clan == "Цин Хэ Нэ")
            {

                button1.Text = "Не Хуай Сан";
                button2.Text = "Не Мин Цзюэ";
                for (int i = 2; i < 4; i = i + 1)
                {
                    bttn[i].Visible = false;
                    pctbox[i].Visible = false;
                }
            }
            else
            {
                for (int i = 0; i < 4; i = i + 1)
                {
                    bttn[i].Visible = false;
                    pctbox[i].Visible = false;
                }
            }

            drawPicture(button1, pictureBox5);
            drawPicture(button2, pictureBox2);
            drawPicture(button3, pictureBox3);
            drawPicture(button4, pictureBox4);
        }
    }
}
