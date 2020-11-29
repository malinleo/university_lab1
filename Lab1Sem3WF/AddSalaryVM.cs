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

namespace Lab1Sem3WF
{
    public partial class AddSalaryVM : Form
    {
        public AddSalaryVM()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Int32.Parse(textBox1.Text);
                button1.Enabled = true;
                textBox3.Text = null;
                Text = textBox1.Text;
            }
            catch(FormatException)
            {
                textBox3.Text = "Неверный формат, введите цифры";
                button1.Enabled = false;
            }
            catch(OverflowException)
            {
                textBox3.Text = "Слишком большое число";
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
