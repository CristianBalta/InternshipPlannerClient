namespace InternshipPlannerClient
{
    partial class EmailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userEmailPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userEmailLabel = new System.Windows.Forms.Label();
            this.emailBody = new System.Windows.Forms.RichTextBox();
            this.attachmentTextBox = new System.Windows.Forms.TextBox();
            this.emailSubjectTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addFiles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sendEmail = new System.Windows.Forms.Button();
            this.emailDestinationTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.emailDestinationTextBox);
            this.groupBox1.Controls.Add(this.userEmailPassword);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.userEmailLabel);
            this.groupBox1.Controls.Add(this.emailBody);
            this.groupBox1.Controls.Add(this.attachmentTextBox);
            this.groupBox1.Controls.Add(this.emailSubjectTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addFiles);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sendEmail);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 788);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email Composer";
            // 
            // userEmailPassword
            // 
            this.userEmailPassword.Location = new System.Drawing.Point(565, 95);
            this.userEmailPassword.Name = "userEmailPassword";
            this.userEmailPassword.PasswordChar = '*';
            this.userEmailPassword.Size = new System.Drawing.Size(306, 29);
            this.userEmailPassword.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "User Email Password:";
            // 
            // userEmailLabel
            // 
            this.userEmailLabel.AutoSize = true;
            this.userEmailLabel.Location = new System.Drawing.Point(6, 59);
            this.userEmailLabel.Name = "userEmailLabel";
            this.userEmailLabel.Size = new System.Drawing.Size(151, 25);
            this.userEmailLabel.TabIndex = 18;
            this.userEmailLabel.Text = "From user email";
            // 
            // emailBody
            // 
            this.emailBody.Location = new System.Drawing.Point(184, 358);
            this.emailBody.Name = "emailBody";
            this.emailBody.Size = new System.Drawing.Size(837, 323);
            this.emailBody.TabIndex = 17;
            this.emailBody.Text = "";
            // 
            // attachmentTextBox
            // 
            this.attachmentTextBox.Location = new System.Drawing.Point(184, 299);
            this.attachmentTextBox.Name = "attachmentTextBox";
            this.attachmentTextBox.Size = new System.Drawing.Size(378, 29);
            this.attachmentTextBox.TabIndex = 16;
            // 
            // emailSubjectTextBox
            // 
            this.emailSubjectTextBox.Location = new System.Drawing.Point(184, 229);
            this.emailSubjectTextBox.Name = "emailSubjectTextBox";
            this.emailSubjectTextBox.Size = new System.Drawing.Size(378, 29);
            this.emailSubjectTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Attachment:";
            // 
            // addFiles
            // 
            this.addFiles.Location = new System.Drawing.Point(902, 277);
            this.addFiles.Name = "addFiles";
            this.addFiles.Size = new System.Drawing.Size(119, 68);
            this.addFiles.TabIndex = 12;
            this.addFiles.Text = "Add Files";
            this.addFiles.UseVisualStyleBackColor = true;
            this.addFiles.Click += new System.EventHandler(this.addFiles_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Body:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Subject:";
            // 
            // sendEmail
            // 
            this.sendEmail.Location = new System.Drawing.Point(863, 696);
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(158, 83);
            this.sendEmail.TabIndex = 9;
            this.sendEmail.Text = "Send Email";
            this.sendEmail.UseVisualStyleBackColor = true;
            this.sendEmail.Click += new System.EventHandler(this.sendEmail_Click_1);
            // 
            // emailDestinationTextBox
            // 
            this.emailDestinationTextBox.Location = new System.Drawing.Point(14, 140);
            this.emailDestinationTextBox.Name = "emailDestinationTextBox";
            this.emailDestinationTextBox.Size = new System.Drawing.Size(297, 29);
            this.emailDestinationTextBox.TabIndex = 22;
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 812);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmailForm";
            this.Text = "EmailForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox emailBody;
        private System.Windows.Forms.TextBox attachmentTextBox;
        private System.Windows.Forms.TextBox emailSubjectTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label userEmailLabel;
        private System.Windows.Forms.TextBox userEmailPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailDestinationTextBox;
    }
}