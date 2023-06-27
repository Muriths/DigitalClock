using System.Collections.Generic;
using System.Reflection;
using Ressy;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblDate.Text = DateTime.Now.ToString("dd MMMM");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            var pe = new PortableExecutable("D:\\Visual Studio Project\\DigitalClock\\banking_business_payment_cash_finance_money_coin_icon_254032.ico");
        }

        private void lblDay_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_MouseDown(object sender, EventArgs e)
        {
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

        private void timerSeter_Click(object sender, EventArgs e)
        {
            TimerForm tf = new TimerForm();
            tf.StartPosition = FormStartPosition.Manual;
            tf.Location = Location;
            tf.Show();
            this.Hide();

        }
    }
}