using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Практика3
{
    public partial class Form2 : Form
    {
        // Змінні та малювання відрізками — за другим проєктом методички.
        private Bitmap bmp_for_draw;
        private Point start_point;
        private bool Draw;
        private Pen pen_for_draw = new Pen(Color.Black, 4);

        public Form2()
        {
            InitializeComponent();
            pen_for_draw.StartCap = pen_for_draw.EndCap =
                System.Drawing.Drawing2D.LineCap.Round;
            bmp_for_draw = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp_for_draw;
            using (Graphics GC = Graphics.FromImage(bmp_for_draw))
                GC.Clear(SystemColors.Window);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open_dialog = new OpenFileDialog())
            {
                open_dialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.gif;*.png";
                if (open_dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Копія однакового з полем розміру: координати кисті збігаються з мишею.
                        using (Bitmap image = new Bitmap(open_dialog.FileName))
                        using (Graphics graf = Graphics.FromImage(bmp_for_draw))
                        {
                            graf.Clear(SystemColors.Window);
                            graf.DrawImage(image, 0, 0, bmp_for_draw.Width, bmp_for_draw.Height);
                        }
                        pictureBox1.Invalidate();
                    }
                    catch
                    {
                        MessageBox.Show("Не вдалося відкрити вибраний файл.");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog savedialog = new SaveFileDialog())
            {
                savedialog.Title = "Зберегти рисунок як...";
                savedialog.Filter = "BMP (*.bmp)|*.bmp|JPG (*.jpg)|*.jpg|GIF (*.gif)|*.gif|PNG (*.png)|*.png";
                savedialog.FilterIndex = 4;
                savedialog.DefaultExt = "png";
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ImageFormat format = ImageFormat.Png;
                        if (savedialog.FilterIndex == 1) format = ImageFormat.Bmp;
                        if (savedialog.FilterIndex == 2) format = ImageFormat.Jpeg;
                        if (savedialog.FilterIndex == 3) format = ImageFormat.Gif;
                        bmp_for_draw.Save(savedialog.FileName, format);
                    }
                    catch
                    {
                        MessageBox.Show("Не вдалося зберегти рисунок.");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Graphics GC = Graphics.FromImage(bmp_for_draw))
                GC.Clear(SystemColors.Window);
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Draw == true && e.Button == MouseButtons.Left)
            {
                using (Graphics graf = Graphics.FromImage(pictureBox1.Image))
                {
                    graf.DrawLine(pen_for_draw, start_point, e.Location);
                    start_point = e.Location;
                    pictureBox1.Invalidate();
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Draw = true;
                start_point = e.Location;
                pictureBox1.Capture = true;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Draw = false;
                pictureBox1.Capture = false;
            }
        }

        private void pictureBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (!pictureBox1.Capture) Draw = false;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            pictureBox1.Image = null;
            bmp_for_draw.Dispose();
            pen_for_draw.Dispose();
        }
    }
}
