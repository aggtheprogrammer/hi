using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enixero2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible= true;
            Random rnd=new Random();
            Random rn2= new Random();
            button2.Location = new Point(rnd.Next()%400,rn2.Next()%200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            label2.Visible = true;
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            label3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            label5.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label4.Visible= true;
            dateTimePicker1.Visible= true;
            label6.Visible= true;
            checkBox1.Visible= true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button3.Visible= true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
