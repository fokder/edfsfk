namespace Індивідуальне13
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
            this.columnBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.labelPlate = new System.Windows.Forms.Label();
            this.textBoxPlate = new System.Windows.Forms.TextBox();
            this.labelDriver = new System.Windows.Forms.Label();
            this.textBoxDriver = new System.Windows.Forms.TextBox();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.numericCapacity = new System.Windows.Forms.NumericUpDown();
            this.checkBoxTrip = new System.Windows.Forms.CheckBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateDeparture = new System.Windows.Forms.DateTimePicker();
            this.labelDays = new System.Windows.Forms.Label();
            this.numericDays = new System.Windows.Forms.NumericUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelFree = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.numericCargo = new System.Windows.Forms.NumericUpDown();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCargo)).BeginInit();
            this.SuspendLayout();
            // labelCount
            this.labelCount.Name = "labelCount";
            this.labelCount.Location = new System.Drawing.Point(12, 18);
            this.labelCount.Size = new System.Drawing.Size(450, 25);
            this.labelCount.Text = "Кількість автомобілів: 10";
            // buttonSave
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Location = new System.Drawing.Point(838, 10);
            this.buttonSave.Size = new System.Drawing.Size(200, 32);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Зберегти все у файл";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // dataGridView1
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Size = new System.Drawing.Size(1026, 275);
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            // columnBrand
            this.columnBrand.Name = "columnBrand";
            this.columnBrand.HeaderText = "Марка";
            this.columnBrand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // columnPlate
            this.columnPlate.Name = "columnPlate";
            this.columnPlate.HeaderText = "Номерний знак";
            this.columnPlate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // columnDriver
            this.columnDriver.Name = "columnDriver";
            this.columnDriver.HeaderText = "Водій";
            this.columnDriver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // columnCapacity
            this.columnCapacity.Name = "columnCapacity";
            this.columnCapacity.HeaderText = "Вантажопідйомність (т)";
            this.columnCapacity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // columnTrip
            this.columnTrip.Name = "columnTrip";
            this.columnTrip.HeaderText = "У рейсі";
            this.columnTrip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // columnDate
            this.columnDate.Name = "columnDate";
            this.columnDate.HeaderText = "Дата виїзду";
            this.columnDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // columnDays
            this.columnDays.Name = "columnDays";
            this.columnDays.HeaderText = "Тривалість (дні)";
            this.columnDays.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // labelAdd
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Location = new System.Drawing.Point(12, 352);
            this.labelAdd.Size = new System.Drawing.Size(635, 25);
            this.labelAdd.Text = "Додавання автомобіля";
            this.labelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            // labelBrand
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Location = new System.Drawing.Point(12, 390);
            this.labelBrand.Size = new System.Drawing.Size(90, 22);
            this.labelBrand.Text = "Марка:";
            // textBoxBrand
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Location = new System.Drawing.Point(112, 386);
            this.textBoxBrand.Size = new System.Drawing.Size(210, 24);
            this.textBoxBrand.TabIndex = 1;
            this.textBoxBrand.MaxLength = 100;
            // labelPlate
            this.labelPlate.Name = "labelPlate";
            this.labelPlate.Location = new System.Drawing.Point(340, 390);
            this.labelPlate.Size = new System.Drawing.Size(120, 22);
            this.labelPlate.Text = "Номерний знак:";
            // textBoxPlate
            this.textBoxPlate.Name = "textBoxPlate";
            this.textBoxPlate.Location = new System.Drawing.Point(462, 386);
            this.textBoxPlate.Size = new System.Drawing.Size(185, 24);
            this.textBoxPlate.TabIndex = 2;
            this.textBoxPlate.MaxLength = 20;
            // labelDriver
            this.labelDriver.Name = "labelDriver";
            this.labelDriver.Location = new System.Drawing.Point(12, 430);
            this.labelDriver.Size = new System.Drawing.Size(90, 22);
            this.labelDriver.Text = "Водій:";
            // textBoxDriver
            this.textBoxDriver.Name = "textBoxDriver";
            this.textBoxDriver.Location = new System.Drawing.Point(112, 426);
            this.textBoxDriver.Size = new System.Drawing.Size(535, 24);
            this.textBoxDriver.TabIndex = 3;
            this.textBoxDriver.MaxLength = 100;
            // labelCapacity
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Location = new System.Drawing.Point(12, 470);
            this.labelCapacity.Size = new System.Drawing.Size(184, 22);
            this.labelCapacity.Text = "Вантажопідйомність (т):";
            // numericCapacity
            this.numericCapacity.Name = "numericCapacity";
            this.numericCapacity.Location = new System.Drawing.Point(200, 466);
            this.numericCapacity.Size = new System.Drawing.Size(122, 24);
            this.numericCapacity.TabIndex = 4;
            this.numericCapacity.DecimalPlaces = 2;
            this.numericCapacity.Minimum = 0.01M;
            this.numericCapacity.Maximum = 1000;
            this.numericCapacity.Value = 3.5M;
            // checkBoxTrip
            this.checkBoxTrip.Name = "checkBoxTrip";
            this.checkBoxTrip.Location = new System.Drawing.Point(340, 466);
            this.checkBoxTrip.Size = new System.Drawing.Size(307, 24);
            this.checkBoxTrip.TabIndex = 5;
            this.checkBoxTrip.Text = "Автомобіль у рейсі";
            this.checkBoxTrip.CheckedChanged += new System.EventHandler(this.checkBoxTrip_CheckedChanged);
            // labelDate
            this.labelDate.Name = "labelDate";
            this.labelDate.Location = new System.Drawing.Point(12, 510);
            this.labelDate.Size = new System.Drawing.Size(100, 22);
            this.labelDate.Text = "Дата виїзду:";
            // dateDeparture
            this.dateDeparture.Name = "dateDeparture";
            this.dateDeparture.Location = new System.Drawing.Point(112, 506);
            this.dateDeparture.Size = new System.Drawing.Size(210, 24);
            this.dateDeparture.TabIndex = 6;
            this.dateDeparture.Enabled = false;
            this.dateDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDeparture.CustomFormat = "dd.MM.yyyy";
            // labelDays
            this.labelDays.Name = "labelDays";
            this.labelDays.Location = new System.Drawing.Point(340, 510);
            this.labelDays.Size = new System.Drawing.Size(120, 22);
            this.labelDays.Text = "Тривалість (дні):";
            // numericDays
            this.numericDays.Name = "numericDays";
            this.numericDays.Location = new System.Drawing.Point(462, 506);
            this.numericDays.Size = new System.Drawing.Size(185, 24);
            this.numericDays.TabIndex = 7;
            this.numericDays.Enabled = false;
            this.numericDays.Minimum = 1;
            this.numericDays.Maximum = 3650;
            this.numericDays.Value = 1;
            // buttonAdd
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Location = new System.Drawing.Point(12, 555);
            this.buttonAdd.Size = new System.Drawing.Size(635, 35);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Додати автомобіль";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // labelFree
            this.labelFree.Name = "labelFree";
            this.labelFree.Location = new System.Drawing.Point(12, 603);
            this.labelFree.Size = new System.Drawing.Size(635, 25);
            this.labelFree.Text = "Для вільного автомобіля дата виїзду й тривалість не задаються.";
            // labelSearch
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Location = new System.Drawing.Point(680, 352);
            this.labelSearch.Size = new System.Drawing.Size(358, 25);
            this.labelSearch.Text = "Пошук вільних автомобілів";
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            // labelCargo
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Location = new System.Drawing.Point(680, 388);
            this.labelCargo.Size = new System.Drawing.Size(358, 22);
            this.labelCargo.Text = "Маса вантажу (т):";
            // numericCargo
            this.numericCargo.Name = "numericCargo";
            this.numericCargo.Location = new System.Drawing.Point(680, 418);
            this.numericCargo.Size = new System.Drawing.Size(150, 24);
            this.numericCargo.TabIndex = 9;
            this.numericCargo.DecimalPlaces = 2;
            this.numericCargo.Minimum = 0.01M;
            this.numericCargo.Maximum = 1000;
            this.numericCargo.Value = 3.5M;
            // buttonSearch
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Location = new System.Drawing.Point(844, 414);
            this.buttonSearch.Size = new System.Drawing.Size(194, 32);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Знайти";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // labelResult
            this.labelResult.Name = "labelResult";
            this.labelResult.Location = new System.Drawing.Point(680, 452);
            this.labelResult.Size = new System.Drawing.Size(358, 22);
            this.labelResult.Text = "Марка | номер | місткість | водій";
            // listBox1
            this.listBox1.Name = "listBox1";
            this.listBox1.Location = new System.Drawing.Point(680, 480);
            this.listBox1.Size = new System.Drawing.Size(358, 140);
            this.listBox1.TabIndex = 11;
            this.listBox1.HorizontalScrollbar = true;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.columnBrand, this.columnPlate, this.columnDriver, this.columnCapacity, this.columnTrip, this.columnDate, this.columnDays });
            this.columnCapacity.DefaultCellStyle.Format = "0.##";
            this.columnCapacity.FillWeight = 140F;
            this.columnTrip.FillWeight = 60F;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form1";
            this.Text = "Варіант 13 — Автотранспортне підприємство";
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.labelPlate);
            this.Controls.Add(this.textBoxPlate);
            this.Controls.Add(this.labelDriver);
            this.Controls.Add(this.textBoxDriver);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.numericCapacity);
            this.Controls.Add(this.checkBoxTrip);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateDeparture);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.numericDays);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelFree);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.numericCargo);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.listBox1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDays;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label labelPlate;
        private System.Windows.Forms.TextBox textBoxPlate;
        private System.Windows.Forms.Label labelDriver;
        private System.Windows.Forms.TextBox textBoxDriver;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.NumericUpDown numericCapacity;
        private System.Windows.Forms.CheckBox checkBoxTrip;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateDeparture;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.NumericUpDown numericDays;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelFree;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.NumericUpDown numericCargo;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ListBox listBox1;
    }
}
