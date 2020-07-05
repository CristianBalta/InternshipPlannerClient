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
    public partial class UpdateForm : Form
    {
        InternshipPlannerClient.ServiceReference1.WebService1SoapClient service = new InternshipPlannerClient.ServiceReference1.WebService1SoapClient();
        User user;

        public UpdateForm(User user)
        {
            this.user = user;
            InitializeComponent();

            userNameTextBox.Text = user.Name;
            userCityTextBox.Text = user.City;
            userTelephoneTextBox.Text = user.Telephone;
            userEmailTextBox.Text = user.Email;

        }

        private void userUpdateButton_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser = user;

            newUser.Email = userEmailTextBox.Text;
            newUser.City = userCityTextBox.Text;
            newUser.Name = userNameTextBox.Text;
            newUser.Telephone = userTelephoneTextBox.Text;



            InternshipViewForm internshipViewForm = new InternshipViewForm(service.UpdateCurrentUser(user.Id, newUser));
            internshipViewForm.Show();
            this.Close();
            MessageBox.Show("User updated!");

        }
    }
}
