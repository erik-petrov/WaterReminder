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
    public class Countdown
    {
        public int time;
        public Countdown(object minutes)
        {
            time = Convert.ToInt32(minutes) * 60;
        }
        public Countdown()
        {

        }
        public int timer(int time)
        {
            if (time != 0)
            {
                time--;
            }
            return time;
        }
    }
}
