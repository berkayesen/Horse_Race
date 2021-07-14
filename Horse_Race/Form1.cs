using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklik, ikinciatsolauzaklik, ucuncuatsolauzaklik;
        Random rastgele = new Random();
        Random rastgele2 = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciatgenisligi = pictureBox1.Width;
            int ikinciatgenisligi = pictureBox2.Width;
            int ucuncuatgenisligi = pictureBox3.Width;
            int dorduncuatgenisligi = pictureBox4.Width;

            int bitisuzakligi = label2.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 50);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 50);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 50);
            pictureBox4.Left = pictureBox4.Left + rastgele.Next(5, 50);



            if (birinciatgenisligi + pictureBox1.Left >= bitisuzakligi && ahmetbahis.Value == 1)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 Numaralı At Yarışı Kazandı!");
                ahmetkazanc.Text = "5";

            }
            else if (birinciatgenisligi + pictureBox1.Left >= bitisuzakligi && mehmetbahis.Value == 1)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 Numaralı At Yarışı Kazandı!");
                mehmetkazanc.Text = "9";
            }
            else if (birinciatgenisligi + pictureBox1.Left >= bitisuzakligi && cengizbahis.Value == 1)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 Numaralı At Yarışı Kazandı!");
                cengizkazanc.Text = "3";
            }
            else if (birinciatgenisligi + pictureBox1.Left >= bitisuzakligi && metebahis.Value == 1)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 Numaralı At Yarışı Kazandı!");
                metekazanc.Text = "7";
            }
            else if (ikinciatgenisligi + pictureBox2.Left >= bitisuzakligi && ahmetbahis.Value == 2)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 Numaralı At Yarışı Kazandı!");
                ahmetkazanc.Text = "5";
            }
            else if (ikinciatgenisligi + pictureBox2.Left >= bitisuzakligi && mehmetbahis.Value == 2)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 Numaralı At Yarışı Kazandı!");
                mehmetkazanc.Text = "9";
            }
            else if (ikinciatgenisligi + pictureBox2.Left >= bitisuzakligi && cengizbahis.Value == 2)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 Numaralı At Yarışı Kazandı!");
                cengizkazanc.Text = "3";
            }
            else if (birinciatgenisligi + pictureBox1.Left >= bitisuzakligi && metebahis.Value == 2)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 Numaralı At Yarışı Kazandı!");
                metekazanc.Text = "7";
            }
            else if (ucuncuatgenisligi + pictureBox3.Left >= bitisuzakligi && ahmetbahis.Value == 3)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 Numaralı At Yarışı Kazandı!");
                ahmetkazanc.Text = "5";
            }

            else if (ucuncuatgenisligi + pictureBox3.Left >= bitisuzakligi && mehmetbahis.Value == 3)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 Numaralı At Yarışı Kazandı!");
                mehmetkazanc.Text = "9";
            }

            else if (ucuncuatgenisligi + pictureBox3.Left >= bitisuzakligi && cengizbahis.Value == 3)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 Numaralı At Yarışı Kazandı!");
                cengizkazanc.Text = "3";
            }
            else if (birinciatgenisligi + pictureBox1.Left >= bitisuzakligi && metebahis.Value == 3)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 Numaralı At Yarışı Kazandı!");
                metekazanc.Text = "7";
            }
            else if (dorduncuatgenisligi + pictureBox4.Left >= bitisuzakligi && ahmetbahis.Value == 4)
            {
                timer1.Enabled = false;
                MessageBox.Show("4 Numaralı At Yarışı Kazandı!");
                ahmetkazanc.Text = "5";
            }
            else if (dorduncuatgenisligi + pictureBox4.Left >= bitisuzakligi && mehmetbahis.Value == 4)
            {
                timer1.Enabled = false;
                MessageBox.Show("4 Numaralı At Yarışı Kazandı!");
                mehmetkazanc.Text = "9";
            }
            else if (dorduncuatgenisligi + pictureBox4.Left >= bitisuzakligi && cengizbahis.Value == 4)
            {
                timer1.Enabled = false;
                MessageBox.Show("4 Numaralı At Yarışı Kazandı!");
                cengizkazanc.Text="3";
            }
            else if (birinciatgenisligi + pictureBox1.Left >= bitisuzakligi && metebahis.Value == 4)
            {
                timer1.Enabled = false;
                MessageBox.Show("4 Numaralı At Yarışı Kazandı!");
                metekazanc.Text = "7";
            }

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void mehmetbahis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklik = pictureBox1.Left;
            ikinciatsolauzaklik = pictureBox2.Left;
            ucuncuatsolauzaklik = pictureBox3.Left;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
