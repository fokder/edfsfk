using System;
using System.IO;
using System.Windows.Forms;

namespace Індивідуальне1
{
    public partial class Form1 : Form
    {
        // П’ять полів відповідно до завдання.
        private struct Equipment
        {
            public string Name;
            public string IssuedTo;
            public int Quantity;
            public bool IsIssued;
            public DateTime IssueDate;
        }

        // Десять навчальних записів. Одна назва може мати кілька записів.
        private Equipment[] equipment =
        {
            new Equipment { Name = "Мікроскоп", IssuedTo = "Коваль", Quantity = 2, IsIssued = true, IssueDate = DateTime.Today.AddDays(-3) },
            new Equipment { Name = "Мікроскоп", IssuedTo = "Шевченко", Quantity = 1, IsIssued = false, IssueDate = DateTime.Today.AddDays(-10) },
            new Equipment { Name = "Термометр", IssuedTo = "Бондар", Quantity = 5, IsIssued = true, IssueDate = DateTime.Today.AddDays(-2) },
            new Equipment { Name = "Терези", IssuedTo = "Мельник", Quantity = 1, IsIssued = true, IssueDate = DateTime.Today.AddDays(-1) },
            new Equipment { Name = "Пробірка", IssuedTo = "Кравченко", Quantity = 20, IsIssued = false, IssueDate = DateTime.Today.AddDays(-7) },
            new Equipment { Name = "Колба", IssuedTo = "Олійник", Quantity = 10, IsIssued = true, IssueDate = DateTime.Today },
            new Equipment { Name = "Центрифуга", IssuedTo = "Ткаченко", Quantity = 1, IsIssued = false, IssueDate = DateTime.Today.AddDays(-5) },
            new Equipment { Name = "Вольтметр", IssuedTo = "Савченко", Quantity = 3, IsIssued = true, IssueDate = DateTime.Today.AddDays(-4) },
            new Equipment { Name = "Осцилограф", IssuedTo = "Петренко", Quantity = 1, IsIssued = false, IssueDate = DateTime.Today.AddDays(-6) },
            new Equipment { Name = "Термометр", IssuedTo = "Романенко", Quantity = 2, IsIssued = false, IssueDate = DateTime.Today.AddDays(-8) }
        };

        public Form1()
        {
            InitializeComponent();
            ShowEquipment();
        }

        private void ShowEquipment()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < equipment.Length; i++)
            {
                dataGridView1.Rows.Add(equipment[i].Name, equipment[i].IssuedTo,
                    equipment[i].Quantity, equipment[i].IsIssued ? "Видано" : "Повернуто",
                    equipment[i].IssueDate.ToString("dd.MM.yyyy"));
            }
            labelCount.Text = "Кількість записів: " + equipment.Length;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string name = textBoxSearch.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("Уведіть назву обладнання.");
                return;
            }
            for (int i = 0; i < equipment.Length; i++)
            {
                if (string.Equals(equipment[i].Name, name, StringComparison.OrdinalIgnoreCase))
                    listBox1.Items.Add(equipment[i].Name + " | " + equipment[i].IssuedTo +
                        " | " + equipment[i].Quantity + " шт. | " +
                        (equipment[i].IsIssued ? "Видано" : "Повернуто") + " | " +
                        equipment[i].IssueDate.ToString("dd.MM.yyyy"));
            }
            if (listBox1.Items.Count == 0)
                listBox1.Items.Add("Обладнання з такою назвою не знайдено.");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string issuedTo = textBoxIssuedTo.Text.Trim();
            if (name == "" || issuedTo == "")
            {
                MessageBox.Show("Укажіть назву обладнання та кому його видано.");
                return;
            }
            if (name.Contains("\t") || issuedTo.Contains("\t"))
            {
                MessageBox.Show("Текстові поля не повинні містити табуляцію.");
                return;
            }

            Equipment item = new Equipment();
            item.Name = name;
            item.IssuedTo = issuedTo;
            item.Quantity = (int)numericQuantity.Value;
            item.IsIssued = checkBoxIssued.Checked;
            item.IssueDate = dateIssue.Value.Date;

            Array.Resize(ref equipment, equipment.Length + 1);
            equipment[equipment.Length - 1] = item;
            ShowEquipment();
            listBox1.Items.Clear();
            textBoxName.Clear();
            textBoxName.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Текстовий файл (*.txt)|*.txt";
                dialog.FileName = "Обладнання_лабораторії.txt";
                if (dialog.ShowDialog() != DialogResult.OK) return;
                try
                {
                    using (StreamWriter file = new StreamWriter(dialog.FileName))
                    {
                        file.WriteLine("Назва\tКому видано\tКількість\tСтан\tДата видачі");
                        for (int i = 0; i < equipment.Length; i++)
                        {
                            file.WriteLine(equipment[i].Name + "\t" + equipment[i].IssuedTo +
                                "\t" + equipment[i].Quantity + "\t" +
                                (equipment[i].IsIssued ? "Видано" : "Повернуто") + "\t" +
                                equipment[i].IssueDate.ToString("dd.MM.yyyy"));
                        }
                    }
                    MessageBox.Show("Усі записи збережено у файл.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка збереження: " + ex.Message);
                }
            }
        }
    }
}
