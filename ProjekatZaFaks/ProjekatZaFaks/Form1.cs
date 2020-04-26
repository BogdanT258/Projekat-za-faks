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
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void SubmitInput_Click(object sender, EventArgs e)
        {            
            string gender = "";
            int age = Convert.ToInt32(ageInput.Value);
            if (male.Checked)
            {
                gender = "Male";
            }else 
            if (female.Checked)
            { gender = "Female"; }            
            HelpClass h1 = new HelpClass(nameInput.Text, surnameInput.Text, age,gender);            
            h1.Assign();            
        }        
        private void InputForm_Load(object sender, EventArgs e)
        {

        }
    }
}
