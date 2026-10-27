namespace Практика3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.components.Add(this.colorDialog1);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.components.Add(this.fontDialog1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // pictureBox1
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Size = new System.Drawing.Size(680, 666);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.pictureBox1.MouseCaptureChanged += new System.EventHandler(this.pictureBox1_MouseCaptureChanged);
            // comboBox1
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Location = new System.Drawing.Point(716, 22);
            this.comboBox1.Size = new System.Drawing.Size(140, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] { "Line", "Triangle", "Ellipse", "Rectangle" });
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // button1
            this.button1.Name = "button1";
            this.button1.Location = new System.Drawing.Point(716, 55);
            this.button1.Size = new System.Drawing.Size(140, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Paint";
            this.button1.Enabled = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // checkBox1
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Location = new System.Drawing.Point(716, 92);
            this.checkBox1.Size = new System.Drawing.Size(140, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "fill";
            this.checkBox1.Visible = false;
            // textBox1
            this.textBox1.Name = "textBox1";
            this.textBox1.Location = new System.Drawing.Point(716, 116);
            this.textBox1.Size = new System.Drawing.Size(140, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "50";
            this.textBox1.Visible = false;
            // textBox2
            this.textBox2.Name = "textBox2";
            this.textBox2.Location = new System.Drawing.Point(716, 142);
            this.textBox2.Size = new System.Drawing.Size(140, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "50";
            this.textBox2.Visible = false;
            // textBox3
            this.textBox3.Name = "textBox3";
            this.textBox3.Location = new System.Drawing.Point(716, 168);
            this.textBox3.Size = new System.Drawing.Size(140, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "100";
            this.textBox3.Visible = false;
            // textBox4
            this.textBox4.Name = "textBox4";
            this.textBox4.Location = new System.Drawing.Point(716, 194);
            this.textBox4.Size = new System.Drawing.Size(140, 22);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "75";
            this.textBox4.Visible = false;
            // textBox5
            this.textBox5.Name = "textBox5";
            this.textBox5.Location = new System.Drawing.Point(716, 220);
            this.textBox5.Size = new System.Drawing.Size(140, 22);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "150";
            this.textBox5.Visible = false;
            // textBox6
            this.textBox6.Name = "textBox6";
            this.textBox6.Location = new System.Drawing.Point(716, 246);
            this.textBox6.Size = new System.Drawing.Size(140, 22);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "200";
            this.textBox6.Visible = false;
            // label1
            this.label1.Name = "label1";
            this.label1.Location = new System.Drawing.Point(716, 285);
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "brush size";
            // numericUpDown1
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Location = new System.Drawing.Point(716, 306);
            this.numericUpDown1.Size = new System.Drawing.Size(140, 24);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Minimum = 1;
            this.numericUpDown1.Maximum = 50;
            this.numericUpDown1.Value = 3;
            // button3
            this.button3.Name = "button3";
            this.button3.Location = new System.Drawing.Point(716, 338);
            this.button3.Size = new System.Drawing.Size(140, 32);
            this.button3.TabIndex = 12;
            this.button3.Text = "Color";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // textBox7
            this.textBox7.Name = "textBox7";
            this.textBox7.Location = new System.Drawing.Point(716, 378);
            this.textBox7.Size = new System.Drawing.Size(140, 54);
            this.textBox7.TabIndex = 13;
            this.textBox7.Text = "";
            this.textBox7.Multiline = true;
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // button4
            this.button4.Name = "button4";
            this.button4.Location = new System.Drawing.Point(716, 440);
            this.button4.Size = new System.Drawing.Size(140, 32);
            this.button4.TabIndex = 14;
            this.button4.Text = "Text";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // button2
            this.button2.Name = "button2";
            this.button2.Location = new System.Drawing.Point(716, 480);
            this.button2.Size = new System.Drawing.Size(140, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "Clear";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // label2
            this.label2.Name = "label2";
            this.label2.Location = new System.Drawing.Point(716, 522);
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Координати тексту X, Y:";
            // textBox8
            this.textBox8.Name = "textBox8";
            this.textBox8.Location = new System.Drawing.Point(716, 544);
            this.textBox8.Size = new System.Drawing.Size(65, 22);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "150";
            // textBox9
            this.textBox9.Name = "textBox9";
            this.textBox9.Location = new System.Drawing.Point(791, 544);
            this.textBox9.Size = new System.Drawing.Size(65, 22);
            this.textBox9.TabIndex = 18;
            this.textBox9.Text = "50";
            // button5
            this.button5.Name = "button5";
            this.button5.Location = new System.Drawing.Point(716, 578);
            this.button5.Size = new System.Drawing.Size(140, 28);
            this.button5.TabIndex = 19;
            this.button5.Text = "Шрифт";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // button6
            this.button6.Name = "button6";
            this.button6.Location = new System.Drawing.Point(716, 614);
            this.button6.Size = new System.Drawing.Size(140, 28);
            this.button6.TabIndex = 20;
            this.button6.Text = "Зберегти рисунок";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // button7
            this.button7.Name = "button7";
            this.button7.Location = new System.Drawing.Point(716, 650);
            this.button7.Size = new System.Drawing.Size(140, 28);
            this.button7.TabIndex = 21;
            this.button7.Text = "Відкрити Form2";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 690);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form1";
            this.Text = "Painting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}
