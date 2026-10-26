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
            this.shapeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fontButton = new System.Windows.Forms.Button();
            this.brushLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textLabel = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textXLabel = new System.Windows.Forms.Label();
            this.textX = new System.Windows.Forms.NumericUpDown();
            this.textYLabel = new System.Windows.Forms.Label();
            this.textY = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.components.Add(this.colorDialog1);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.components.Add(this.fontDialog1);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.components.Add(this.openFileDialog1);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.components.Add(this.saveFileDialog1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // shapeLabel
            this.shapeLabel.Location = new System.Drawing.Point(12, 12);
            this.shapeLabel.Size = new System.Drawing.Size(240, 20);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Text = "Фігура:";
            // comboBox1
            this.comboBox1.Location = new System.Drawing.Point(12, 36);
            this.comboBox1.Size = new System.Drawing.Size(240, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] { "Лінія", "Трикутник", "Еліпс", "Прямокутник" });
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // label1
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.Name = "label1";
            this.label1.Text = "X";
            this.label1.Visible = false;
            // textBox1
            this.textBox1.Location = new System.Drawing.Point(12, 96);
            this.textBox1.Size = new System.Drawing.Size(115, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Text = "30";
            this.textBox1.Visible = false;
            // label2
            this.label2.Location = new System.Drawing.Point(137, 76);
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.Name = "label2";
            this.label2.Text = "X";
            this.label2.Visible = false;
            // textBox2
            this.textBox2.Location = new System.Drawing.Point(137, 96);
            this.textBox2.Size = new System.Drawing.Size(115, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Text = "30";
            this.textBox2.Visible = false;
            // label3
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.Name = "label3";
            this.label3.Text = "X";
            this.label3.Visible = false;
            // textBox3
            this.textBox3.Location = new System.Drawing.Point(12, 146);
            this.textBox3.Size = new System.Drawing.Size(115, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Text = "180";
            this.textBox3.Visible = false;
            // label4
            this.label4.Location = new System.Drawing.Point(137, 126);
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.Name = "label4";
            this.label4.Text = "X";
            this.label4.Visible = false;
            // textBox4
            this.textBox4.Location = new System.Drawing.Point(137, 146);
            this.textBox4.Size = new System.Drawing.Size(115, 24);
            this.textBox4.Name = "textBox4";
            this.textBox4.Text = "120";
            this.textBox4.Visible = false;
            // label5
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.Name = "label5";
            this.label5.Text = "X";
            this.label5.Visible = false;
            // textBox5
            this.textBox5.Location = new System.Drawing.Point(12, 196);
            this.textBox5.Size = new System.Drawing.Size(115, 24);
            this.textBox5.Name = "textBox5";
            this.textBox5.Text = "80";
            this.textBox5.Visible = false;
            // label6
            this.label6.Location = new System.Drawing.Point(137, 176);
            this.label6.Size = new System.Drawing.Size(115, 18);
            this.label6.Name = "label6";
            this.label6.Text = "X";
            this.label6.Visible = false;
            // textBox6
            this.textBox6.Location = new System.Drawing.Point(137, 196);
            this.textBox6.Size = new System.Drawing.Size(115, 24);
            this.textBox6.Name = "textBox6";
            this.textBox6.Text = "200";
            this.textBox6.Visible = false;
            // checkBox1
            this.checkBox1.Location = new System.Drawing.Point(12, 230);
            this.checkBox1.Size = new System.Drawing.Size(240, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Text = "Заливка";
            this.checkBox1.Visible = false;
            // button1
            this.button1.Location = new System.Drawing.Point(12, 260);
            this.button1.Size = new System.Drawing.Size(115, 30);
            this.button1.Name = "button1";
            this.button1.Text = "Малювати";
            this.button1.Enabled = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // button2
            this.button2.Location = new System.Drawing.Point(137, 260);
            this.button2.Size = new System.Drawing.Size(115, 30);
            this.button2.Name = "button2";
            this.button2.Text = "Очистити";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // button3
            this.button3.Location = new System.Drawing.Point(12, 300);
            this.button3.Size = new System.Drawing.Size(115, 30);
            this.button3.Name = "button3";
            this.button3.Text = "Колір";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // fontButton
            this.fontButton.Location = new System.Drawing.Point(137, 300);
            this.fontButton.Size = new System.Drawing.Size(115, 30);
            this.fontButton.Name = "fontButton";
            this.fontButton.Text = "Шрифт";
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // brushLabel
            this.brushLabel.Location = new System.Drawing.Point(12, 344);
            this.brushLabel.Size = new System.Drawing.Size(150, 22);
            this.brushLabel.Name = "brushLabel";
            this.brushLabel.Text = "Товщина кисті:";
            // numericUpDown1
            this.numericUpDown1.Location = new System.Drawing.Point(172, 340);
            this.numericUpDown1.Size = new System.Drawing.Size(80, 25);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Minimum = 1;
            this.numericUpDown1.Maximum = 50;
            this.numericUpDown1.Value = 4;
            // textLabel
            this.textLabel.Location = new System.Drawing.Point(12, 380);
            this.textLabel.Size = new System.Drawing.Size(240, 20);
            this.textLabel.Name = "textLabel";
            this.textLabel.Text = "Текст для рисунка:";
            // textBox7
            this.textBox7.Location = new System.Drawing.Point(12, 404);
            this.textBox7.Size = new System.Drawing.Size(240, 90);
            this.textBox7.Name = "textBox7";
            this.textBox7.Text = "Приклад тексту";
            this.textBox7.Multiline = true;
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // textXLabel
            this.textXLabel.Location = new System.Drawing.Point(12, 506);
            this.textXLabel.Size = new System.Drawing.Size(24, 22);
            this.textXLabel.Name = "textXLabel";
            this.textXLabel.Text = "X:";
            // textX
            this.textX.Location = new System.Drawing.Point(38, 502);
            this.textX.Size = new System.Drawing.Size(85, 25);
            this.textX.Name = "textX";
            this.textX.Maximum = 759;
            this.textX.Value = 30;
            // textYLabel
            this.textYLabel.Location = new System.Drawing.Point(137, 506);
            this.textYLabel.Size = new System.Drawing.Size(24, 22);
            this.textYLabel.Name = "textYLabel";
            this.textYLabel.Text = "Y:";
            // textY
            this.textY.Location = new System.Drawing.Point(163, 502);
            this.textY.Size = new System.Drawing.Size(89, 25);
            this.textY.Name = "textY";
            this.textY.Maximum = 619;
            this.textY.Value = 30;
            // button4
            this.button4.Location = new System.Drawing.Point(12, 540);
            this.button4.Size = new System.Drawing.Size(240, 30);
            this.button4.Name = "button4";
            this.button4.Text = "Додати текст";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // openButton
            this.openButton.Location = new System.Drawing.Point(12, 585);
            this.openButton.Size = new System.Drawing.Size(115, 32);
            this.openButton.Name = "openButton";
            this.openButton.Text = "Відкрити";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // saveButton
            this.saveButton.Location = new System.Drawing.Point(137, 585);
            this.saveButton.Size = new System.Drawing.Size(115, 32);
            this.saveButton.Name = "saveButton";
            this.saveButton.Text = "Зберегти";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // pictureBox1
            this.pictureBox1.Location = new System.Drawing.Point(272, 12);
            this.pictureBox1.Size = new System.Drawing.Size(760, 620);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.pictureBox1.MouseCaptureChanged += new System.EventHandler(this.pictureBox1_MouseCaptureChanged);
            this.openFileDialog1.Filter = "Зображення|*.png;*.bmp;*.jpg;*.jpeg;*.gif";
            this.saveFileDialog1.Filter = "Зображення PNG (*.png)|*.png";
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.FileName = "Рисунок.png";
            this.fontDialog1.Font = new System.Drawing.Font("Arial", 14F);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 644);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form1";
            this.Text = "Практична №3 — Графічний редактор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Controls.Add(this.shapeLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.fontButton);
            this.Controls.Add(this.brushLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textXLabel);
            this.Controls.Add(this.textX);
            this.Controls.Add(this.textYLabel);
            this.Controls.Add(this.textY);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.Label brushLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label textXLabel;
        private System.Windows.Forms.NumericUpDown textX;
        private System.Windows.Forms.Label textYLabel;
        private System.Windows.Forms.NumericUpDown textY;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
