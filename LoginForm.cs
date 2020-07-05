using InternshipPlannerClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternshipPlannerClient
{
    public partial class LoginForm : Form
    {

        InternshipPlannerClient.ServiceReference1.WebService1SoapClient service = new InternshipPlannerClient.ServiceReference1.WebService1SoapClient();

        public LoginForm()
        {
            InitializeComponent();
        }

       

        private void loginButton_Click(object sender, EventArgs e)
        {
            User user = service.Login(emailTextBox.Text, passwordTextBox.Text);

            if ( user != null)
            {
                InternshipViewForm internshipViewForm = new InternshipViewForm(user);
                internshipViewForm.Show();
                this.Visible = false;

            }
            else MessageBox.Show("Wrong credentials!");

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Visible = false;

        }
    }
}
