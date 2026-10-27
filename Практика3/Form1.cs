using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Практика3
{
    public partial class Form1 : Form
    {
        // Змінна Drow та обробники — за першим проєктом методички.
        private bool Drow;
        private Color brushColor = Color.Violet;
        // Bitmap із другого прикладу потрібний для збереження всього рисунка.
        private Bitmap bmp_for_draw;

        public Form1()
        {
            InitializeComponent();
            bmp_for_draw = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp_for_draw;
            using (Graphics GC = Graphics.FromImage(bmp_for_draw))
                GC.Clear(SystemColors.Window);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Painting";
            button1.Text = "Paint";
            button2.Text = "Clear";
            button3.Text = "Color";
            button4.Text = "Text";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = comboBox1.SelectedIndex == 1;
            textBox6.Visible = comboBox1.SelectedIndex == 1;
            checkBox1.Visible = comboBox1.SelectedIndex == 2 || comboBox1.SelectedIndex == 3;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Замість CreateGraphics малюємо на Bitmap, щоб рисунок можна було зберегти.
                using (Graphics Graf = Graphics.FromImage(bmp_for_draw))
                {
                    if (comboBox1.SelectedIndex == 0)
                        Graf.DrawLine(Pens.Black,
                            Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),
                            Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));

                    if (comboBox1.SelectedIndex == 1)
                    {
                        Graf.DrawLine(Pens.Black,
                            Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox4.Text),
                            Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox5.Text));
                        Graf.DrawLine(Pens.Black,
                            Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox5.Text),
                            Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox6.Text));
                        Graf.DrawLine(Pens.Black,
                            Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox6.Text),
                            Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox4.Text));
                    }

                    if (comboBox1.SelectedIndex == 2 || comboBox1.SelectedIndex == 3)
                    {
                        int x = Convert.ToInt32(textBox1.Text);
                        int y = Convert.ToInt32(textBox2.Text);
                        int width = Convert.ToInt32(textBox3.Text);
                        int height = Convert.ToInt32(textBox4.Text);
                        if (width <= 0 || height <= 0)
                        {
                            MessageBox.Show("Ширина та висота мають бути більшими за нуль.");
                            return;
                        }
                        if (checkBox1.Checked)
                        {
                            if (colorDialog1.ShowDialog() == DialogResult.Cancel) return;
                            using (Brush zal = new SolidBrush(colorDialog1.Color))
                            {
                                if (comboBox1.SelectedIndex == 2)
                                    Graf.FillEllipse(zal, x, y, width, height);
                                else
                                    Graf.FillRectangle(zal, x, y, width, height);
                            }
                        }
                        else
                        {
                            if (comboBox1.SelectedIndex == 2)
                                Graf.DrawEllipse(Pens.Black, x, y, width, height);
                            else
                                Graf.DrawRectangle(Pens.Black, x, y, width, height);
                        }
                    }
                }
                pictureBox1.Invalidate();
            }
            catch (FormatException)
            {
                MessageBox.Show("Уведіть цілі числа в поля координат.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Уведене число надто велике.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Graphics GC = Graphics.FromImage(bmp_for_draw))
                GC.Clear(SystemColors.Window);
            pictureBox1.Invalidate();
        }

        // Завдання 1: вибір кольору кисті.
        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = brushColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                brushColor = colorDialog1.Color;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drow == true)
            {
                using (Graphics graf = Graphics.FromImage(bmp_for_draw))
                using (Brush brush = new SolidBrush(brushColor))
                    graf.FillEllipse(brush, e.X, e.Y,
                        Convert.ToInt32(numericUpDown1.Value),
                        Convert.ToInt32(numericUpDown1.Value));
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Drow = true;
                pictureBox1.Capture = true;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Drow = false;
                pictureBox1.Capture = false;
            }
        }

        private void pictureBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (!pictureBox1.Capture) Drow = false;
        }

        // Завдання 3: координати тексту задано в textBox8 і textBox9.
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                String Text = String.Format("{0}", textBox7.Text);
                using (Brush Кисть = new SolidBrush(Color.LimeGreen))
                using (Graphics G = Graphics.FromImage(bmp_for_draw))
                {
                    G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    G.DrawString(Text, fontDialog1.Font, Кисть,
                        Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text));
                }
                pictureBox1.Invalidate();
            }
            catch (FormatException)
            {
                MessageBox.Show("Уведіть цілі числа в координати тексту.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Уведене число надто велике.");
            }
        }

        // Завдання 4: стандартний діалог вибору шрифту.
        private void button5_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        // Завдання 5: збереження рисунка.
        private void button6_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog savedialog = new SaveFileDialog())
            {
                savedialog.Filter = "PNG (*.png)|*.png";
                savedialog.DefaultExt = "png";
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try { bmp_for_draw.Save(savedialog.FileName, ImageFormat.Png); }
                    catch (Exception ex) { MessageBox.Show("Помилка збереження: " + ex.Message); }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (Form2 form = new Form2())
                form.ShowDialog(this);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            pictureBox1.Image = null;
            bmp_for_draw.Dispose();
        }
    }
}
