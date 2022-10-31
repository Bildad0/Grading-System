
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
            this.FirstUnitMarks = new System.Windows.Forms.TextBox();
            this.secondUnitTextBox = new System.Windows.Forms.TextBox();
            this.thirdUnitTextBox = new System.Windows.Forms.TextBox();
            this.fourthUnitTextBox = new System.Windows.Forms.TextBox();
            this.fithunitTextBox = new System.Windows.Forms.TextBox();
            this.sixthunitTextBox = new System.Windows.Forms.TextBox();
            this.seventhUnitTextBox = new System.Windows.Forms.TextBox();
            this.eigthUnitTextBox = new System.Windows.Forms.TextBox();
            this.SecondUnitMarks = new System.Windows.Forms.TextBox();
            this.ThirdUnitMarks = new System.Windows.Forms.TextBox();
            this.FourthUnitMarks = new System.Windows.Forms.TextBox();
            this.FifthUnitMarks = new System.Windows.Forms.TextBox();
            this.SixthUnitMarks = new System.Windows.Forms.TextBox();
            this.SeventhUnitMarks = new System.Windows.Forms.TextBox();
            this.EightUnitMarks = new System.Windows.Forms.TextBox();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.saveGradeBtn = new System.Windows.Forms.Button();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.studentIdTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(186, 149);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(156, 20);
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
            this.searchBtn.Location = new System.Drawing.Point(371, 147);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(56, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
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
            this.studentId.Size = new System.Drawing.Size(63, 13);
            this.studentId.TabIndex = 4;
            this.studentId.Text = "Student\'s Id";
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
            this.unitsLabel.Size = new System.Drawing.Size(31, 13);
            this.unitsLabel.TabIndex = 9;
            this.unitsLabel.Text = "Units";
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
            // FirstUnitMarks
            // 
            this.FirstUnitMarks.Location = new System.Drawing.Point(309, 331);
            this.FirstUnitMarks.Name = "FirstUnitMarks";
            this.FirstUnitMarks.Size = new System.Drawing.Size(54, 20);
            this.FirstUnitMarks.TabIndex = 12;
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
            // SecondUnitMarks
            // 
            this.SecondUnitMarks.Location = new System.Drawing.Point(309, 357);
            this.SecondUnitMarks.Name = "SecondUnitMarks";
            this.SecondUnitMarks.Size = new System.Drawing.Size(54, 20);
            this.SecondUnitMarks.TabIndex = 20;
            // 
            // ThirdUnitMarks
            // 
            this.ThirdUnitMarks.Location = new System.Drawing.Point(309, 384);
            this.ThirdUnitMarks.Name = "ThirdUnitMarks";
            this.ThirdUnitMarks.Size = new System.Drawing.Size(54, 20);
            this.ThirdUnitMarks.TabIndex = 21;
            // 
            // FourthUnitMarks
            // 
            this.FourthUnitMarks.Location = new System.Drawing.Point(309, 410);
            this.FourthUnitMarks.Name = "FourthUnitMarks";
            this.FourthUnitMarks.Size = new System.Drawing.Size(54, 20);
            this.FourthUnitMarks.TabIndex = 22;
            // 
            // FifthUnitMarks
            // 
            this.FifthUnitMarks.Location = new System.Drawing.Point(309, 436);
            this.FifthUnitMarks.Name = "FifthUnitMarks";
            this.FifthUnitMarks.Size = new System.Drawing.Size(54, 20);
            this.FifthUnitMarks.TabIndex = 23;
            // 
            // SixthUnitMarks
            // 
            this.SixthUnitMarks.Location = new System.Drawing.Point(309, 462);
            this.SixthUnitMarks.Name = "SixthUnitMarks";
            this.SixthUnitMarks.Size = new System.Drawing.Size(54, 20);
            this.SixthUnitMarks.TabIndex = 24;
            // 
            // SeventhUnitMarks
            // 
            this.SeventhUnitMarks.Location = new System.Drawing.Point(309, 488);
            this.SeventhUnitMarks.Name = "SeventhUnitMarks";
            this.SeventhUnitMarks.Size = new System.Drawing.Size(54, 20);
            this.SeventhUnitMarks.TabIndex = 25;
            // 
            // EightUnitMarks
            // 
            this.EightUnitMarks.Location = new System.Drawing.Point(309, 514);
            this.EightUnitMarks.Name = "EightUnitMarks";
            this.EightUnitMarks.Size = new System.Drawing.Size(54, 20);
            this.EightUnitMarks.TabIndex = 26;
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
            this.studentIdTxtBox.Location = new System.Drawing.Point(65, 252);
            this.studentIdTxtBox.Name = "studentIdTxtBox";
            this.studentIdTxtBox.ReadOnly = true;
            this.studentIdTxtBox.Size = new System.Drawing.Size(65, 20);
            this.studentIdTxtBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID :";
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
            this.Controls.Add(this.EightUnitMarks);
            this.Controls.Add(this.SeventhUnitMarks);
            this.Controls.Add(this.SixthUnitMarks);
            this.Controls.Add(this.FifthUnitMarks);
            this.Controls.Add(this.FourthUnitMarks);
            this.Controls.Add(this.ThirdUnitMarks);
            this.Controls.Add(this.SecondUnitMarks);
            this.Controls.Add(this.eigthUnitTextBox);
            this.Controls.Add(this.seventhUnitTextBox);
            this.Controls.Add(this.sixthunitTextBox);
            this.Controls.Add(this.fithunitTextBox);
            this.Controls.Add(this.fourthUnitTextBox);
            this.Controls.Add(this.thirdUnitTextBox);
            this.Controls.Add(this.secondUnitTextBox);
            this.Controls.Add(this.FirstUnitMarks);
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
        private System.Windows.Forms.TextBox FirstUnitMarks;
        private System.Windows.Forms.TextBox secondUnitTextBox;
        private System.Windows.Forms.TextBox thirdUnitTextBox;
        private System.Windows.Forms.TextBox fourthUnitTextBox;
        private System.Windows.Forms.TextBox fithunitTextBox;
        private System.Windows.Forms.TextBox sixthunitTextBox;
        private System.Windows.Forms.TextBox seventhUnitTextBox;
        private System.Windows.Forms.TextBox eigthUnitTextBox;
        private System.Windows.Forms.TextBox SecondUnitMarks;
        private System.Windows.Forms.TextBox ThirdUnitMarks;
        private System.Windows.Forms.TextBox FourthUnitMarks;
        private System.Windows.Forms.TextBox FifthUnitMarks;
        private System.Windows.Forms.TextBox SixthUnitMarks;
        private System.Windows.Forms.TextBox SeventhUnitMarks;
        private System.Windows.Forms.TextBox EightUnitMarks;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button saveGradeBtn;
        private System.Windows.Forms.PictureBox studentImage;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.TextBox studentIdTxtBox;
        private System.Windows.Forms.Label label1;
    }
}

