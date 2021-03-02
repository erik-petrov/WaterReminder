using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WaterReminder
{
    public class Notify
    {
        public int time;
        public Notify(ListViewItem amount)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Beep();
            }
            MessageBox.Show($"ПЕЙ {Convert.ToString(amount.Text)} ВОДЫ");
        }
    }
}
