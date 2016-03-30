using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formular
{
    public partial class Form1 : Form
    {
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter = 0;

            if (ota1())
            {
                label1.ForeColor = Color.Green;
                counter++;
            }
            else label1.ForeColor = Color.Red;

            if (ota2())
            {
                label2.ForeColor = Color.Green;
                counter++;
            }
            else label2.ForeColor = Color.Red;

            if (ota3())
            {
                label3.ForeColor = Color.Green;
                counter++;
            }
            else label3.ForeColor = Color.Red;

            if (ota4())
            {
                label4.ForeColor = Color.Green;
                counter++;
            }
            else label4.ForeColor = Color.Red;

            if (ota5())
            {
                label5.ForeColor = Color.Green;
                counter++;
            }
            else label5.ForeColor = Color.Red;

            if (ota6())
            {
                label1.ForeColor = Color.Green;
                counter++;
            }
            else label6.ForeColor = Color.Red;

            button1.Enabled = false;
        }

        private bool ota1()
        {
            string s = "arpanet";
            string t = textBox1.Text;
            if (string.Equals(t,s, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }
            return false;

        }

        private bool ota2()
        {
            if (radioButton1.Checked == true) return true;
            return false;
        }

        private bool ota3()
        {
            if ((checkBox1.Checked == false) && (checkBox2.Checked == false) && (checkBox3.Checked == true) && (checkBox4.Checked == true)) return true;
            return false;
        }

        private bool ota4()
        {
            if (radioButton5.Checked == true) return true;
            return false;
            
        }

        private bool ota5()
        {
            if (comboBox1.SelectedIndex == 1) return true;
            return false;
        }

        private bool ota6()
        {
            string s = dateTimePicker1.Value.ToShortDateString();
            if (s == "01.01.1970") return true;
            return false;
        }
    }
}
