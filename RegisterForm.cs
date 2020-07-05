using InternshipPlannerClient.ServiceReference1;
using System;
using System.Windows.Forms;

namespace InternshipPlannerClient
{
    public partial class RegisterForm : Form
    {
        InternshipPlannerClient.ServiceReference1.WebService1SoapClient service = new InternshipPlannerClient.ServiceReference1.WebService1SoapClient();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void userRegisterButton_Click(object sender, EventArgs e)
        {

            User user = service.Register(userNameTextBox.Text, userCityTextBox.Text, userTelephoneTextBox.Text, userEmailTextBox.Text, userPasswordTextBox.Text);

            InternshipViewForm internshipViewForm = new InternshipViewForm(user);
            internshipViewForm.Show();
            this.Close();
            MessageBox.Show("Registered!");



        }
    }
}
