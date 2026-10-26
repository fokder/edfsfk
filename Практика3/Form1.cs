using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Практика3
{
    public partial class Form1 : Form
    {
        private Bitmap canvas;
        private bool drawing;
        private Point previousPoint;
        private Color brushColor = Color.Black;
        private TextBox[] coordinateBoxes;
        private Label[] coordinateLabels;

        public Form1()
        {
            InitializeComponent();
            coordinateBoxes = new[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6 };
            coordinateLabels = new[] { label1, label2, label3, label4, label5, label6 };
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = canvas;
            ClearCanvas();
            comboBox1_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void ClearCanvas()
        {
            using (Graphics g = Graphics.FromImage(canvas))
                g.Clear(Color.White);
            pictureBox1.Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int shape = comboBox1.SelectedIndex;
            string[] names = { "X1", "Y1", "X2", "Y2", "X3", "Y3" };
            if (shape == 2 || shape == 3)
                names = new[] { "X", "Y", "Ширина", "Висота", "", "" };

            for (int i = 0; i < coordinateBoxes.Length; i++)
            {
                bool visible = shape >= 0 && (i < 4 || shape == 1);
                coordinateBoxes[i].Visible = visible;
                coordinateLabels[i].Visible = visible;
                coordinateLabels[i].Text = names[i];
            }
            checkBox1.Visible = shape == 2 || shape == 3;
            button1.Enabled = shape >= 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int shape = comboBox1.SelectedIndex;
            if (shape < 0) return;
            int count = shape == 1 ? 6 : 4;
            int[] values = new int[count];
            for (int i = 0; i < count; i++)
            {
                if (!int.TryParse(coordinateBoxes[i].Text, out values[i]) ||
                    values[i] < 0 || values[i] > 10000)
                {
                    MessageBox.Show("Координати та розміри мають бути цілими числами від 0 до 10000.");
                    return;
                }
            }
            if ((shape == 2 || shape == 3) && (values[2] == 0 || values[3] == 0))
            {
                MessageBox.Show("Ширина та висота мають бути більшими за нуль.");
                return;
            }

            using (Graphics g = Graphics.FromImage(canvas))
            using (Pen pen = new Pen(brushColor, (float)numericUpDown1.Value))
            using (Brush brush = new SolidBrush(brushColor))
            {
                if (shape == 0)
                    g.DrawLine(pen, values[0], values[1], values[2], values[3]);
                if (shape == 1)
                {
                    Point[] points = {
                        new Point(values[0], values[1]),
                        new Point(values[2], values[3]),
                        new Point(values[4], values[5])
                    };
                    g.DrawPolygon(pen, points);
                }
                if (shape == 2)
                {
                    if (checkBox1.Checked)
                        g.FillEllipse(brush, values[0], values[1], values[2], values[3]);
                    else
                        g.DrawEllipse(pen, values[0], values[1], values[2], values[3]);
                }
                if (shape == 3)
                {
                    if (checkBox1.Checked)
                        g.FillRectangle(brush, values[0], values[1], values[2], values[3]);
                    else
                        g.DrawRectangle(pen, values[0], values[1], values[2], values[3]);
                }
            }
            pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearCanvas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = brushColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                brushColor = colorDialog1.Color;
                button3.BackColor = brushColor;
                button3.ForeColor = brushColor.GetBrightness() < 0.5f ? Color.White : Color.Black;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(canvas))
            using (Brush brush = new SolidBrush(brushColor))
                g.DrawString(textBox7.Text, fontDialog1.Font, brush,
                    (float)textX.Value, (float)textY.Value);
            pictureBox1.Invalidate();
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            drawing = true;
            pictureBox1.Capture = true;
            previousPoint = e.Location;
            // Короткий клік теж залишає слід кисті.
            float size = (float)numericUpDown1.Value;
            using (Graphics g = Graphics.FromImage(canvas))
            using (Brush brush = new SolidBrush(brushColor))
                g.FillEllipse(brush, e.X - size / 2, e.Y - size / 2, size, size);
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!drawing) return;
            using (Graphics g = Graphics.FromImage(canvas))
            using (Pen pen = new Pen(brushColor, (float)numericUpDown1.Value))
            {
                pen.StartCap = pen.EndCap = LineCap.Round;
                g.DrawLine(pen, previousPoint, e.Location);
            }
            previousPoint = e.Location;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            drawing = false;
            pictureBox1.Capture = false;
        }

        private void pictureBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (!pictureBox1.Capture) drawing = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            try
            {
                canvas.Save(saveFileDialog1.FileName, ImageFormat.Png);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося зберегти рисунок: " + ex.Message);
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            try
            {
                // Файл закривається після копіювання зображення на полотно.
                using (Image image = Image.FromFile(openFileDialog1.FileName))
                using (Graphics g = Graphics.FromImage(canvas))
                {
                    g.Clear(Color.White);
                    g.DrawImage(image, new Rectangle(0, 0, canvas.Width, canvas.Height));
                }
                pictureBox1.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося відкрити зображення: " + ex.Message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            pictureBox1.Image = null;
            canvas.Dispose();
        }
    }
}
