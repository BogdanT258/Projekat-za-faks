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
    public partial class Employee : Form
    {
        private string _employeeKind;
        
        public string EmployeeKind
        {
            get { return _employeeKind; }
            set
            {
                _employeeKind = value;
            }
        }
        public Employee()
        {
            InitializeComponent();
            experience.Controls.RemoveAt(0);                        
        }
        public void SetText()
        {
            if (_employeeKind == "fullTime")
            {
                EmployeeHelp h1 = new EmployeeHelp();
                question1.Text = h1.Question1();
                question2.Text = h1.Question2();
                question3.Text = h1.Question3();
            }
            if (_employeeKind == "partTime")
            {               
                question1.Text = EmployeeHelp.Nested.Question1();
                question2.Text = EmployeeHelp.Nested.Question2();
                question3.Text = EmployeeHelp.Nested.Question3();
            }
        }
        private void Employee_Load(object sender, EventArgs e)
        {   
            
        }       
        private void Question1_Click(object sender, EventArgs e)
        {             
        }

        private void SubmitEmployee_Click(object sender, EventArgs e)
        {
            if (_employeeKind == "fullTime")
            {
                if (experience.Value <= 1 || relocateno.Checked)
                {
                    MessageBox.Show("As you can imagine, we received a large number of " +
                        " applications. I am sorry to inform you that you have not been selected " +
                        " for an interview for this position.");
                }
                else
                    MessageBox.Show("Your application has been sent to our HR team, you will soon" +
                        " be informed about date and time of your interview. Thank you for" +
                        " applying!");
            }
            else
                if (_employeeKind == "partTime")
                {
                if (experience.Value < 20 || relocateyes.Checked)
                {
                    MessageBox.Show("As you can imagine, we received a large number of " +
                        " applications. I am sorry to inform you that you have not been selected " +
                        " for an interview for this position.");
                }
                else
                    MessageBox.Show("Your application has been sent to our HR team, you will soon" +
                        " be informed about date and time of your interview. Thank you for" +
                        " applying!");
            }
        }
    }
    public class EmployeeHelp : Iquestion
    {        
        public string Question1()
        {            
            string a ="How many years of experience do you have?";
            return a;
        }
        public string Question2()
        {
            string a = "Why should we hire you?";
            return a;
        }
        public string Question3()
        {
            string a = "Are you willing to relocate?";
            return a;
        }
        public class Nested
        {
            public static string Question1()
            {
                string a = "How many hours can you work in a week?";
                return a;
            }
            public static string Question2()
            {
                string a = "What are your salary expectations?";
                return a;
            }
            public static string Question3()
            {
                string a = "Have you ever had difficulty working with a manager?";
                return a;
            }
        }
    }
    interface Iquestion
    {
        string Question1();
        string Question2();
        string Question3();
    }
}
