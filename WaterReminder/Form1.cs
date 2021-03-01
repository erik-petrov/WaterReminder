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
        
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Минуты.SelectedItem != null && listView1.SelectedItems != null)
            {
                //Countdown count = new Countdown(Минуты.SelectedItem, listView1.SelectedItems);
                timer1.Interval = 100;
                timer1.Enabled = true;
                timer1.Tick += timer1_Tick;
                ListViewItem chosen = listView1.SelectedItems[0];
                label1.Show();
                progressBar1.Maximum = Convert.ToInt32(Минуты.SelectedItem) * 60;
                progressBar1.PerformStep();
                Countdown count = new Countdown();
                //MessageBox.Show($"{Convert.ToString(Минуты.SelectedItem)}\n{chosen.IndentCount}");
                //label1.Text = "gay";
    }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            left = count.timer();
            label1.Text = Convert.ToString(left);
        }
    }
}
