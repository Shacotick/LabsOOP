using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace lab13
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
            textBox1.Text = Main.path;
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
            Main.path = textBox1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(File.Exists(Main.path))
                File.Delete(Main.path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(Main.path))
                Process.Start(Main.path);
        }
    }
}
