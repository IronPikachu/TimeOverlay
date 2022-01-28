using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Overlay
{
    public partial class Form2 : Form
    {
        private Form1 form1 = null;
        public Form2()
        {
            form1 = new Form1();
            InitializeComponent();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //Up
        private void button4_Click(object sender, EventArgs e)
        {
            form1.moveLocation(0, -5);
        }

        //Left
        private void button2_Click(object sender, EventArgs e)
        {
            form1.moveLocation(-5, 0);
        }

        //Right
        private void button3_Click(object sender, EventArgs e)
        {
            form1.moveLocation(5, 0);
        }

        //Down
        private void button1_Click(object sender, EventArgs e)
        {
            form1.moveLocation(0, 5);
        }

        //Change Screen
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = numericUpDown1.Value % Screen.AllScreens.Length;
            form1.moveScreen((int)numericUpDown1.Value);
        }

        //Toggle Hour
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            form1.setHour(checkBox1.Checked);
        }

        //Toggle Minute
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            form1.setMinute(checkBox2.Checked);
        }

        //Toggle Second
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            form1.setSecond(checkBox3.Checked);
        }

        //Set font size
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int f))
            {
                form1.setLabelFontSize(f);
            }
            else
            {
                textBox1.Text = "";
            }
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            form1.toggleVisibility(checkBox4.Checked);
        }

        //Red
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            form1.labelColor(Color.Red);
        }

        //Green
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            form1.labelColor(Color.Green);
        }

        //Blue
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            form1.labelColor(Color.Blue);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
