using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer1
{
    public partial class Form2 : Form
    {
        int seconds = 15;

        public Form2()
        {
            InitializeComponent();
            this.TopMost = true;
            secondDisplay.Text = seconds.ToString();
        }

        private void Form2_Load(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e){}

        private void ShoutDown_Click(object sender, EventArgs e){}

        private void secondDisplay_Click(object sender, EventArgs e){}

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds < 0)
            { System.Diagnostics.Process.Start("Shutdown", "-s -t 1"); }
            secondDisplay.Text = seconds.ToString();
        }

    }
}
