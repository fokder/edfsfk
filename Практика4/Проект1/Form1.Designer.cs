namespace Практика4_Проект1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.catLabel = new System.Windows.Forms.Label();
            this.dogLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // timer1
            this.timer1.Enabled = false;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // timer2
            this.timer2.Enabled = false;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // pictureBox2
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Location = new System.Drawing.Point(10, 370);
            this.pictureBox2.Size = new System.Drawing.Size(145, 140);
            this.pictureBox2.Image = (System.Drawing.Image)resources.GetObject("box.Image");
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabStop = false;
            // pictureBox3
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Location = new System.Drawing.Point(180, 370);
            this.pictureBox3.Size = new System.Drawing.Size(145, 140);
            this.pictureBox3.Image = (System.Drawing.Image)resources.GetObject("box.Image");
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabStop = false;
            // catLabel
            this.catLabel.Name = "catLabel";
            this.catLabel.Location = new System.Drawing.Point(10, 345);
            this.catLabel.Size = new System.Drawing.Size(145, 22);
            this.catLabel.Text = "Коти";
            this.catLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // dogLabel
            this.dogLabel.Name = "dogLabel";
            this.dogLabel.Location = new System.Drawing.Point(180, 345);
            this.dogLabel.Size = new System.Drawing.Size(145, 22);
            this.dogLabel.Text = "Собаки";
            this.dogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // pictureBox1
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Location = new System.Drawing.Point(201, 0);
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.pictureBox1.MouseCaptureChanged += new System.EventHandler(this.pictureBox1_MouseCaptureChanged);
            // scoreLabel
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Location = new System.Drawing.Point(600, 12);
            this.scoreLabel.Size = new System.Drawing.Size(90, 18);
            this.scoreLabel.Text = "Бали:";
            // label1
            this.label1.Name = "label1";
            this.label1.Location = new System.Drawing.Point(600, 35);
            this.label1.Size = new System.Drawing.Size(90, 35);
            this.label1.Text = "0";
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            // timeLabel
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Location = new System.Drawing.Point(600, 80);
            this.timeLabel.Size = new System.Drawing.Size(90, 18);
            this.timeLabel.Text = "Час:";
            // label2
            this.label2.Name = "label2";
            this.label2.Location = new System.Drawing.Point(600, 103);
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.Text = "0.000";
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            // speedLabel
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Location = new System.Drawing.Point(590, 155);
            this.speedLabel.Size = new System.Drawing.Size(105, 40);
            this.speedLabel.Text = "Інтервал (мс):";
            // numericUpDown1
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Location = new System.Drawing.Point(600, 195);
            this.numericUpDown1.Size = new System.Drawing.Size(85, 24);
            this.numericUpDown1.Minimum = 10;
            this.numericUpDown1.Maximum = 200;
            this.numericUpDown1.Increment = 10;
            this.numericUpDown1.Value = 50;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // button1
            this.button1.Name = "button1";
            this.button1.Location = new System.Drawing.Point(590, 350);
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.Text = "Start";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // button2
            this.button2.Name = "button2";
            this.button2.Location = new System.Drawing.Point(590, 405);
            this.button2.Size = new System.Drawing.Size(100, 45);
            this.button2.Text = "Pause";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // button3
            this.button3.Name = "button3";
            this.button3.Location = new System.Drawing.Point(590, 460);
            this.button3.Size = new System.Drawing.Size(100, 45);
            this.button3.Text = "End";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 530);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form1";
            this.Text = "Form1 — Сортування зображень";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.catLabel);
            this.Controls.Add(this.dogLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label catLabel;
        private System.Windows.Forms.Label dogLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
