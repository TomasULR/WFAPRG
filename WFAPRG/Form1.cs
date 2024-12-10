using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAPRG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jmeno = textBox1.Text;
            string heslo = textBox2.Text;
            int pocet = (int)numericUpDown1.Value;
            DateTime date = dateTimePicker1.Value.ToUniversalTime();
            bool autogramOdRonyho = checkBox1.Checked;
            string combobox = comboBox1.Text;
            bool matejWebber = checkBox2.Checked;

            MessageBox.Show(jmeno + '\n' + heslo + '\n' + pocet.ToString() + '\n' + date.ToString() + '\n' + combobox);
            

        }
    }
}
