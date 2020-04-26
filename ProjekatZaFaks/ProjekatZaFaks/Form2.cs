using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatZaFaks
{
    public partial class Form2 : Form
    {
        public Form2(string fname,string lname,string age,string gender1)
        {
            InitializeComponent();
            name.Text = fname;
            surname.Text = lname;
            age1.Text = age;
            gender.Text = gender1;
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {            
        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void BecomeEmployee_Click(object sender, EventArgs e)
        {                       
            int a = Convert.ToInt32(age1.Text);
            if (a > 18)
            {                
                Employee e2 = new Employee();
                e2.EmployeeKind = "fullTime";
                e2.SetText();
                e2.ShowDialog();
            }
            else
                MessageBox.Show("You do not meet requirements for this position.");
        }

        private void BecomePartTimer_Click(object sender, EventArgs e)
        {            
            int a = Convert.ToInt32(age1.Text);
            if (a > 18)
            {
                Employee e2 = new Employee();
                e2.EmployeeKind = "partTime";
                e2.SetText();
                e2.ShowDialog();
            }
            else
                MessageBox.Show("You do not meet requirements for this position.");
        }
    }
}
