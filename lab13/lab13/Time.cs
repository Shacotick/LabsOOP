using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab13
{
    public partial class Time : Form
    {
        public static double kievT, lvivT, odesaT;
        public Time()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Bottom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point currentCoord;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            currentCoord = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                this.Left += e.X - currentCoord.X;
                this.Top += e.Y - currentCoord.Y;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try{ kievT = double.Parse(textBox1.Text); }
            catch (Exception) { kievT = 0; }

            try { lvivT = double.Parse(textBox2.Text); }
            catch (Exception) { lvivT = 0; }

            try { odesaT = double.Parse(textBox3.Text); }
            catch (Exception) { odesaT = 0; }

            this.Close();
        }

    }
}
