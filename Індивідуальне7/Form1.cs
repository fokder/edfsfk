using System;
using System.IO;
using System.Windows.Forms;

namespace Індивідуальне7
{
    public partial class Form1 : Form
    {
        // Структура містить п’ять полів, як вимагає завдання.
        private struct Product
        {
            public string Name;
            public string Type;
            public decimal Price;
            public int Weight;
            public string Manufacturer;
        }

        // Масив із десяти початкових записів. Ціни — навчальні приклади.
        private Product[] products =
        {
            new Product { Name = "Медовик", Type = "Торт", Price = 450, Weight = 1000, Manufacturer = "Солодка мрія" },
            new Product { Name = "Наполеон", Type = "Торт", Price = 480, Weight = 1000, Manufacturer = "Домашня пекарня" },
            new Product { Name = "Шоколадний", Type = "Торт", Price = 520, Weight = 1200, Manufacturer = "Солодка мрія" },
            new Product { Name = "Вівсяне", Type = "Печиво", Price = 75, Weight = 300, Manufacturer = "Домашня пекарня" },
            new Product { Name = "Пісочне", Type = "Печиво", Price = 80, Weight = 300, Manufacturer = "Смакота" },
            new Product { Name = "Горішки", Type = "Печиво", Price = 110, Weight = 250, Manufacturer = "Смакота" },
            new Product { Name = "Карамель", Type = "Цукерки", Price = 65, Weight = 200, Manufacturer = "Солодкий світ" },
            new Product { Name = "Трюфель", Type = "Цукерки", Price = 130, Weight = 200, Manufacturer = "Солодкий світ" },
            new Product { Name = "Еклер", Type = "Тістечко", Price = 45, Weight = 100, Manufacturer = "Домашня пекарня" },
            new Product { Name = "Картопля", Type = "Тістечко", Price = 40, Weight = 100, Manufacturer = "Смакота" }
        };

        public Form1()
        {
            InitializeComponent();
            ShowProducts();
        }

        // Виведення всього масиву в таблицю.
        private void ShowProducts()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < products.Length; i++)
            {
                dataGridView1.Rows.Add(products[i].Name, products[i].Type,
                    products[i].Price, products[i].Weight, products[i].Manufacturer);
            }
            labelCount.Text = "Кількість записів: " + products.Length;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string type = textBoxSearch.Text.Trim();
            if (type == "")
            {
                MessageBox.Show("Уведіть тип, наприклад: Торт, Печиво, Цукерки або Тістечко.");
                return;
            }

            for (int i = 0; i < products.Length; i++)
            {
                // Порівнюємо типи без урахування великих і малих літер.
                if (string.Equals(products[i].Type, type, StringComparison.OrdinalIgnoreCase))
                    listBox1.Items.Add(products[i].Name + " — " +
                        products[i].Price.ToString("0.00") + " грн");
            }
            if (listBox1.Items.Count == 0)
                listBox1.Items.Add("Виробів такого типу немає.");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string type = textBoxType.Text.Trim();
            string manufacturer = textBoxManufacturer.Text.Trim();
            if (name == "" || type == "" || manufacturer == "")
            {
                MessageBox.Show("Заповніть назву, тип і виробника.");
                return;
            }
            // Табуляція розділяє поля у файлі, тому всередині значень її не допускаємо.
            if (name.Contains("\t") || type.Contains("\t") || manufacturer.Contains("\t"))
            {
                MessageBox.Show("Поля не повинні містити табуляцію.");
                return;
            }

            Product product = new Product();
            product.Name = name;
            product.Type = type;
            product.Price = numericPrice.Value;
            product.Weight = (int)numericWeight.Value;
            product.Manufacturer = manufacturer;

            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
            ShowProducts();
            listBox1.Items.Clear();
            textBoxName.Clear();
            textBoxName.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Текстовий файл (*.txt)|*.txt";
                dialog.FileName = "Кондитерські_вироби.txt";
                if (dialog.ShowDialog() != DialogResult.OK) return;
                try
                {
                    using (StreamWriter file = new StreamWriter(dialog.FileName))
                    {
                        file.WriteLine("Назва\tТип\tЦіна (грн)\tМаса (г)\tВиробник");
                        for (int i = 0; i < products.Length; i++)
                        {
                            file.WriteLine(products[i].Name + "\t" + products[i].Type + "\t" +
                                products[i].Price.ToString("0.00") + "\t" + products[i].Weight +
                                "\t" + products[i].Manufacturer);
                        }
                    }
                    MessageBox.Show("Усі записи збережено у файл.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вдалося зберегти файл: " + ex.Message);
                }
            }
        }
    }
}
