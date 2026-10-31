namespace Індивідуальне7
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
            this.columnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.numericWeight = new System.Windows.Forms.NumericUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).BeginInit();
            this.SuspendLayout();
            // labelCount
            this.labelCount.Name = "labelCount";
            this.labelCount.Location = new System.Drawing.Point(12, 18);
            this.labelCount.Size = new System.Drawing.Size(330, 25);
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
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            // columnName
            this.columnName.Name = "columnName";
            this.columnName.HeaderText = "Назва";
            this.columnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // columnType
            this.columnType.Name = "columnType";
            this.columnType.HeaderText = "Тип";
            this.columnType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // columnPrice
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.HeaderText = "Ціна (грн)";
            this.columnPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // columnWeight
            this.columnWeight.Name = "columnWeight";
            this.columnWeight.HeaderText = "Маса (г)";
            this.columnWeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // columnManufacturer
            this.columnManufacturer.Name = "columnManufacturer";
            this.columnManufacturer.HeaderText = "Виробник";
            this.columnManufacturer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // labelAdd
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Location = new System.Drawing.Point(12, 352);
            this.labelAdd.Size = new System.Drawing.Size(534, 25);
            this.labelAdd.Text = "Додавання виробу";
            this.labelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            // labelName
            this.labelName.Name = "labelName";
            this.labelName.Location = new System.Drawing.Point(12, 391);
            this.labelName.Size = new System.Drawing.Size(90, 22);
            this.labelName.Text = "Назва:";
            // textBoxName
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Location = new System.Drawing.Point(104, 388);
            this.textBoxName.Size = new System.Drawing.Size(442, 24);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.MaxLength = 100;
            // labelType
            this.labelType.Name = "labelType";
            this.labelType.Location = new System.Drawing.Point(12, 431);
            this.labelType.Size = new System.Drawing.Size(90, 22);
            this.labelType.Text = "Тип:";
            // textBoxType
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Location = new System.Drawing.Point(104, 428);
            this.textBoxType.Size = new System.Drawing.Size(442, 24);
            this.textBoxType.TabIndex = 2;
            this.textBoxType.MaxLength = 100;
            // labelManufacturer
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Location = new System.Drawing.Point(12, 471);
            this.labelManufacturer.Size = new System.Drawing.Size(90, 22);
            this.labelManufacturer.Text = "Виробник:";
            // textBoxManufacturer
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Location = new System.Drawing.Point(104, 468);
            this.textBoxManufacturer.Size = new System.Drawing.Size(442, 24);
            this.textBoxManufacturer.TabIndex = 3;
            this.textBoxManufacturer.MaxLength = 100;
            // labelPrice
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Location = new System.Drawing.Point(12, 511);
            this.labelPrice.Size = new System.Drawing.Size(90, 22);
            this.labelPrice.Text = "Ціна (грн):";
            // numericPrice
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Location = new System.Drawing.Point(104, 508);
            this.numericPrice.Size = new System.Drawing.Size(120, 24);
            this.numericPrice.TabIndex = 4;
            this.numericPrice.DecimalPlaces = 2;
            this.numericPrice.Minimum = 0.01M;
            this.numericPrice.Maximum = 1000000M;
            this.numericPrice.Value = 50M;
            // labelWeight
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Location = new System.Drawing.Point(260, 511);
            this.labelWeight.Size = new System.Drawing.Size(90, 22);
            this.labelWeight.Text = "Маса (г):";
            // numericWeight
            this.numericWeight.Name = "numericWeight";
            this.numericWeight.Location = new System.Drawing.Point(350, 508);
            this.numericWeight.Size = new System.Drawing.Size(196, 24);
            this.numericWeight.TabIndex = 5;
            this.numericWeight.Minimum = 1;
            this.numericWeight.Maximum = 100000;
            this.numericWeight.Value = 100;
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
            this.labelSearch.Text = "Пошук за типом";
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            // textBoxSearch
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Location = new System.Drawing.Point(580, 388);
            this.textBoxSearch.Size = new System.Drawing.Size(218, 24);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.Text = "Торт";
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
            this.labelResult.Text = "Результат: назва та ціна";
            // listBox1
            this.listBox1.Name = "listBox1";
            this.listBox1.Location = new System.Drawing.Point(580, 454);
            this.listBox1.Size = new System.Drawing.Size(348, 136);
            this.listBox1.TabIndex = 9;
            this.listBox1.HorizontalScrollbar = true;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.columnName, this.columnType, this.columnPrice, this.columnWeight, this.columnManufacturer });
            this.columnPrice.DefaultCellStyle.Format = "0.00";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 610);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form1";
            this.Text = "Варіант 7 — Магазин кондитерських виробів";
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.textBoxManufacturer);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.numericWeight);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.listBox1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnManufacturer;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.NumericUpDown numericWeight;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ListBox listBox1;
    }
}
