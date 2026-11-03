namespace Індивідуальне1
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
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIssuedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelIssuedTo = new System.Windows.Forms.Label();
            this.textBoxIssuedTo = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.checkBoxIssued = new System.Windows.Forms.CheckBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateIssue = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // labelCount
            this.labelCount.Name = "labelCount";
            this.labelCount.Location = new System.Drawing.Point(12, 18);
            this.labelCount.Size = new System.Drawing.Size(450, 25);
            this.labelCount.Text = "Кількість записів: 10";
            // buttonSave
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Location = new System.Drawing.Point(748, 10);
            this.buttonSave.Size = new System.Drawing.Size(180, 32);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Зберегти все у файл";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // dataGridView1
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Size = new System.Drawing.Size(916, 275);
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            // columnName
            this.columnName.Name = "columnName";
            this.columnName.HeaderText = "Назва обладнання";
            this.columnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // columnIssuedTo
            this.columnIssuedTo.Name = "columnIssuedTo";
            this.columnIssuedTo.HeaderText = "Кому видано";
            this.columnIssuedTo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // columnQuantity
            this.columnQuantity.Name = "columnQuantity";
            this.columnQuantity.HeaderText = "Кількість";
            this.columnQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // columnState
            this.columnState.Name = "columnState";
            this.columnState.HeaderText = "Стан";
            this.columnState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // columnDate
            this.columnDate.Name = "columnDate";
            this.columnDate.HeaderText = "Дата видачі";
            this.columnDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // labelAdd
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Location = new System.Drawing.Point(12, 352);
            this.labelAdd.Size = new System.Drawing.Size(534, 25);
            this.labelAdd.Text = "Додавання запису";
            this.labelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            // labelName
            this.labelName.Name = "labelName";
            this.labelName.Location = new System.Drawing.Point(12, 390);
            this.labelName.Size = new System.Drawing.Size(90, 22);
            this.labelName.Text = "Назва:";
            // textBoxName
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Location = new System.Drawing.Point(104, 386);
            this.textBoxName.Size = new System.Drawing.Size(442, 24);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.MaxLength = 100;
            // labelIssuedTo
            this.labelIssuedTo.Name = "labelIssuedTo";
            this.labelIssuedTo.Location = new System.Drawing.Point(12, 430);
            this.labelIssuedTo.Size = new System.Drawing.Size(90, 22);
            this.labelIssuedTo.Text = "Кому видано:";
            // textBoxIssuedTo
            this.textBoxIssuedTo.Name = "textBoxIssuedTo";
            this.textBoxIssuedTo.Location = new System.Drawing.Point(104, 426);
            this.textBoxIssuedTo.Size = new System.Drawing.Size(442, 24);
            this.textBoxIssuedTo.TabIndex = 2;
            this.textBoxIssuedTo.MaxLength = 100;
            // labelQuantity
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Location = new System.Drawing.Point(12, 470);
            this.labelQuantity.Size = new System.Drawing.Size(90, 22);
            this.labelQuantity.Text = "Кількість:";
            // numericQuantity
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Location = new System.Drawing.Point(104, 466);
            this.numericQuantity.Size = new System.Drawing.Size(120, 24);
            this.numericQuantity.TabIndex = 3;
            this.numericQuantity.Minimum = 1;
            this.numericQuantity.Maximum = 10000;
            this.numericQuantity.Value = 1;
            // checkBoxIssued
            this.checkBoxIssued.Name = "checkBoxIssued";
            this.checkBoxIssued.Location = new System.Drawing.Point(260, 466);
            this.checkBoxIssued.Size = new System.Drawing.Size(286, 24);
            this.checkBoxIssued.TabIndex = 4;
            this.checkBoxIssued.Text = "Видано (інакше — повернуто)";
            this.checkBoxIssued.Checked = true;
            // labelDate
            this.labelDate.Name = "labelDate";
            this.labelDate.Location = new System.Drawing.Point(12, 510);
            this.labelDate.Size = new System.Drawing.Size(90, 22);
            this.labelDate.Text = "Дата видачі:";
            // dateIssue
            this.dateIssue.Name = "dateIssue";
            this.dateIssue.Location = new System.Drawing.Point(104, 506);
            this.dateIssue.Size = new System.Drawing.Size(442, 24);
            this.dateIssue.TabIndex = 5;
            this.dateIssue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateIssue.CustomFormat = "dd.MM.yyyy";
            // buttonAdd
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Location = new System.Drawing.Point(12, 555);
            this.buttonAdd.Size = new System.Drawing.Size(534, 35);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Додати запис";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // labelSearch
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Location = new System.Drawing.Point(580, 352);
            this.labelSearch.Size = new System.Drawing.Size(348, 25);
            this.labelSearch.Text = "Пошук за назвою";
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            // textBoxSearch
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Location = new System.Drawing.Point(580, 388);
            this.textBoxSearch.Size = new System.Drawing.Size(218, 24);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.Text = "Мікроскоп";
            this.textBoxSearch.MaxLength = 100;
            // buttonSearch
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Location = new System.Drawing.Point(810, 384);
            this.buttonSearch.Size = new System.Drawing.Size(118, 32);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Знайти";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // labelResult
            this.labelResult.Name = "labelResult";
            this.labelResult.Location = new System.Drawing.Point(580, 430);
            this.labelResult.Size = new System.Drawing.Size(348, 22);
            this.labelResult.Text = "Знайдені записи (всі поля):";
            // listBox1
            this.listBox1.Name = "listBox1";
            this.listBox1.Location = new System.Drawing.Point(580, 454);
            this.listBox1.Size = new System.Drawing.Size(348, 136);
            this.listBox1.TabIndex = 9;
            this.listBox1.HorizontalScrollbar = true;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.columnName, this.columnIssuedTo, this.columnQuantity, this.columnState, this.columnDate });
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 610);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form1";
            this.Text = "Варіант 1 — Дослідна лабораторія";
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelIssuedTo);
            this.Controls.Add(this.textBoxIssuedTo);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.checkBoxIssued);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateIssue);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.listBox1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIssuedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnState;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelIssuedTo;
        private System.Windows.Forms.TextBox textBoxIssuedTo;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.CheckBox checkBoxIssued;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateIssue;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ListBox listBox1;
    }
}
