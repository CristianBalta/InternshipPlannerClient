namespace InternshipPlannerClient
{
    partial class UpdateForm
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
            this.userUpdateButton = new System.Windows.Forms.Button();
            this.userEmailTextBox = new System.Windows.Forms.TextBox();
            this.userTelephoneTextBox = new System.Windows.Forms.TextBox();
            this.userCityTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userUpdateButton);
            this.groupBox1.Controls.Add(this.userEmailTextBox);
            this.groupBox1.Controls.Add(this.userTelephoneTextBox);
            this.groupBox1.Controls.Add(this.userCityTextBox);
            this.groupBox1.Controls.Add(this.userNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 278);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User details:";
            // 
            // userUpdateButton
            // 
            this.userUpdateButton.Location = new System.Drawing.Point(479, 155);
            this.userUpdateButton.Name = "userUpdateButton";
            this.userUpdateButton.Size = new System.Drawing.Size(117, 89);
            this.userUpdateButton.TabIndex = 22;
            this.userUpdateButton.Text = "Update";
            this.userUpdateButton.UseVisualStyleBackColor = true;
            this.userUpdateButton.Click += new System.EventHandler(this.userUpdateButton_Click);
            // 
            // userEmailTextBox
            // 
            this.userEmailTextBox.Location = new System.Drawing.Point(150, 168);
            this.userEmailTextBox.Name = "userEmailTextBox";
            this.userEmailTextBox.Size = new System.Drawing.Size(265, 29);
            this.userEmailTextBox.TabIndex = 20;
            // 
            // userTelephoneTextBox
            // 
            this.userTelephoneTextBox.Location = new System.Drawing.Point(150, 123);
            this.userTelephoneTextBox.Name = "userTelephoneTextBox";
            this.userTelephoneTextBox.Size = new System.Drawing.Size(265, 29);
            this.userTelephoneTextBox.TabIndex = 19;
            // 
            // userCityTextBox
            // 
            this.userCityTextBox.Location = new System.Drawing.Point(150, 76);
            this.userCityTextBox.Name = "userCityTextBox";
            this.userCityTextBox.Size = new System.Drawing.Size(265, 29);
            this.userCityTextBox.TabIndex = 18;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(150, 28);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(265, 29);
            this.userNameTextBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Telephone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "City:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 311);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateForm";
            this.Text = "InternshipPlanner";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button userUpdateButton;
        private System.Windows.Forms.TextBox userEmailTextBox;
        private System.Windows.Forms.TextBox userTelephoneTextBox;
        private System.Windows.Forms.TextBox userCityTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}