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
using Model;

namespace Lab1Sem3WF
{
    public partial class OfficeVM : Form
    {
        public Logic logical = new Logic();
        AddSalaryVM addSalaryVM { get; set; }
        AddSalaryVM changeSalaryVM { get; set; }
        public OfficeVM()
        {
            InitializeComponent();
            listBox1.DataSource = logical.NotHired;
            listBox2.DataSource = logical.Emps;
            addSalaryVM = new AddSalaryVM();
            changeSalaryVM = new AddSalaryVM();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            addSalaryVM.Show();
            addSalaryVM.button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            logical.Hire(logical.SelectedButNotHired, Int32.Parse(addSalaryVM.textBox1.Text));
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = logical.NotHired;
            listBox2.DataSource = logical.Emps;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logical.Refuse(logical.SelectedButNotHired);
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = logical.NotHired;
            listBox2.DataSource = logical.Emps;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logical.Fire(logical.SelectedEmployee);
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = logical.NotHired;
            listBox2.DataSource = logical.Emps;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changeSalaryVM.Show();
            changeSalaryVM.button1.Click += Button1_Click_Change;
        }

        private void Button1_Click_Change(object sender, EventArgs e)
        {
            logical.ChangeSalary(logical.SelectedEmployee, Int32.Parse(changeSalaryVM.textBox1.Text));
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = logical.NotHired;
            listBox2.DataSource = logical.Emps;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            logical.SelectedButNotHired = (Employee)listBox1.SelectedItem;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            logical.SelectedEmployee = (Employee)listBox2.SelectedItem;
        }
    }
}
