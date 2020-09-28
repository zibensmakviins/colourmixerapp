using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colourmixerapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SetColorsButton_Click(object sender, EventArgs e)
        {
            int redValue = Int32.Parse(RedValue.Text);
            int greenValue = Int32.Parse(GreenValue.Text);
            int blueValue = Int32.Parse(BlueValue.Text);


            Redbulb.BackColor = Color.FromArgb(redValue, 0, 0);
            Greenbulb.BackColor = Color.FromArgb(0,greenValue, 0);
            Bluebulb.BackColor = Color.FromArgb(0, 0, blueValue);
            this.BackColor = Color.FromArgb(redValue, greenValue, blueValue);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Redbulb.BackColor = Color.FromArgb(255, 0, 0);
            Bluebulb.BackColor = Color.FromArgb(0, 255, 0);
            Greenbulb.BackColor = Color.FromArgb(0, 0, 255);
            RedValue.Text = string.Empty;
            GreenValue.Text = string.Empty;
            BlueValue.Text = string.Empty;
            this.BackColor = Color.FromArgb(255, 255, 255);
        }
    }
}
