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
    public partial class Person : Form
    {
        public Person()
        {
            InitializeComponent();
        }
          
        private void persons1_Click(object sender, EventArgs e)
        {
            Persons1 f = new Persons1(persons1.Tag.ToString());
            f.Show();
        }

        private void persons2_Click(object sender, EventArgs e)
        {
            Persons1 f = new Persons1("Юн Мэн Цзян");
            f.Show();
        }

        private void persons3_Click(object sender, EventArgs e)
        {
            Persons1 f = new Persons1("Гу Су Лань");
            f.Show();
        }

        private void persons4_Click(object sender, EventArgs e)
        {
            Persons1 f = new Persons1("Ци Шань Вэнь");
            f.Show();
        }

        private void persons5_Click(object sender, EventArgs e)
        {
            Persons1 f = new Persons1("Цин Хэ Нэ");
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Заглавная_страница");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Заглавная_страница");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Заглавная_страница");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Заглавная_страница");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Заглавная_страница");
        }
    }
}
