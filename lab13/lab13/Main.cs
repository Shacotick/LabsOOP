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

        public static string path = "savedData.txt";

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
                double
                kiev_common = Price.kievV * Time.kievT,
                lviv_common = Price.lvivV * Time.lvivT,
                odesa_common = Price.odesaV * Time.odesaT;

                if (Price.kievV < 0 || Time.kievT < 0) this.kievPrice.Text = "Не вірні дані";
                else this.kievPrice.Text = (kiev_common).ToString();

                if (Price.lvivV < 0 || Time.lvivT < 0) this.lvivPrice.Text = "Не вірні дані";
                else this.lvivPrice.Text = (lviv_common).ToString();

                if (Price.odesaV < 0 || Time.odesaT < 0) this.odesaPrice.Text = "Не вірні дані";
                else this.odesaPrice.Text = (odesa_common).ToString();

            try
            {
                this.common.Text = (
                    int.Parse(this.kievPrice.Text) +
                    int.Parse(this.lvivPrice.Text) +
                    int.Parse(this.odesaPrice.Text)
                    ).ToString();
            }
            catch(Exception)
            {
                this.common.Text = "Не вірні дані";
            }
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
            try
            {
                using (StreamWriter stream = new StreamWriter(path, true))
                    stream.WriteLine(this.fio_reverse.Text);
            }
            catch(Exception)
            {
                path = "savedData.txt";
                using (StreamWriter stream = new StreamWriter(path, true))
                    stream.WriteLine(this.fio_reverse.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Setup().ShowDialog();
        }
    }
}
