using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//todo: норм сделать счетчик посередине, мб както украсить

namespace WaterReminder
{
    public partial class Form1 : Form
    {
        public int left;
        public ListViewItem chosen;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Минуты.SelectedItem != null & listView1.SelectedItems != null)
            {
                //выключение кнопки
                mainButton(false);
                //включение ещё одной кнопки
                button2.Visible = true;
                //установка таймера
                timer1.Interval = 1000;
                timer1.Start();
                timer1.Tick += Timer1_Tick;
                //Какая минута выбрана
                chosen = listView1.SelectedItems[0];
                label1.Show();
                //Минуты в секунды
                left = Convert.ToInt32(Минуты.SelectedItem) * 60;
                progressBar1.Maximum = left;
                progressBar1.Step = 1;
                label1.Text = $"Осталось: {Convert.ToString(left)} секунд";
            }
            else
            {
                MessageBox.Show("Выбери сколько минут и кол-во воды.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            mainButton(true);
            progressBar1.Value = 0;
            left = 0;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = $"Осталось: {Convert.ToString(left)} секунд";
            progressBar1.PerformStep();
            if (left > 0)
            {
                left -= 1;
            }
            else if (left == 0)
            {
                timer1.Stop();
                mainButton(true);
                progressBar1.Value = 0;
                Notify _ = new Notify(chosen);
            }
        }
        private void mainButton(bool dec)
        {
            if (dec == true)
            {
                button1.BackColor = SystemColors.MenuHighlight;
                button1.Text = "Начать отсчет";
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button1.Text = "Таймер запущен";
                button1.BackColor = SystemColors.ControlDarkDark;
            }
        }
    }
}