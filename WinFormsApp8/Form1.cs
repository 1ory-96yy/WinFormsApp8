using System;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputDate = textBox1.Text;
            DateTime targetDate;
            bool isValidDate = DateTime.TryParse(inputDate, out targetDate);

            if (isValidDate)
            {
                DateTime currentDate = DateTime.Now;
                TimeSpan difference = targetDate - currentDate;

                double years = difference.Days / 365.25;
                double months = difference.Days / 30.44;
                double days = difference.Days;
                double minutes = difference.TotalMinutes;
                double seconds = difference.TotalSeconds;

                int hours = difference.Hours;
                int remainingMinutes = difference.Minutes;
                int remainingSeconds = difference.Seconds;

                label1.Text = $"Роки: {years:F2}\nМісяці: {months:F2}\nДні: {days}\nГодини: {hours}\nХвилини: {remainingMinutes}\nСекунди: {remainingSeconds}";
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть правильну дату у форматі yyyy-MM-dd.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputDate = textBox2.Text;
            DateTime targetDate;
            bool isValidDate = DateTime.TryParse(inputDate, out targetDate);

            if (isValidDate)
            {
                DateTime currentDate = DateTime.Now;
                TimeSpan difference = targetDate - currentDate;

                double totalYears = difference.Days / 365.25;
                double totalMonths = difference.Days / 30.44;
                double totalDays = difference.Days;
                double totalMinutes = difference.TotalMinutes;
                double totalSeconds = difference.TotalSeconds;

                int totalHours = (int)totalMinutes / 60;
                int remainingMinutes = (int)totalMinutes % 60;
                int remainingSeconds = (int)totalSeconds % 60;

                label2.Text = $"Роки: {totalYears:F2}\nМісяці: {totalMonths:F2}\nДні: {totalDays}\nГодини: {totalHours}\nХвилини: {remainingMinutes}\nСекунди: {remainingSeconds}";
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть правильну дату у форматі yyyy-MM-dd.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
