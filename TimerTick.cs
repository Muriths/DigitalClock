using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class TimerTick : Form
    {
        Hour _hour = new Hour();
        public TimerTick(Hour hor)
        {
            TopMost = true;
            this._hour = hor;
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            WorkTimer wt = new WorkTimer();
            Timer.Text = $"{_hour.hour} : {_hour.minute} : {_hour.second}";
            if (_hour.second != 0)
            {
                _hour.second--;
            }
            else if (_hour.minute != 0)
            {
                _hour.minute--;
                _hour.second += 60;
            }
            else if (_hour.hour != 0)
            {
                _hour.hour--;
                _hour.minute += 60;
            }
            if (_hour.second == 0 && _hour.minute == 0 && _hour.hour == 0 && _hour.count != 0)
            {
                _hour.count--;
                MessageBox.Show
                    (
                    "Время закончилось !",
                    "Message!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );

                this.Hide();
                Form1 form1 = new Form1();
                form1.StartPosition = FormStartPosition.Manual;
                form1.Location = Location;
                form1.Show();
                if (DialogResult == DialogResult.OK)
                {
                    TimerForm tf = new TimerForm();
                    tf.StartPosition = FormStartPosition.Manual;
                    tf.Location = Location;
                    tf.Show();
                    this.Close();

                }
            }
        }

        private void TimerTick_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        Point last;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point cur = MousePosition;
                int dx = cur.X - last.X;
                int dy = cur.Y - last.Y;
                Point loc = new Point(Location.X + dx, Location.Y + dy);
                Location = loc;
                last = cur;
            }
        }


        //TODO: Сделать музыку 
    }
}
