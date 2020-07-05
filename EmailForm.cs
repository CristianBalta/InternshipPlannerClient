using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text;
using InternshipPlannerClient.ServiceReference1;

namespace InternshipPlannerClient
{
    public partial class EmailForm : Form
    {
        string email;
        InternshipPlannerClient.ServiceReference1.WebService1SoapClient service = new InternshipPlannerClient.ServiceReference1.WebService1SoapClient();

        string pathToFile = "";
        string fileName;
        public EmailForm(string email)
        {
            this.email = email;
            InitializeComponent();
            userEmailLabel.Text = "From " + this.email;

        }

        private void addFiles_Click_1(object sender, EventArgs e)
        {
            
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "All files |";
            


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathToFile = openFileDialog.FileName;
                fileName = openFileDialog.SafeFileName;
                attachmentTextBox.Text = fileName;
            }
        }

        private void sendEmail_Click_1(object sender, EventArgs e)
        {

             MessageBox.Show(service.SendEmail(email, userEmailPassword.Text, emailSubjectTextBox.Text, emailBody.Text, pathToFile, emailDestinationTextBox.Text));
            this.Close();
        }

       
    }
}