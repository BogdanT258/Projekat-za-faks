using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatZaFaks
{
    class HelpClass 
    {
        protected string _firstName = "none";
        protected string _lastName = "none";
        protected int _age;
        protected string _gender = "none";
        
        public HelpClass(string name, string lastname, int age,string gender)
        {
            _firstName = name;
            _lastName = lastname;
            _age = age;
            _gender = gender;
        }
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                bool isNumerical = int.TryParse(value, out int a);
                if (isNumerical == true)
                {
                    MessageBox.Show("Your name has numbers! Please enter your name again.");
                }
                else
                {
                    _firstName = value;
                }
            }
        }
        public string LastName
        {
            get { return _lastName; }
        }
        public int Age
        {
            get { return _age; }
        }        
        public void Assign()
        {
            string nage = Convert.ToString(_age);
            Form2 f2 = new Form2(_firstName,_lastName,nage,_gender);           
            f2.ShowDialog();
        }
        
    }
}
