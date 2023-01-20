using System.IO;
using System.Threading;
namespace lab66
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        int click = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "Stopped!";
            count = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = count.ToString();
            count++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (click == 0) {timer1.Enabled = false; click = 1; label1.Text += " (Paused)"; } else { timer1.Enabled = true; click = 0; label1.Text = (count-1).ToString(); }

        }
    }
}