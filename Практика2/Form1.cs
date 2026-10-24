using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Практика2
{
    public partial class Form1 : Form
    {
        private bool changesMade;
        private string filePath = "data.txt";
        private TextBox[] fields;
        private readonly int[] limits = { 20, 20, 15, 100 };

        public Form1()
        {
            InitializeComponent();
            // Порядок полів такий самий, як порядок стовпців таблиці.
            fields = new[] { textBox1, textBox2, textBox4, textBox3 };
            for (int i = 0; i < fields.Length; i++)
                fields[i].MaxLength = limits[i];

            // Записи змінюємо через поля на другій вкладці.
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndexChanged += ShowRecord;
            button1.Click += (s, e) => SelectRecord(comboBox1.SelectedIndex - 1);
            button4.Click += (s, e) => SelectRecord(comboBox1.SelectedIndex + 1);
            button3.Text = "Видалити";
            groupBox1.Text = "Дані запису";
            зберегтиЗміниУСпискуЗаписуToolStripMenuItem.Text = "Додати / зберегти запис";
            редагуватиToolStripMenuItem.DropDownItems.Insert(0,
                new ToolStripMenuItem("Новий запис", null, NewRecord));
            FormClosing += Form1_FormClosing;
        }

        private void SelectRecord(int index)
        {
            if (index >= 0 && index < comboBox1.Items.Count)
                comboBox1.SelectedIndex = index;
        }

        private void ShowRecord(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            for (int i = 0; i < fields.Length; i++)
                fields[i].Text = index < 0 ? "" :
                    Convert.ToString(dataGridView1.Rows[index].Cells[i].Value);
            if (index >= 0)
                dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
        }

        private void UpdateList(int selectedIndex)
        {
            comboBox1.Items.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
                comboBox1.Items.Add(Convert.ToString(row.Cells[0].Value));
            SelectRecord(selectedIndex);
            ShowRecord(this, EventArgs.Empty);
        }

        private void NewRecord(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            ShowRecord(sender, e);
            tabControl1.SelectedTab = tabPage2;
            textBox1.Focus();
        }

        private void зберегтиЗміниУСпискуЗаписуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] record = new string[4];
            for (int i = 0; i < record.Length; i++)
            {
                record[i] = fields[i].Text.Trim();
                if (!ValidField(record[i], limits[i]))
                {
                    MessageBox.Show("Заповніть усі поля. Ліміти: прізвище та ім’я — 20, " +
                        "телефон — 15, адреса — 100 символів. Табуляція та переноси заборонені.");
                    return;
                }
            }

            int index = comboBox1.SelectedIndex;
            if (index < 0)
                index = dataGridView1.Rows.Add(record);
            else
                for (int i = 0; i < record.Length; i++)
                    dataGridView1.Rows[index].Cells[i].Value = record[i];
            changesMade = true;
            UpdateList(index);
        }

        private static bool ValidField(string value, int limit)
        {
            return !string.IsNullOrWhiteSpace(value) && value.Length <= limit &&
                value.IndexOfAny(new[] { '\t', '\r', '\n' }) < 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index < 0) return;
            dataGridView1.Rows.RemoveAt(index);
            changesMade = true;
            UpdateList(Math.Min(index, dataGridView1.Rows.Count - 1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBox1.Items.Count; i++)
                if (string.Equals(comboBox1.Items[i].ToString(), textBox5.Text.Trim(),
                    StringComparison.CurrentCultureIgnoreCase))
                {
                    SelectRecord(i);
                    return;
                }
            MessageBox.Show("Такого прізвища немає!");
        }

        // Файл: один запис у рядку, чотири поля розділено табуляцією.
        private List<string[]> GetRecords()
        {
            var records = new List<string[]>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string[] record = new string[4];
                for (int i = 0; i < record.Length; i++)
                    record[i] = Convert.ToString(row.Cells[i].Value);
                records.Add(record);
            }
            return records;
        }

        private bool SaveData()
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "Текстові файли (*.txt)|*.txt";
                dialog.FileName = filePath;
                if (dialog.ShowDialog() != DialogResult.OK) return false;
                try
                {
                    var lines = new List<string>();
                    foreach (string[] record in GetRecords())
                        lines.Add(string.Join("\t", record));
                    File.WriteAllLines(dialog.FileName, lines);
                    filePath = dialog.FileName;
                    changesMade = false;
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка запису: " + ex.Message);
                    return false;
                }
            }
        }

        private bool ConfirmChanges()
        {
            if (!changesMade) return true;
            DialogResult answer = MessageBox.Show("Зберегти зміни?", "Телефонний довідник",
                MessageBoxButtons.YesNoCancel);
            return answer == DialogResult.No || (answer == DialogResult.Yes && SaveData());
        }

        private void прочитатиЗФайлаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!ConfirmChanges()) return;
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Текстові файли (*.txt)|*.txt";
                if (dialog.ShowDialog() != DialogResult.OK) return;
                try
                {
                    // Спочатку перевіряємо весь файл, щоб не втратити поточні записи.
                    var records = new List<string[]>();
                    foreach (string line in File.ReadAllLines(dialog.FileName))
                    {
                        string[] record = line.Split('\t');
                        if (record.Length != 4)
                            throw new FormatException("Кожен рядок має містити чотири поля.");
                        for (int i = 0; i < record.Length; i++)
                            if (!ValidField(record[i], limits[i]))
                                throw new FormatException("Порожнє або надто довге поле у файлі.");
                        records.Add(record);
                    }
                    dataGridView1.Rows.Clear();
                    foreach (string[] record in records)
                        dataGridView1.Rows.Add(record);
                    filePath = dialog.FileName;
                    changesMade = false;
                    UpdateList(0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка читання: " + ex.Message);
                }
            }
        }

        // Порівнюємо літери за їхнім місцем в українському алфавіті.
        private static int CompareSurnames(string first, string second)
        {
            const string alphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";
            first = first.ToUpperInvariant();
            second = second.ToUpperInvariant();

            for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
            {
                int a = alphabet.IndexOf(first[i]);
                int b = alphabet.IndexOf(second[i]);
                // Інші символи розміщуємо після українських літер за кодом символу.
                if (a < 0) a = alphabet.Length + first[i];
                if (b < 0) b = alphabet.Length + second[i];
                if (a != b) return a.CompareTo(b);
            }
            return first.Length.CompareTo(second.Length);
        }

        private void SortTable(bool reverse)
        {
            var records = GetRecords();
            records.Sort((a, b) => CompareSurnames(a[0], b[0]));
            if (reverse) records.Reverse();
            dataGridView1.Rows.Clear();
            foreach (string[] record in records)
                dataGridView1.Rows.Add(record);
            UpdateList(0);
            changesMade = true;
        }

        private void аЯToolStripMenuItem_Click(object sender, EventArgs e) { SortTable(false); }
        private void яАToolStripMenuItem_Click(object sender, EventArgs e) { SortTable(true); }
        private void записатиУФайлToolStripMenuItem_Click(object sender, EventArgs e) { SaveData(); }
        private void кінецьToolStripMenuItem_Click(object sender, EventArgs e) { Close(); }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) { e.Cancel = !ConfirmChanges(); }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Form2())
                form.ShowDialog(this);
        }
    }
}
