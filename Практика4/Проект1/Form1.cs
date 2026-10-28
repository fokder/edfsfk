using System;
using System.Drawing;
using System.Windows.Forms;

namespace Практика4_Проект1
{
    public partial class Form1 : Form
    {
        // Основні змінні з методички.
        private bool isDown;
        private int points = 0;
        private double t;
        // Доповнення для випадкових зображень і двох коробок.
        private Random r = new Random();
        private Image[] images;
        private int imageNumber;

        public Form1()
        {
            InitializeComponent();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            images = new Image[] { pictureBox1.Image, (Image)resources.GetObject("dog.Image") };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = 0.0;
        }

        // Випадкова позиція з методички та випадкове зображення із завдання.
        private void NewPicture()
        {
            imageNumber = r.Next(0, images.Length);
            pictureBox1.Image = images[imageNumber];
            pictureBox1.Location = new Point(180 + r.Next(0, 300), 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
            if (pictureBox1.Location.Y > 500)
            {
                points -= 50; // Завдання: віднімання балів за пропуск.
                label1.Text = Convert.ToString(points);
                NewPicture();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            t += 0.001 * timer2.Interval;
            label2.Text = String.Format("{0:F3}", t);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // MouseClick відбувається після MouseUp: падіння має продовжуватися.
            timer1.Enabled = timer2.Enabled && !isDown;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isDown)
                c.Location = this.PointToClient(Control.MousePosition);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || !timer2.Enabled) return;
            isDown = true;
            timer1.Enabled = false;
            pictureBox1.Capture = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || !isDown) return;
            isDown = false;
            pictureBox1.Capture = false;
            timer1.Enabled = timer2.Enabled;

            // Завдання: кота кладемо в першу коробку, собаку — в другу.
            Point center = new Point(pictureBox1.Left + pictureBox1.Width / 2,
                pictureBox1.Top + pictureBox1.Height / 2);
            bool catBox = pictureBox2.Bounds.Contains(center);
            bool dogBox = pictureBox3.Bounds.Contains(center);
            if (catBox || dogBox)
            {
                if ((catBox && imageNumber == 0) || (dogBox && imageNumber == 1))
                    points += 100;
                else
                    points -= 50;
                label1.Text = Convert.ToString(points);
                NewPicture();
            }
        }

        private void pictureBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (!pictureBox1.Capture)
            {
                isDown = false;
                timer1.Enabled = timer2.Enabled;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!pictureBox1.Visible) NewPicture();
            timer1.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox1.Enabled = true;
            timer2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            isDown = false;
            pictureBox1.Capture = false;
            pictureBox1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            isDown = false;
            pictureBox1.Capture = false;
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;
            pictureBox1.Location = new Point(201, 0);
            points = 0;
            t = 0;
            label1.Text = "0";
            label2.Text = "0.000";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Менший Interval означає швидше падіння.
            timer1.Interval = Convert.ToInt32(numericUpDown1.Value);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            pictureBox1.Image = null;
            foreach (Image image in images) image.Dispose();
            pictureBox2.Image.Dispose();
            pictureBox3.Image = null;
            pictureBox2.Image = null;
        }
    }
}
