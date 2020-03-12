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
    public struct Per
    {
        public string name;
        public string sost;
        public int age;
        public Button b;
        public PictureBox pix;
        
        public Per(string name1, string sost1, int age1)
        {
            name = name1;
            age = age1;
            sost = sost1;
            b = new Button();
            pix = new PictureBox();
        }
    }

    public partial class Filters : Form
    {
        public static Per[] persons = new Per[10];
        public static List<Per> team = new List<Per>();


        
        public Filters()
        {
            InitializeComponent(); 

            persons[0] = new Per("Цзинь Гуанъяо", "Мертв", 2);
            persons[1] = new Per("Цзинь Гуань Шань", "Мертв", 20);
            persons[2] = new Per("Цзян Фэн Мянь", "Мертв", 14);
            persons[3] = new Per("Цзян Чэн", "Жив", 35);
            persons[4] = new Per("Вей Усянь", "Мертв", 27);
            persons[5] = new Per("Лань Ван Цзы", "Жив", 35);
            persons[6] = new Per("Вэнь Жо Хань", "Мертв", 20);
            persons[7] = new Per("Не Хуай Сан", "Жив", 17);
            persons[8] = new Per("Не Мин Цзюэ", "Мертв", 16);
            persons[9] = new Per("Лань Сичень", "Жив", 15);

            int x = 10;
            int y = 200;
            for (int i = 0; i < persons.Length; i = i + 1)
            {

                persons[i].pix.Location = new Point(x, y);
                persons[i].pix.Size = new Size(100, 100);
                persons[i].pix.Text = persons[i].name;
                persons[i].pix.SizeMode = PictureBoxSizeMode.Zoom;
                persons[i].pix.Click += new EventHandler(button2_Click);
                persons[i].pix.Load("../../Pictures/Persons/" + persons[i].name + ".jpg");
                Controls.Add(persons[i].pix);
                x = x + 100;
                if (x + 100 > Width)
                {
                    x = 10;
                    y = y + 150;
                }
            }
        }

        private void Filters_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 200;
            for (int i = 0; i < persons.Length; i = i + 1)
            {
                persons[i].pix.Visible = false;
                bool show = true;



                if (nameBox1.Text != "" && persons[i].name != nameBox1.Text)
                {
                    show = false;
                }

                else if (sostBox2.Text != "" && persons[i].sost != sostBox2.Text)
                {
                    show = false;
                }
                
                else if (ageBox3.Text != "" && persons[i].age > Convert.ToInt32(ageBox3.Text))
                {
                    show = false;
                }


                if (show)
                {
                    persons[i].pix.Visible = true;
                    persons[i].pix.Location = new Point(x, y);
                    x = x + 100;
                    if (x + 100 > Width)
                    {
                        x = 10;
                        y = y + 150;
                    }
                }
            }
        }
        
        public static void button2_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < persons.Length; i = i + 1)
            {
                if (((PictureBox)sender).Image == persons[i].pix.Image)
                {
                    prsn f = new prsn(persons[i]);
                    f.Show();
                }
            }
            // prsn f = new prsn((PictureBox)sender);
           // f.Show();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
