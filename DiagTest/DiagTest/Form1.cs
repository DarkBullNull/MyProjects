using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DiagTest
{
    public partial class Form1 : Form
    {
        CommonStruct cs = new CommonStruct();
        private int iterator = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = cs.Random0.Key;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == cs.Random0.Value)
            {
                pictureBox1.Image = cs.Random1.Key;
                iterator++;
            }
            else
            {
                pictureBox1.Image = cs.Random1.Key;
            }
        }
    }
}
