using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BL;

namespace A_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource =TeacherBL.GetTeacherById(102439105);


        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = TeacherBL.GetTeacherList().ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TeacherBL.Login(textBox1.Text,textBox2.Text);
        }
    }
}
