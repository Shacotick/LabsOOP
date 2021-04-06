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

namespace lab13
{
    public partial class Main : Form
    {
        public static double kievFull = 0;
        public static double lvivFull = 0;
        public static double odesaFull = 0;

        public static string path = @"C:\Users\Vitalii\source\repos\lab13\lab13/savedData.txt";

        public Main()
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
            if(MouseButtons.Left == e.Button)
            {
                this.Left += e.X - currentCoord.X;
                this.Top += e.Y - currentCoord.Y;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Price().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Time().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.kievPrice.Text = (Price.kievV * Time.kievT).ToString();
            this.lvivPrice.Text = (Price.lvivV * Time.lvivT).ToString();
            this.odesaPrice.Text = (Price.odesaV * Time.odesaT).ToString();
            
            this.common.Text = (
                int.Parse(this.kievPrice.Text) + 
                int.Parse(this.lvivPrice.Text) + 
                int.Parse(this.odesaPrice.Text)
                ).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder(this.fioInput.Text);
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                var temp = str[i];
                str[i] = str[j];
                str[j] = temp;
            }
            this.fio_reverse.Text = str.ToString();
            this.quantitySym.Text = $"{str.Length} символів";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (StreamWriter stream = new StreamWriter(path, true))
                stream.WriteLine(this.fio_reverse.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Setup().ShowDialog();
        }
    }
}
