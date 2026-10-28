using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Практика4_Проект2
{
    public partial class Form1 : Form
    {
        // Назви та перевірки перемоги — з методички.
        private char WHO = 'O';
        private short movement = 0;
        private Random r = new Random();

        public Form1()
        {
            InitializeComponent();
            новаГраToolStripMenuItem_Click(this, EventArgs.Empty);
        }

        private void новаГраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WHO = 'O';
            movement = 0;
            tableLayoutPanel1.Enabled = true;
            b1_1.Enabled = true; b1_1.Text = ""; b1_1.BackColor = DefaultBackColor;
            b1_2.Enabled = true; b1_2.Text = ""; b1_2.BackColor = DefaultBackColor;
            b1_3.Enabled = true; b1_3.Text = ""; b1_3.BackColor = DefaultBackColor;
            b2_1.Enabled = true; b2_1.Text = ""; b2_1.BackColor = DefaultBackColor;
            b2_2.Enabled = true; b2_2.Text = ""; b2_2.BackColor = DefaultBackColor;
            b2_3.Enabled = true; b2_3.Text = ""; b2_3.BackColor = DefaultBackColor;
            b3_1.Enabled = true; b3_1.Text = ""; b3_1.BackColor = DefaultBackColor;
            b3_2.Enabled = true; b3_2.Text = ""; b3_2.BackColor = DefaultBackColor;
            b3_3.Enabled = true; b3_3.Text = ""; b3_3.BackColor = DefaultBackColor;
        }

        private void кінецьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buuton_click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (!tableLayoutPanel1.Enabled || !bt.Enabled) return;
            bt.Enabled = false;
            if (WHO == 'O')
            {
                bt.BackColor = Color.Yellow;
                bt.Text = "O";
                if (b1_1.Text == b1_2.Text && b1_2.Text == b1_3.Text && b1_3.Text != "" ||
                    b2_1.Text == b2_2.Text && b2_2.Text == b2_3.Text && b2_3.Text != "" ||
                    b3_1.Text == b3_2.Text && b3_2.Text == b3_3.Text && b3_3.Text != "" ||
                    b1_1.Text == b2_2.Text && b2_2.Text == b3_3.Text && b3_3.Text != "" ||
                    b3_1.Text == b2_2.Text && b2_2.Text == b1_3.Text && b3_1.Text != "" ||
                    b1_1.Text == b2_1.Text && b2_1.Text == b3_1.Text && b3_1.Text != "" ||
                    b1_2.Text == b2_2.Text && b2_2.Text == b3_2.Text && b3_2.Text != "" ||
                    b1_3.Text == b2_3.Text && b2_3.Text == b3_3.Text && b3_3.Text != "")
                {
                    tableLayoutPanel1.Enabled = false;
                    MessageBox.Show($"Переможець - {WHO} !");
                }
                else if (movement == 8)
                {
                    tableLayoutPanel1.Enabled = false;
                    MessageBox.Show("Кінець. Нічия!");
                }
                else
                {
                    WHO = 'X';
                    movement++;
                }
            }
            else if (WHO == 'X')
            {
                bt.BackColor = Color.LightGreen;
                bt.Text = "X";
                if (b1_1.Text == b1_2.Text && b1_2.Text == b1_3.Text && b1_3.Text != "" ||
                    b2_1.Text == b2_2.Text && b2_2.Text == b2_3.Text && b2_3.Text != "" ||
                    b3_1.Text == b3_2.Text && b3_2.Text == b3_3.Text && b3_3.Text != "" ||
                    b1_1.Text == b2_2.Text && b2_2.Text == b3_3.Text && b3_3.Text != "" ||
                    b3_1.Text == b2_2.Text && b2_2.Text == b1_3.Text && b3_1.Text != "" ||
                    b1_1.Text == b2_1.Text && b2_1.Text == b3_1.Text && b3_1.Text != "" ||
                    b1_2.Text == b2_2.Text && b2_2.Text == b3_2.Text && b3_2.Text != "" ||
                    b1_3.Text == b2_3.Text && b2_3.Text == b3_3.Text && b3_3.Text != "")
                {
                    tableLayoutPanel1.Enabled = false;
                    MessageBox.Show($"Переможець - {WHO} !");
                }
                else if (movement == 8)
                {
                    tableLayoutPanel1.Enabled = false;
                    MessageBox.Show("Кінець. Нічия!");
                }
                else
                {
                    WHO = 'O';
                    movement++;
                }
            }

            // Завдання: після ходу людини комп’ютер ставить X.
            if (граЗПКToolStripMenuItem.Checked && WHO == 'X' && tableLayoutPanel1.Enabled)
                ComputerMove();
        }

        private void ComputerMove()
        {
            // Простий режим: випадковий вибір вільної клітинки.
            List<Button> freeButtons = new List<Button>();
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Button button = control as Button;
                if (button != null && button.Enabled) freeButtons.Add(button);
            }
            if (freeButtons.Count > 0)
                freeButtons[r.Next(freeButtons.Count)].PerformClick();
        }

        private void граЗПКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            новаГраToolStripMenuItem_Click(sender, e);
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хрестики-нулики. Першими ходять O.\n" +
                "У режимі гри з ПК людина грає O, комп’ютер — X.");
        }
    }
}
