using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSample2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<StudentInfo> studentList = new List<StudentInfo>(); 
        private void showButton_Click(object sender, EventArgs e)
        {
            StudentInfo obj = new StudentInfo();
            obj.reg = regTextBox.Text;
            obj.fName = firstNameTextBox.Text;
            obj.lName = lastNameTextBox.Text;
            regTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;

            studentList.Add(obj);
            string msg = obj.getFullName() + " and your registration number is " + obj.reg;
            MessageBox.Show(msg);

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string msg = "";
            foreach (StudentInfo a in studentList)
            {
                msg += a.getFullName() + " Reg. " + a.reg + "\n";
            }
            MessageBox.Show(msg);
        }
    }
}
