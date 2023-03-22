using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = " ";

            if (checkBox1.Checked == true)
            {

                str = str + checkBox1.Text;
                str += " ";
            }


            if (checkBox2.Checked == true)
            {

                str = str + checkBox2.Text;
                str += " ";
            }


            if (checkBox3.Checked == true)
            {

                str = str + checkBox3.Text;
                str += " ";

            }



            if (checkBox4.Checked == true)
            {

                str = str + checkBox4.Text;
                str += " ";
            }


            if (str != null)
            {
                MessageBox.Show("You selected: \n" + str + "\nThank You!", "survey", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox5.Checked == true)
            {
                label2.Visible = true;
                textBox1.Visible = true;
            }
            else
            {
                label2.Visible = false;
                textBox1.Visible = false;
            }


        }
    }
}