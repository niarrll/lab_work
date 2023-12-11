using Microsoft.VisualBasic;

namespace OOPLR3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(new Message().Info());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(Message.Count.ToString());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new PostMessage().Info());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(new EMessage().Info());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                var title = Interaction.InputBox("Введіть заголовок: ", "Введення");
                var message = Interaction.InputBox("Введіть текст листа: ", "Введення");
                var length = double.Parse(Interaction.InputBox("Введіть кількість сторінок: ", "Введення"));
                var name = Interaction.InputBox("Введіть назву листа:", "Введення");
                var eMessage = new EMessage(title, message, length, name);
                MessageBox.Show(eMessage.Info());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                var title = Interaction.InputBox("Введіть заголовок: ", "Введення");
                var message = Interaction.InputBox("Введіть текст листа: ", "Введення");
                var length = double.Parse(Interaction.InputBox("Введіть кількість сторінок: ", "Введення"));
                var name = Interaction.InputBox("Введіть назву листа:", "Введення");
                var postMessage = new PostMessage(title, message, length, name);
                MessageBox.Show(postMessage.Info());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка");
            }
        }
    }
}
