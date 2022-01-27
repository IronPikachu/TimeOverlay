using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Time_Overlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = this.BackColor;
            timer1.Enabled = true;
            timer1.Interval = 500;
        }

        private string time = "HH:mm:ss";
        private Color timeColor = Color.Red;

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString(time);
        }

        public void moveScreen(int index)
        {
            this.Location = Screen.AllScreens[index].WorkingArea.Location;
        }

        public void moveLocation(int dX, int dY)
        {
            this.Location = new Point(dX, dY);
        }

        public void setLabelFontSize(int size)
        {

        }

        public void setHour(bool toggle)
        {
            string[] newTime = time.Split(':');
            if (toggle)
            {
                time = ":" + newTime[1] + ":" + newTime[2];
            }
            else
            {
                time = "HH:" + newTime[1] + ":" + newTime[2];
            }
        }

        public void setMinute(bool toggle)
        {
            string[] newTime = time.Split(':');
            if (toggle)
            {
                time = newTime[0] + ":" + ":" + newTime[2];
            }
            else
            {
                time = newTime[0] + ":" + "mm" + ":" + newTime[2];
            }
        }

        public void setSecond(bool toggle)
        {
            string[] newTime = time.Split(':');
            if (toggle)
            {
                time = newTime[0] + ":" + newTime[1] + ":";
            }
            else
            {
                time = newTime[0] + ":" + newTime[1] + ":" + "ss";
            }
        }

        public void toggleVisibility(bool toggle)
        {
            if (toggle)
            {
                label1.ForeColor = this.BackColor;
            }
            else
            {
                label1.ForeColor = timeColor;
            }
        }

        public void labelColor(Color c)
        {
            label1.ForeColor = c;
            timeColor = c;
        }

    }
}
