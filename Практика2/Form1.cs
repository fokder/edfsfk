using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика2
{
    public partial class Form1 : Form
    {
        private void SortTable(bool reverse)
        {
            List<string[]> records = new List<string[]>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null &&
                    row.Cells[0].Value.ToString() != "")
                {
                    string[] person = new string[4];

                    for (int j = 0; j < 4; j++)
                    {
                        person[j] = row.Cells[j].Value?.ToString() ?? "";
                    }

                    records.Add(person);
                }
            }

            records.Sort((a, b) =>
                System.StringComparer.Create(
                    new System.Globalization.CultureInfo("uk-UA"), false)
                .Compare(a[0], b[0]));

            if (reverse)
                records.Reverse();

            updatingTable = true;

            try
            {
                dataGridView1.Rows.Clear();

                foreach (string[] person in records)
                {
                    dataGridView1.Rows.Add(person);
                }
            }
            finally
            {
                updatingTable = false;
            }

            newComboBox();
            changesMade = true;
        }
        public Form1()
        {
            InitializeComponent();

            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            this.FormClosing += Form1_FormClosing;
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!updatingTable && e.RowIndex >= 0)
            {
                changesMade = true;
                newComboBox();
            }
        }
        private void кінецьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        public struct info
        {
            public string SureName, name, adress, number;
        };

        info[] array = new info[100];
        int n = 0;
        bool changesMade = false;
        bool updatingTable = false;
        string filePath = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
    "Телефонний довідник",
    "data.txt");
        private void newComboBox()
        {
            n = 0;
            comboBox1.Items.Clear();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                object sureNameValue =
                    dataGridView1.Rows[i].Cells[0].Value;

                if (sureNameValue != null)
                {
                    string sureName = sureNameValue.ToString();
                    comboBox1.Items.Add(sureName);
                    n++;
                }
            }
        }

        private void SaveData(string path)
        {
            dataGridView1.EndEdit();

            string folder = Path.GetDirectoryName(path);
            Directory.CreateDirectory(folder);

            using (StreamWriter file = new StreamWriter(path))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    string surname = row.Cells[0].Value?.ToString() ?? "";
                    string name = row.Cells[1].Value?.ToString() ?? "";
                    string phone = row.Cells[2].Value?.ToString() ?? "";
                    string address = row.Cells[3].Value?.ToString() ?? "";

                    if (string.IsNullOrWhiteSpace(surname))
                        continue;

                    file.WriteLine(surname + "\t" +
                                   name + "\t" +
                                   phone + "\t" +
                                   address);
                }
            }

            changesMade = false;
        }



        private void прочитатиЗФайлаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл ще не створено!\n" + filePath);
                return;
            }

            if (changesMade)
            {
                DialogResult answer = MessageBox.Show(
                    "Незбережені зміни буде втрачено. Продовжити?",
                    "Читання файлу",
                    MessageBoxButtons.YesNo);

                if (answer == DialogResult.No)
                    return;
            }

            updatingTable = true;

            try
            {
                List<string[]> records = new List<string[]>();

                using (StreamReader file = new StreamReader(filePath))
                {
                    string line;

                    while ((line = file.ReadLine()) != null)
                    {
                        string[] data = line.Split('\t');

                        if (data.Length >= 4)
                        {
                            records.Add(new string[]
                            {
                        data[0],
                        data[1],
                        data[2],
                        data[3]
                            });
                        }
                    }
                }

                dataGridView1.Rows.Clear();

                foreach (string[] person in records)
                {
                    dataGridView1.Rows.Add(person);
                }

                newComboBox();
                changesMade = false;

                MessageBox.Show("Записи успішно завантажено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка читання: " + ex.Message);
            }
            finally
            {
                updatingTable = false;
            }
        }

        private void записатиУФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData(filePath);

                MessageBox.Show("Дані успішно збережено!\n" + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка запису: " + ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void зберегтиЗміниУСпискуЗаписуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Виберіть запис!");
                return;
            }

            dataGridView1.Rows[comboBox1.SelectedIndex].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[comboBox1.SelectedIndex].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[comboBox1.SelectedIndex].Cells[2].Value = textBox4.Text;
            dataGridView1.Rows[comboBox1.SelectedIndex].Cells[3].Value = textBox3.Text;

            newComboBox();
            changesMade = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string surname = textBox5.Text;
            bool found = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == surname)
                    {
                        textBox1.Text = dataGridView1.Rows[i].Cells[0].Value?.ToString() ?? "";
                        textBox2.Text = dataGridView1.Rows[i].Cells[1].Value?.ToString() ?? "";
                        textBox4.Text = dataGridView1.Rows[i].Cells[2].Value?.ToString() ?? "";
                        textBox3.Text = dataGridView1.Rows[i].Cells[3].Value?.ToString() ?? "";

                        found = true;
                        break;
                    }
                }
            }

            if (found == false)
            {
                MessageBox.Show("Такого прізвища немає!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

     
        }

        private void аЯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortTable(false);
        }

        private void яАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortTable(true);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridView1.EndEdit();

            if (changesMade == true)
            {
                DialogResult result = MessageBox.Show(
                    "Зберегти зміни перед виходом?",
                    "Телефонний довідник",
                    MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    SaveFileDialog save = new SaveFileDialog();

                    save.Filter = "Текстові файли (*.txt)|*.txt";
                    save.FileName = filePath;

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            SaveData(save.FileName);
                            filePath = save.FileName;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Помилка: " + ex.Message);
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }

                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}      
    
