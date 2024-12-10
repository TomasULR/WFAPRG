using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            StringBuilder sb = new StringBuilder();

            List<string> list = new List<string>();
            string filePath = "C:\\Users\\tomas.ulrych\\Source\\Repos\\TomasULR\\WFAPRG\\WFAPRG\\text.txt";

            if (!File.Exists(filePath))
            {
                sb.AppendLine("Soubor neexistuje");
            }
            else
            {
                list = File.ReadAllLines(filePath)
                    .Select(x => x.Trim())
                    .Where(x => !string.IsNullOrEmpty(x))
                    .ToList();

                if (list.Count == 0)
                {

                }

            }
                
            string jmeno = textBox1.Text;
            string heslo = textBox2.Text;
            int pocet = (int)numericUpDown1.Value;
            DateTime date = dateTimePicker1.Value.ToUniversalTime();
            bool autogramOdRonyho = checkBox1.Checked;
            string combobox = comboBox1.Text;
            bool matejWebber = checkBox2.Checked;

            foreach (var line in list)
            {
                sb.AppendLine(line);
            }
            sb.AppendLine(radioButton1.Text);
            sb.AppendLine(radioButton2.Text);
            sb.AppendLine(heslo + "\n" + pocet.ToString());

            MessageBox.Show(jmeno + '\n' + heslo + '\n' + pocet.ToString() + '\n' + date.ToString() + '\n' + combobox + '\n' + sb.ToString());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
