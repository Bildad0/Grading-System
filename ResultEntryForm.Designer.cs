
namespace Report_card
{
    partial class ResultEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultEntryForm));
            this.searchText = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.Label();
            this.reportDataset = new System.Data.DataSet();
            this.searchBtn = new System.Windows.Forms.Button();
            this.classes = new System.Windows.Forms.Label();
            this.studentId = new System.Windows.Forms.Label();
            this.yearOfStudy = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.classTextbox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.unitsLabel = new System.Windows.Forms.Label();
            this.marksLabel = new System.Windows.Forms.Label();
            this.firstUnitTextBox = new System.Windows.Forms.TextBox();
            this.firstunitInput = new System.Windows.Forms.TextBox();
            this.secondUnitTextBox = new System.Windows.Forms.TextBox();
            this.thirdUnitTextBox = new System.Windows.Forms.TextBox();
            this.fourthUnitTextBox = new System.Windows.Forms.TextBox();
            this.fithunitTextBox = new System.Windows.Forms.TextBox();
            this.sixthunitTextBox = new System.Windows.Forms.TextBox();
            this.seventhUnitTextBox = new System.Windows.Forms.TextBox();
            this.eigthUnitTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.saveGradeBtn = new System.Windows.Forms.Button();
            this.studentImage = new System.Windows.Forms.PictureBox();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.studentIdTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(186, 149);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(194, 20);
            this.searchText.TabIndex = 0;
            // 
            // nameInput
            // 
            this.nameInput.AutoSize = true;
            this.nameInput.Location = new System.Drawing.Point(32, 199);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(81, 13);
            this.nameInput.TabIndex = 1;
            this.nameInput.Text = "Student Name :";
            // 
            // reportDataset
            // 
            this.reportDataset.DataSetName = "reportDataset";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(386, 147);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(56, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // classes
            // 
            this.classes.AutoSize = true;
            this.classes.Location = new System.Drawing.Point(183, 199);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(32, 13);
            this.classes.TabIndex = 3;
            this.classes.Text = "Class";
            // 
            // studentId
            // 
            this.studentId.AutoSize = true;
            this.studentId.Location = new System.Drawing.Point(183, 133);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(61, 13);
            this.studentId.TabIndex = 4;
            this.studentId.Text = "Student ID ";
            // 
            // yearOfStudy
            // 
            this.yearOfStudy.AutoSize = true;
            this.yearOfStudy.Location = new System.Drawing.Point(324, 199);
            this.yearOfStudy.Name = "yearOfStudy";
            this.yearOfStudy.Size = new System.Drawing.Size(71, 13);
            this.yearOfStudy.TabIndex = 5;
            this.yearOfStudy.Text = "Year of Study";
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(35, 215);
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            this.studentName.Size = new System.Drawing.Size(131, 20);
            this.studentName.TabIndex = 6;
            // 
            // classTextbox
            // 
            this.classTextbox.Location = new System.Drawing.Point(186, 215);
            this.classTextbox.Name = "classTextbox";
            this.classTextbox.ReadOnly = true;
            this.classTextbox.Size = new System.Drawing.Size(100, 20);
            this.classTextbox.TabIndex = 7;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(327, 215);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.ReadOnly = true;
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 8;
            // 
            // unitsLabel
            // 
            this.unitsLabel.AutoSize = true;
            this.unitsLabel.Location = new System.Drawing.Point(32, 296);
            this.unitsLabel.Name = "unitsLabel";
            this.unitsLabel.Size = new System.Drawing.Size(26, 13);
            this.unitsLabel.TabIndex = 9;
            this.unitsLabel.Text = "Unit";
            // 
            // marksLabel
            // 
            this.marksLabel.AutoSize = true;
            this.marksLabel.Location = new System.Drawing.Point(306, 296);
            this.marksLabel.Name = "marksLabel";
            this.marksLabel.Size = new System.Drawing.Size(36, 13);
            this.marksLabel.TabIndex = 10;
            this.marksLabel.Text = "Marks";
            // 
            // firstUnitTextBox
            // 
            this.firstUnitTextBox.Location = new System.Drawing.Point(35, 332);
            this.firstUnitTextBox.Name = "firstUnitTextBox";
            this.firstUnitTextBox.ReadOnly = true;
            this.firstUnitTextBox.Size = new System.Drawing.Size(233, 20);
            this.firstUnitTextBox.TabIndex = 11;
            // 
            // firstunitInput
            // 
            this.firstunitInput.Location = new System.Drawing.Point(309, 331);
            this.firstunitInput.Name = "firstunitInput";
            this.firstunitInput.Size = new System.Drawing.Size(54, 20);
            this.firstunitInput.TabIndex = 12;
            // 
            // secondUnitTextBox
            // 
            this.secondUnitTextBox.Location = new System.Drawing.Point(35, 358);
            this.secondUnitTextBox.Name = "secondUnitTextBox";
            this.secondUnitTextBox.ReadOnly = true;
            this.secondUnitTextBox.Size = new System.Drawing.Size(233, 20);
            this.secondUnitTextBox.TabIndex = 13;
            // 
            // thirdUnitTextBox
            // 
            this.thirdUnitTextBox.Location = new System.Drawing.Point(35, 384);
            this.thirdUnitTextBox.Name = "thirdUnitTextBox";
            this.thirdUnitTextBox.ReadOnly = true;
            this.thirdUnitTextBox.Size = new System.Drawing.Size(233, 20);
            this.thirdUnitTextBox.TabIndex = 14;
            // 
            // fourthUnitTextBox
            // 
            this.fourthUnitTextBox.Location = new System.Drawing.Point(35, 410);
            this.fourthUnitTextBox.Name = "fourthUnitTextBox";
            this.fourthUnitTextBox.ReadOnly = true;
            this.fourthUnitTextBox.Size = new System.Drawing.Size(233, 20);
            this.fourthUnitTextBox.TabIndex = 15;
            // 
            // fithunitTextBox
            // 
            this.fithunitTextBox.Location = new System.Drawing.Point(35, 436);
            this.fithunitTextBox.Name = "fithunitTextBox";
            this.fithunitTextBox.ReadOnly = true;
            this.fithunitTextBox.Size = new System.Drawing.Size(233, 20);
            this.fithunitTextBox.TabIndex = 16;
            // 
            // sixthunitTextBox
            // 
            this.sixthunitTextBox.Location = new System.Drawing.Point(35, 462);
            this.sixthunitTextBox.Name = "sixthunitTextBox";
            this.sixthunitTextBox.ReadOnly = true;
            this.sixthunitTextBox.Size = new System.Drawing.Size(233, 20);
            this.sixthunitTextBox.TabIndex = 17;
            // 
            // seventhUnitTextBox
            // 
            this.seventhUnitTextBox.Location = new System.Drawing.Point(35, 488);
            this.seventhUnitTextBox.Name = "seventhUnitTextBox";
            this.seventhUnitTextBox.ReadOnly = true;
            this.seventhUnitTextBox.Size = new System.Drawing.Size(233, 20);
            this.seventhUnitTextBox.TabIndex = 18;
            // 
            // eigthUnitTextBox
            // 
            this.eigthUnitTextBox.Location = new System.Drawing.Point(35, 514);
            this.eigthUnitTextBox.Name = "eigthUnitTextBox";
            this.eigthUnitTextBox.ReadOnly = true;
            this.eigthUnitTextBox.Size = new System.Drawing.Size(233, 20);
            this.eigthUnitTextBox.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(309, 357);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(309, 384);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 20);
            this.textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(309, 410);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 20);
            this.textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(309, 436);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(54, 20);
            this.textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(309, 462);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(54, 20);
            this.textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(309, 488);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(54, 20);
            this.textBox6.TabIndex = 25;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(309, 514);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(54, 20);
            this.textBox7.TabIndex = 26;
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(327, 250);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(100, 23);
            this.addStudentBtn.TabIndex = 27;
            this.addStudentBtn.Text = "Add New Student";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // saveGradeBtn
            // 
            this.saveGradeBtn.Location = new System.Drawing.Point(309, 555);
            this.saveGradeBtn.Name = "saveGradeBtn";
            this.saveGradeBtn.Size = new System.Drawing.Size(86, 23);
            this.saveGradeBtn.TabIndex = 28;
            this.saveGradeBtn.Text = "Save Grade";
            this.saveGradeBtn.UseVisualStyleBackColor = true;
            // 
            // studentImage
            // 
            this.studentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.studentImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentImage.Image = global::Report_card.Properties.Resources.userimage;
            this.studentImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("studentImage.InitialImage")));
            this.studentImage.Location = new System.Drawing.Point(45, 60);
            this.studentImage.MaximumSize = new System.Drawing.Size(132, 109);
            this.studentImage.Name = "studentImage";
            this.studentImage.Size = new System.Drawing.Size(132, 109);
            this.studentImage.TabIndex = 29;
            this.studentImage.TabStop = false;
            this.studentImage.UseWaitCursor = true;
            this.studentImage.WaitOnLoad = true;
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Location = new System.Drawing.Point(42, 44);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(36, 13);
            this.ImageLabel.TabIndex = 30;
            this.ImageLabel.Text = "Image";
            // 
            // studentIdTxtBox
            // 
            this.studentIdTxtBox.Location = new System.Drawing.Point(105, 252);
            this.studentIdTxtBox.Name = "studentIdTxtBox";
            this.studentIdTxtBox.ReadOnly = true;
            this.studentIdTxtBox.Size = new System.Drawing.Size(202, 20);
            this.studentIdTxtBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Student ID :";
            // 
            // ResultEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentIdTxtBox);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.studentImage);
            this.Controls.Add(this.saveGradeBtn);
            this.Controls.Add(this.addStudentBtn);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.eigthUnitTextBox);
            this.Controls.Add(this.seventhUnitTextBox);
            this.Controls.Add(this.sixthunitTextBox);
            this.Controls.Add(this.fithunitTextBox);
            this.Controls.Add(this.fourthUnitTextBox);
            this.Controls.Add(this.thirdUnitTextBox);
            this.Controls.Add(this.secondUnitTextBox);
            this.Controls.Add(this.firstunitInput);
            this.Controls.Add(this.firstUnitTextBox);
            this.Controls.Add(this.marksLabel);
            this.Controls.Add(this.unitsLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.classTextbox);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.yearOfStudy);
            this.Controls.Add(this.studentId);
            this.Controls.Add(this.classes);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.searchText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultEntryForm";
            this.Text = "Student Result Entry Form";
            ((System.ComponentModel.ISupportInitialize)(this.reportDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label nameInput;
        private System.Data.DataSet reportDataset;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label classes;
        private System.Windows.Forms.Label studentId;
        private System.Windows.Forms.Label yearOfStudy;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.TextBox classTextbox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label unitsLabel;
        private System.Windows.Forms.Label marksLabel;
        private System.Windows.Forms.TextBox firstUnitTextBox;
        private System.Windows.Forms.TextBox firstunitInput;
        private System.Windows.Forms.TextBox secondUnitTextBox;
        private System.Windows.Forms.TextBox thirdUnitTextBox;
        private System.Windows.Forms.TextBox fourthUnitTextBox;
        private System.Windows.Forms.TextBox fithunitTextBox;
        private System.Windows.Forms.TextBox sixthunitTextBox;
        private System.Windows.Forms.TextBox seventhUnitTextBox;
        private System.Windows.Forms.TextBox eigthUnitTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button saveGradeBtn;
        private System.Windows.Forms.PictureBox studentImage;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.TextBox studentIdTxtBox;
        private System.Windows.Forms.Label label1;
    }
}

