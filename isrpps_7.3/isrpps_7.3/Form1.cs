using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.timer1.Interval = 1;
            this.timer1.Enabled = true;
        }

        float angle = 0;

        

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(this.pictureBox1.Width / 2, this.pictureBox1.Height / 2);
            e.Graphics.RotateTransform(angle);

            e.Graphics.DrawRectangle(new Pen(Color.Red, 50), 24, 24, 50, 50);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            angle += 0.5f;
            this.pictureBox1.Invalidate();
        }
    }
}
