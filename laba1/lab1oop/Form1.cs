using Microsoft.VisualBasic;

namespace lab1oop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Розпочинаємо вивчення основ ООП 2");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Розпочинаємо вивчення основ ООП");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розпочинаємо вивчення основ ООП 3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розпочинаємо вивчення основ ООП 4");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розпочинаємо вивчення основ ООП 5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
