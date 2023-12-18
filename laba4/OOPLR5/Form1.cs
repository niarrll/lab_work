using Microsoft.VisualBasic;

namespace OOPLR3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Telephone.Count.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new MobilePhone().Info());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new HomeTelephone().Info());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MobilePhone mp = new();
            HomeTelephone ht = new();
            Telephone t = mp;
            MessageBox.Show(t.Volume());
            t = ht;
            MessageBox.Show(t.Volume());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var weight = double.Parse(Interaction.InputBox("Введіть вагу мобільного телефону:", "Введення"));
                var width = double.Parse(Interaction.InputBox("Введіть ширину мобільного телефону:", "Введення"));
                var height = double.Parse(Interaction.InputBox("Введіть висоту мобільного телефону:", "Введення"));
                var name = Interaction.InputBox("Введіть назву мобільного телефону:", "Введення");
                var mp = new MobilePhone(width, height, weight, name);
                MessageBox.Show(mp.Info());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var weight = double.Parse(Interaction.InputBox("Введіть вагу стаціонарного телефону:", "Введення"));
                var width = double.Parse(Interaction.InputBox("Введіть ширину стаціонарного телефону:", "Введення"));
                var height = double.Parse(Interaction.InputBox("Введіть висоту стаціонарного телефону:", "Введення"));
                var name = Interaction.InputBox("Введіть назву стаціонарного телефону:", "Введення");
                var sp = new HomeTelephone(width, height, weight, name);
                MessageBox.Show(sp.Info());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button a = new();
            Random r = new();
            a.Width = 200;
            a.Height = 200;
            a.Left = r.Next(500);
            a.Top = r.Next(400);
            a.Text = ((Button)sender).Text;
            a.Parent = this;
            a.Show();
            a.Click += new System.EventHandler(this.button8_Click);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                item.Left -= 60;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                item.Width += 20;
                item.Height += 20;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MobilePhone mp = new();
            HomeTelephone ht = new();
            Telephone t = mp;
            MessageBox.Show(t.Info());
            t = ht;
            MessageBox.Show(t.Info());
        }
    }
}
