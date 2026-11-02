using System;
using System.IO;
using System.Windows.Forms;

namespace Індивідуальне13
{
    public partial class Form1 : Form
    {
        // Структура автомобіля: сім полів із завдання.
        private struct Car
        {
            public string Brand;
            public string Plate;
            public string Driver;
            public decimal Capacity;
            public bool InTrip;
            public DateTime DepartureDate;
            public int DurationDays;
        }

        // Вантажопідйомність указана в тоннах. Початкові дані навчальні.
        private Car[] cars =
        {
            new Car { Brand = "Ford Transit", Plate = "АА1001КІ", Driver = "Коваль", Capacity = 1.5m, InTrip = false },
            new Car { Brand = "Mercedes Sprinter", Plate = "АА1002КІ", Driver = "Бондар", Capacity = 2m, InTrip = true, DepartureDate = DateTime.Today.AddDays(-1), DurationDays = 4 },
            new Car { Brand = "Iveco Daily", Plate = "АА1003КІ", Driver = "Мельник", Capacity = 3.5m, InTrip = false },
            new Car { Brand = "MAN TGL", Plate = "АА1004КІ", Driver = "Шевченко", Capacity = 5m, InTrip = false },
            new Car { Brand = "DAF LF", Plate = "АА1005КІ", Driver = "Ткаченко", Capacity = 7.5m, InTrip = true, DepartureDate = DateTime.Today, DurationDays = 3 },
            new Car { Brand = "Volvo FL", Plate = "АА1006КІ", Driver = "Кравченко", Capacity = 10m, InTrip = false },
            new Car { Brand = "Renault Master", Plate = "АА1007КІ", Driver = "Олійник", Capacity = 1.5m, InTrip = false },
            new Car { Brand = "Scania P", Plate = "АА1008КІ", Driver = "Савченко", Capacity = 12m, InTrip = true, DepartureDate = DateTime.Today.AddDays(-2), DurationDays = 5 },
            new Car { Brand = "Isuzu NPR", Plate = "АА1009КІ", Driver = "Романенко", Capacity = 4m, InTrip = false },
            new Car { Brand = "Hyundai HD78", Plate = "АА1010КІ", Driver = "Петренко", Capacity = 3.5m, InTrip = false }
        };

        public Form1()
        {
            InitializeComponent();
            ShowCars();
        }

        private void ShowCars()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < cars.Length; i++)
            {
                dataGridView1.Rows.Add(cars[i].Brand, cars[i].Plate, cars[i].Driver,
                    cars[i].Capacity, cars[i].InTrip ? "Так" : "Ні",
                    cars[i].InTrip ? cars[i].DepartureDate.ToString("dd.MM.yyyy") : "—",
                    cars[i].InTrip ? cars[i].DurationDays.ToString() : "—");
            }
            labelCount.Text = "Кількість автомобілів: " + cars.Length;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            decimal cargo = numericCargo.Value;
            for (int i = 0; i < cars.Length; i++)
            {
                // Автомобіль має бути вільним і вміщувати заданий вантаж.
                if (!cars[i].InTrip && cars[i].Capacity >= cargo)
                    listBox1.Items.Add(cars[i].Brand + " | " + cars[i].Plate +
                        " | " + cars[i].Capacity + " т | " + cars[i].Driver);
            }
            if (listBox1.Items.Count == 0)
                listBox1.Items.Add("Вільних автомобілів достатньої місткості немає.");
        }

        private void checkBoxTrip_CheckedChanged(object sender, EventArgs e)
        {
            dateDeparture.Enabled = checkBoxTrip.Checked;
            numericDays.Enabled = checkBoxTrip.Checked;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string brand = textBoxBrand.Text.Trim();
            string plate = textBoxPlate.Text.Trim();
            string driver = textBoxDriver.Text.Trim();
            if (brand == "" || plate == "" || driver == "")
            {
                MessageBox.Show("Заповніть марку, номерний знак і прізвище водія.");
                return;
            }
            if (brand.Contains("\t") || plate.Contains("\t") || driver.Contains("\t"))
            {
                MessageBox.Show("Текстові поля не повинні містити табуляцію.");
                return;
            }
            for (int i = 0; i < cars.Length; i++)
            {
                if (string.Equals(cars[i].Plate, plate, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Автомобіль із таким номером уже є.");
                    return;
                }
            }

            Car car = new Car();
            car.Brand = brand;
            car.Plate = plate;
            car.Driver = driver;
            car.Capacity = numericCapacity.Value;
            car.InTrip = checkBoxTrip.Checked;
            car.DepartureDate = car.InTrip ? dateDeparture.Value.Date : DateTime.MinValue;
            car.DurationDays = car.InTrip ? (int)numericDays.Value : 0;

            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = car;
            ShowCars();
            listBox1.Items.Clear();
            textBoxPlate.Clear();
            textBoxPlate.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Текстовий файл (*.txt)|*.txt";
                dialog.FileName = "Автомобілі.txt";
                if (dialog.ShowDialog() != DialogResult.OK) return;
                try
                {
                    using (StreamWriter file = new StreamWriter(dialog.FileName))
                    {
                        file.WriteLine("Марка\tНомерний знак\tВодій\tВантажопідйомність (т)\tУ рейсі\tДата виїзду\tТривалість (дні)");
                        for (int i = 0; i < cars.Length; i++)
                        {
                            file.WriteLine(cars[i].Brand + "\t" + cars[i].Plate + "\t" +
                                cars[i].Driver + "\t" + cars[i].Capacity + "\t" +
                                (cars[i].InTrip ? "Так" : "Ні") + "\t" +
                                (cars[i].InTrip ? cars[i].DepartureDate.ToString("dd.MM.yyyy") : "—") + "\t" +
                                (cars[i].InTrip ? cars[i].DurationDays.ToString() : "—"));
                        }
                    }
                    MessageBox.Show("Усі автомобілі збережені у файл.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка збереження: " + ex.Message);
                }
            }
        }
    }
}
