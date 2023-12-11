using Microsoft.VisualBasic;
using System.Globalization;

namespace OOPLR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                var color = Interaction.InputBox("Введіть колір тексту: ", "Введення");
                var title = Interaction.InputBox("Введіть заголовок: ", "Введення");
                var message = Interaction.InputBox("Введіть текст листа: ", "Введення");
                var length = double.Parse(Interaction.InputBox("Введіть кількість сторінок: ", "Введення"));
                var creationDate = DateTime.ParseExact(Interaction.InputBox("Введіть дату виготовлення телефону у форматі (ddMMyyyy): ", "Введення"), "ddMMyyyy", CultureInfo.InvariantCulture);
                Message msg = new(color, title, message, length, creationDate);
                MessageBox.Show(msg.Info());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Message msg = new();
            MessageBox.Show(msg.Info());
        }
    }
}
