namespace DigitalClock
{
    public partial class TimerForm : Form
    {
        public TimerForm()
        {
            TopMost = true;
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
        }

        private void SetWorkTime_Click(object sender, EventArgs e)
        {
            WorkTimer wt = new WorkTimer();
            wt.StartPosition= FormStartPosition.Manual;
            wt.Location = Location;
            wt.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = Location;
            form.Show();

            this.Hide();
        }

        Point last;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {



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
        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;
            }

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
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
    }
}
