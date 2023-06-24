using System.DirectoryServices.ActiveDirectory;

namespace DigitalClock
{
    public partial class WorkTimer : Form
    {
        public WorkTimer()
        {
            TopMost = true;
                        this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
        }
        Hour hor = new Hour();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Hours.SelectedItems.ToString() != null)
            {
                hor.hour = int.Parse(Hours.SelectedItem.ToString());
            }
            else
            {
                hor.hour = 0;
            }
            if (Minuts.SelectedItems.ToString() != null)
            {
                hor.minute = int.Parse(Minuts.SelectedItem.ToString());
            }
            else
            {
                hor.minute = 0;
            }
            if (Seconds.SelectedItems.ToString() != null)
            {
                hor.second = int.Parse(Seconds.SelectedItem.ToString());
            }
            else
            {
                hor.second = 0;
            }


            TimerTick tc = new TimerTick(hor);
            tc.StartPosition = FormStartPosition.Manual;
            tc.Location = Location;
            tc.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
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
    }
}
