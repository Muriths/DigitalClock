namespace DigitalClock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTime = new Label();
            lblDate = new Label();
            timer = new System.Windows.Forms.Timer(components);
            lblDay = new Label();
            pictureBox1 = new PictureBox();
            timerSeter = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Black;
            lblTime.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(28, 17);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(204, 65);
            lblTime.TabIndex = 0;
            lblTime.Text = "22:22:22";
            lblTime.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Black;
            lblDate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(149, 82);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(103, 30);
            lblDate.TabIndex = 1;
            lblDate.Text = "Август 22";
            lblDate.TextAlign = ContentAlignment.BottomRight;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            // 
            // lblDay
            // 
            lblDay.AutoEllipsis = true;
            lblDay.AutoSize = true;
            lblDay.BackColor = Color.Black;
            lblDay.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDay.ForeColor = Color.White;
            lblDay.Location = new Point(12, 82);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(89, 30);
            lblDay.TabIndex = 2;
            lblDay.Text = "Monday";
            lblDay.TextAlign = ContentAlignment.BottomLeft;
            lblDay.Click += lblDay_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 15);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.Move += pictureBox1_MouseDown;
            // 
            // timerSeter
            // 
            timerSeter.BackColor = Color.Black;
            timerSeter.ForeColor = Color.Transparent;
            timerSeter.Location = new Point(238, 53);
            timerSeter.Name = "timerSeter";
            timerSeter.Size = new Size(22, 23);
            timerSeter.TabIndex = 4;
            timerSeter.Text = ">";
            timerSeter.UseVisualStyleBackColor = false;
            timerSeter.Click += timerSeter_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(264, 130);
            Controls.Add(timerSeter);
            Controls.Add(pictureBox1);
            Controls.Add(lblDay);
            Controls.Add(lblDate);
            Controls.Add(lblTime);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Digital Clock";
            WindowState = FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private Label lblDate;
        private System.Windows.Forms.Timer timer;
        private Label lblDay;
        private PictureBox pictureBox1;
        private Button timerSeter;
    }
}