namespace Практика2
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочитатиЗФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записатиУФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кінецьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.впорядкуватиЗаАлфавітомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аЯToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиЗміниУСпискуЗаписуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(606, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(598, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список всіх записів";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(2, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(596, 392);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Прізвище";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ім\'я";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Телефон";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Адреса";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(598, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редагування та пошук записів";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(335, 49);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(120, 22);
            this.textBox5.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(8, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 243);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Знайдено записів";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(451, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 36);
            this.button4.TabIndex = 7;
            this.button4.Text = "Наступний";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(402, 146);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(313, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "Стерти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Знайти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(402, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Попередній";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(414, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ім\'я";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Прізвище";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Адреса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(414, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Телефон";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Виберіть прізвище зі списку";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редагуватиToolStripMenuItem,
            this.проПрограмуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прочитатиЗФайлаToolStripMenuItem,
            this.записатиУФайлToolStripMenuItem,
            this.кінецьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(61, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // прочитатиЗФайлаToolStripMenuItem
            // 
            this.прочитатиЗФайлаToolStripMenuItem.Name = "прочитатиЗФайлаToolStripMenuItem";
            this.прочитатиЗФайлаToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.прочитатиЗФайлаToolStripMenuItem.Text = "Прочитати з файла";
            this.прочитатиЗФайлаToolStripMenuItem.Click += new System.EventHandler(this.прочитатиЗФайлаToolStripMenuItem_Click_1);
            // 
            // записатиУФайлToolStripMenuItem
            // 
            this.записатиУФайлToolStripMenuItem.Name = "записатиУФайлToolStripMenuItem";
            this.записатиУФайлToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.записатиУФайлToolStripMenuItem.Text = "Записати у файл";
            this.записатиУФайлToolStripMenuItem.Click += new System.EventHandler(this.записатиУФайлToolStripMenuItem_Click);
            // 
            // кінецьToolStripMenuItem
            // 
            this.кінецьToolStripMenuItem.Name = "кінецьToolStripMenuItem";
            this.кінецьToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.кінецьToolStripMenuItem.Text = "кінець";
            this.кінецьToolStripMenuItem.Click += new System.EventHandler(this.кінецьToolStripMenuItem_Click);
            // 
            // редагуватиToolStripMenuItem
            // 
            this.редагуватиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.впорядкуватиЗаАлфавітомToolStripMenuItem,
            this.зберегтиЗміниУСпискуЗаписуToolStripMenuItem});
            this.редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            this.редагуватиToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.редагуватиToolStripMenuItem.Text = "Редагувати";
            // 
            // впорядкуватиЗаАлфавітомToolStripMenuItem
            // 
            this.впорядкуватиЗаАлфавітомToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аЯToolStripMenuItem,
            this.яАToolStripMenuItem});
            this.впорядкуватиЗаАлфавітомToolStripMenuItem.Name = "впорядкуватиЗаАлфавітомToolStripMenuItem";
            this.впорядкуватиЗаАлфавітомToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.впорядкуватиЗаАлфавітомToolStripMenuItem.Text = "Впорядкувати за алфавітом";
            // 
            // аЯToolStripMenuItem
            // 
            this.аЯToolStripMenuItem.Name = "аЯToolStripMenuItem";
            this.аЯToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.аЯToolStripMenuItem.Text = "А → Я";
            this.аЯToolStripMenuItem.Click += new System.EventHandler(this.аЯToolStripMenuItem_Click);
            // 
            // яАToolStripMenuItem
            // 
            this.яАToolStripMenuItem.Name = "яАToolStripMenuItem";
            this.яАToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.яАToolStripMenuItem.Text = "Я → А";
            this.яАToolStripMenuItem.Click += new System.EventHandler(this.яАToolStripMenuItem_Click);
            // 
            // зберегтиЗміниУСпискуЗаписуToolStripMenuItem
            // 
            this.зберегтиЗміниУСпискуЗаписуToolStripMenuItem.Name = "зберегтиЗміниУСпискуЗаписуToolStripMenuItem";
            this.зберегтиЗміниУСпискуЗаписуToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.зберегтиЗміниУСпискуЗаписуToolStripMenuItem.Text = "Зберегти зміни у списку записів";
            this.зберегтиЗміниУСпискуЗаписуToolStripMenuItem.Click += new System.EventHandler(this.зберегтиЗміниУСпискуЗаписуToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Телефонний довідник";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem впорядкуватиЗаАлфавітомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиЗміниУСпискуЗаписуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочитатиЗФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записатиУФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кінецьToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ToolStripMenuItem аЯToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яАToolStripMenuItem;
    }
}

