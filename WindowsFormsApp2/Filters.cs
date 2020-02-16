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
        
        public Per(string name1, string sost1, int age1)
        {
            name = name1;
            age = age1;
            sost = sost1;
        }
    }
    public partial class Filters : Form
    {
        Per[] persons = new Per[10];
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
        }

        private void Filters_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i = i + 1)
            {
                bool show = true;
                if (comboBox1.Text != "" && persons[i].name != comboBox1.Text)
                {
                    show = false;
                }

                if (comboBox2.Text != "" && persons[i].sost != comboBox2.Text)
                {
                    show = false;
                }
                
               // if (persons[i].age < Convert.ToInt32(comboBox3.Text))
                if (show)
                {
                    MessageBox.Show(persons[i].name);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
