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
    public partial class InternshipViewForm : Form
    {

        InternshipPlannerClient.ServiceReference1.WebService1SoapClient service = new InternshipPlannerClient.ServiceReference1.WebService1SoapClient();
        User user;
        Internship internship;
        Status status;

        List<Internship> internshipList = new List<Internship>();
        List<Status> statusList = new List<Status>();


        public InternshipViewForm(User user)
        {
            this.user = user;
            InitializeComponent();
            groupBox4.Text = "Hello " + user.Name;

            foreach (String internshipId in user.Internships)
            {
                internship = service.GetUserInternships(internshipId);

                this.internshipList.Add(internship);

                internshipListBox.Items.Add(internship.Company);
            }

        }

        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            EmailForm emailForm = new EmailForm(user.Email);
            emailForm.Show();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            service.GetCurrentUser(user.Id);
            UpdateForm updateForm = new UpdateForm(user);
            updateForm.Show();
            this.Close();

        }

        private void internshipEdditModeButton_Click(object sender, EventArgs e)
        {
            addInternshipButton.Visible = true;
            updateCompanyButton.Visible = true;

            companyCityTextBox.ReadOnly = false;
            companyDescriptionTextBox.ReadOnly = false;
            companyEmailTextBox.ReadOnly = false;
            companyIsPaidTextBox.ReadOnly = false;
            companyPositionTextBox.ReadOnly = false;
            companyNameTextBox.ReadOnly = false;

        }

        private void statusEditModeButton_Click(object sender, EventArgs e)
        {
            addStatusButton.Visible = true;
            updateSatusButton.Visible = true;

            statusProgressTextBox.ReadOnly = false;
            statusDescriptionTextBox.ReadOnly = false;
            statusEventTextBox.ReadOnly = false;
        }

        
        private void addInternshipButton_Click(object sender, EventArgs e)
        {
            addInternshipButton.Visible = false;
            updateCompanyButton.Visible = false;

            companyCityTextBox.ReadOnly = true;
            companyDescriptionTextBox.ReadOnly = true;
            companyEmailTextBox.ReadOnly = true;
            companyIsPaidTextBox.ReadOnly = true;
            companyPositionTextBox.ReadOnly = true;
            companyNameTextBox.ReadOnly = true;


            service.CreateAnIntership(companyNameTextBox.Text, companyPositionTextBox.Text, companyIsPaidTextBox.Text, companyCityTextBox.Text, companyEmailTextBox.Text, companyDescriptionTextBox.Text);
            MessageBox.Show("Internship created!");
            
            user = service.Login(user.Email, user.Password);

            this.Close();
            InternshipViewForm internshipViewForm = new InternshipViewForm(user);
            internshipViewForm.Show();
        }
        private void updateCompanyButton_Click(object sender, EventArgs e)
        {
            addInternshipButton.Visible = false;
            updateCompanyButton.Visible = false;

            companyCityTextBox.ReadOnly = true;
            companyDescriptionTextBox.ReadOnly = true;
            companyEmailTextBox.ReadOnly = true;
            companyIsPaidTextBox.ReadOnly = true;
            companyPositionTextBox.ReadOnly = true;
            companyNameTextBox.ReadOnly = true;


            foreach (Internship internshipFromList in internshipList)
            {
                if (internshipListBox.SelectedItem.ToString() == internshipFromList.Company)
                {
                    Internship newInternship = new Internship();
                    newInternship = internshipFromList;

                    newInternship.City = companyCityTextBox.Text;
                    newInternship.Company = companyNameTextBox.Text;
                    newInternship.Position = companyPositionTextBox.Text;
                    newInternship.Paid = companyIsPaidTextBox.Text;
                    newInternship.Email = companyEmailTextBox.Text;
                    newInternship.Description = companyDescriptionTextBox.Text;

                    service.UpdateCurrentInternship(internshipFromList.Id, newInternship);
                    MessageBox.Show("Internship modified!");

                }
            }
            user = service.Login(user.Email, user.Password);

            this.Close();
            InternshipViewForm internshipViewForm = new InternshipViewForm(user);
            internshipViewForm.Show();
        }
        private void addStatusButton_Click(object sender, EventArgs e)
        {
            addStatusButton.Visible = false;
            updateSatusButton.Visible = false;

            statusProgressTextBox.ReadOnly = true;
            statusDescriptionTextBox.ReadOnly = true;
            statusEventTextBox.ReadOnly = true;

            service.CreateAStatus(statusEventTextBox.Text, statusDescriptionTextBox.Text, statusProgressTextBox.Text);
            MessageBox.Show("Status created!");
            user = service.Login(user.Email, user.Password);

            this.Close();
            InternshipViewForm internshipViewForm = new InternshipViewForm(user);
            internshipViewForm.Show();
        }
        private void updateSatusButton_Click(object sender, EventArgs e)
        {
            addStatusButton.Visible = false;
            updateSatusButton.Visible = false;

            statusProgressTextBox.ReadOnly = true;
            statusDescriptionTextBox.ReadOnly = true;
            statusEventTextBox.ReadOnly = true;

            foreach (Status statusFromList in statusList)
            {
                if (statusListBox.SelectedItem.ToString() == statusFromList.Event)
                {
                    Status newStatus = new Status();
                    newStatus = statusFromList;

                    newStatus.Description = statusDescriptionTextBox.Text;
                    newStatus.Event = statusEventTextBox.Text;
                    newStatus.Progress = statusProgressTextBox.Text;

                    service.UpdateCurrentStatus(statusFromList.Id, newStatus);
                    MessageBox.Show("Status updated!");

                }

            }

            user = service.Login(user.Email, user.Password);

            this.Close();
            InternshipViewForm internshipViewForm = new InternshipViewForm(user);
            internshipViewForm.Show();

        }

        private void deleteInternshipButton_Click(object sender, EventArgs e)
        {
            foreach (Internship internshipFromList in internshipList)
            {
                if (internshipListBox.SelectedItem.ToString() == internshipFromList.Company)
                {
                    internshipListBox.Items.Remove(internshipFromList.Company);
                    MessageBox.Show(service.DeleteCurrentInternship(internshipFromList.Id));
                }
            }
            user = service.Login(user.Email, user.Password);

            this.Close();
            InternshipViewForm internshipViewForm = new InternshipViewForm(user);
            internshipViewForm.Show();
        }
        private void deleteStatusButton_Click(object sender, EventArgs e)
        {
            foreach (Status statusFromList in statusList)
            {
                if (statusListBox.SelectedItem.ToString() == statusFromList.Event)
                {
                    statusListBox.Items.Remove(statusFromList.Event);
                    MessageBox.Show(service.DeleteCurrentStatus(statusFromList.Id)
);
                }

            }
            user = service.Login(user.Email, user.Password);

            this.Close();
            InternshipViewForm internshipViewForm = new InternshipViewForm(user);
            internshipViewForm.Show();
        }

        
        private void statusListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Status statusFromList in statusList)
            {
                if (statusListBox.SelectedItem.ToString() == statusFromList.Event)
                {
                    statusDescriptionTextBox.Text = statusFromList.Description;
                    statusEventTextBox.Text = statusFromList.Event;
                    statusProgressTextBox.Text = statusFromList.Progress;
                }

            }

        }

        private void internshipListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusListBox.Items.Clear();
            statusList.Clear();
            finallyTextBox.BackColor = Color.White;

            foreach (Internship internshipFromList in internshipList)
            {
                if (internshipListBox.SelectedItem.ToString() == internshipFromList.Company)
                {
                    companyCityTextBox.Text = internshipFromList.City;
                    companyNameTextBox.Text = internshipFromList.Company;
                    companyIsPaidTextBox.Text = internshipFromList.Paid;
                    companyEmailTextBox.Text = internshipFromList.Email;
                    companyDescriptionTextBox.Text = internshipFromList.Description;
                    companyPositionTextBox.Text = internshipFromList.Position;


                    foreach (string statusId in internshipFromList.Status)
                    {
                        status = service.GetInternshipStatus(statusId);
                        statusList.Add(status);
                        statusListBox.Items.Add(status.Event);

                    }

                    if (statusList.Count > 0)
                    {
                        if (statusList[statusList.Count - 1].Progress == "no")
                            finallyTextBox.BackColor = Color.Red;
                        else finallyTextBox.BackColor = Color.Green;
                    }
                }



            }
        }
    }
}

