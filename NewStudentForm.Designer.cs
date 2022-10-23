
namespace Report_card
{
    partial class NewStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewStudentForm));
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.Label();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.YearOfStudytxtBox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(28, 120);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(63, 13);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name :";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(28, 146);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(64, 13);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last Name :";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(92, 117);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(183, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(92, 143);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(183, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.header.Image = global::Report_card.Properties.Resources.WIP_7th_anniversary_wallpaper_dark;
            this.header.Location = new System.Drawing.Point(92, 46);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(125, 15);
            this.header.TabIndex = 0;
            this.header.Text = "Student Data Entry Form";
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Location = new System.Drawing.Point(28, 176);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(62, 13);
            this.studentIdLabel.TabIndex = 7;
            this.studentIdLabel.Text = "Student Id :";
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.Location = new System.Drawing.Point(92, 173);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(183, 20);
            this.studentIdTextBox.TabIndex = 8;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(28, 204);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(62, 13);
            this.classLabel.TabIndex = 9;
            this.classLabel.Text = "Class         :";
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Items.AddRange(new object[] {
            "JFT-2018",
            "JFT-2019",
            "JFT-2020",
            "JFT-2021",
            "JFT-2022",
            "JFT-2023"});
            this.ClassComboBox.Location = new System.Drawing.Point(92, 201);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(183, 21);
            this.ClassComboBox.TabIndex = 10;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(13, 237);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(77, 13);
            this.yearLabel.TabIndex = 11;
            this.yearLabel.Text = "Year of Study :";
            // 
            // YearOfStudytxtBox
            // 
            this.YearOfStudytxtBox.Location = new System.Drawing.Point(92, 234);
            this.YearOfStudytxtBox.Name = "YearOfStudytxtBox";
            this.YearOfStudytxtBox.Size = new System.Drawing.Size(64, 20);
            this.YearOfStudytxtBox.TabIndex = 12;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(200, 322);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 13;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(31, 322);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 14;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // NewStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 375);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.YearOfStudytxtBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.ClassComboBox);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.studentIdTextBox);
            this.Controls.Add(this.studentIdLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Student Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox YearOfStudytxtBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button BackBtn;
    }
}