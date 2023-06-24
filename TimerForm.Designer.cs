namespace DigitalClock
{
    partial class TimerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SetWorkTime = new Button();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SetWorkTime
            // 
            SetWorkTime.BackColor = Color.Black;
            SetWorkTime.ForeColor = Color.White;
            SetWorkTime.Location = new Point(12, 30);
            SetWorkTime.Name = "SetWorkTime";
            SetWorkTime.Size = new Size(75, 23);
            SetWorkTime.TabIndex = 0;
            SetWorkTime.Text = ">";
            SetWorkTime.UseVisualStyleBackColor = false;
            SetWorkTime.Click += SetWorkTime_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(93, 30);
            label1.Name = "label1";
            label1.Size = new Size(203, 21);
            label1.TabIndex = 3;
            label1.Text = "Установить рабочее время";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(12, 59);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(93, 58);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 5;
            label2.Text = "Назад";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-11, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 32);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown_1;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseMove += pictureBox1_MouseMove_1;
            // 
            // TimerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(335, 103);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(SetWorkTime);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TimerForm";
            StartPosition = FormStartPosition.Manual;
            Text = "TimerForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SetWorkTime;
        private Label label1;
        private Button button1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}