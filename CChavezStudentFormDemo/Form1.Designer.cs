namespace CChavezStudentFormDemo
{
    partial class fCchavezStudentFormDemo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStudentID = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            txbStudentID = new TextBox();
            txbFirstName = new TextBox();
            txbLastName = new TextBox();
            groupBox1 = new GroupBox();
            rbIT = new RadioButton();
            rbWebDesign = new RadioButton();
            rbProgramming = new RadioButton();
            lblCourses = new Label();
            lblScores = new Label();
            cbxCIS101 = new CheckBox();
            cbxCIS102 = new CheckBox();
            cbxCIS104 = new CheckBox();
            cbxCIS103 = new CheckBox();
            lblFormName = new Label();
            txbScore1 = new TextBox();
            txbScore2 = new TextBox();
            txbScore3 = new TextBox();
            txbScore4 = new TextBox();
            btnSubmit = new Button();
            txbResult = new TextBox();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(276, 76);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(96, 25);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = "Student ID";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(276, 127);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 25);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(276, 175);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 25);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            lblLastName.Click += lblLastName_Click;
            // 
            // txbStudentID
            // 
            txbStudentID.Location = new Point(387, 76);
            txbStudentID.Name = "txbStudentID";
            txbStudentID.Size = new Size(150, 31);
            txbStudentID.TabIndex = 3;
            // 
            // txbFirstName
            // 
            txbFirstName.Location = new Point(387, 127);
            txbFirstName.Name = "txbFirstName";
            txbFirstName.Size = new Size(150, 31);
            txbFirstName.TabIndex = 4;
            // 
            // txbLastName
            // 
            txbLastName.Location = new Point(387, 175);
            txbLastName.Name = "txbLastName";
            txbLastName.Size = new Size(150, 31);
            txbLastName.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbIT);
            groupBox1.Controls.Add(rbWebDesign);
            groupBox1.Controls.Add(rbProgramming);
            groupBox1.Location = new Point(267, 227);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 197);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Major";
            // 
            // rbIT
            // 
            rbIT.AutoSize = true;
            rbIT.Location = new Point(20, 142);
            rbIT.Name = "rbIT";
            rbIT.Size = new Size(51, 29);
            rbIT.TabIndex = 2;
            rbIT.TabStop = true;
            rbIT.Text = "IT";
            rbIT.UseVisualStyleBackColor = true;
            // 
            // rbWebDesign
            // 
            rbWebDesign.AutoSize = true;
            rbWebDesign.Location = new Point(20, 94);
            rbWebDesign.Name = "rbWebDesign";
            rbWebDesign.Size = new Size(133, 29);
            rbWebDesign.TabIndex = 1;
            rbWebDesign.TabStop = true;
            rbWebDesign.Text = "Web Design";
            rbWebDesign.UseVisualStyleBackColor = true;
            // 
            // rbProgramming
            // 
            rbProgramming.AutoSize = true;
            rbProgramming.Location = new Point(20, 43);
            rbProgramming.Name = "rbProgramming";
            rbProgramming.Size = new Size(147, 29);
            rbProgramming.TabIndex = 0;
            rbProgramming.TabStop = true;
            rbProgramming.Text = "Programming";
            rbProgramming.UseVisualStyleBackColor = true;
            // 
            // lblCourses
            // 
            lblCourses.AutoSize = true;
            lblCourses.Location = new Point(274, 432);
            lblCourses.Name = "lblCourses";
            lblCourses.Size = new Size(75, 25);
            lblCourses.TabIndex = 7;
            lblCourses.Text = "Courses";
            // 
            // lblScores
            // 
            lblScores.AutoSize = true;
            lblScores.Location = new Point(465, 432);
            lblScores.Name = "lblScores";
            lblScores.Size = new Size(64, 25);
            lblScores.TabIndex = 8;
            lblScores.Text = "Scores";
            // 
            // cbxCIS101
            // 
            cbxCIS101.AutoSize = true;
            cbxCIS101.Location = new Point(274, 471);
            cbxCIS101.Name = "cbxCIS101";
            cbxCIS101.Size = new Size(99, 29);
            cbxCIS101.TabIndex = 9;
            cbxCIS101.Text = "CIS 101";
            cbxCIS101.UseVisualStyleBackColor = true;
            // 
            // cbxCIS102
            // 
            cbxCIS102.AutoSize = true;
            cbxCIS102.Location = new Point(274, 514);
            cbxCIS102.Name = "cbxCIS102";
            cbxCIS102.Size = new Size(99, 29);
            cbxCIS102.TabIndex = 10;
            cbxCIS102.Text = "CIS 102";
            cbxCIS102.UseVisualStyleBackColor = true;
            // 
            // cbxCIS104
            // 
            cbxCIS104.AutoSize = true;
            cbxCIS104.Location = new Point(274, 600);
            cbxCIS104.Name = "cbxCIS104";
            cbxCIS104.Size = new Size(99, 29);
            cbxCIS104.TabIndex = 11;
            cbxCIS104.Text = "CIS 104";
            cbxCIS104.UseVisualStyleBackColor = true;
            // 
            // cbxCIS103
            // 
            cbxCIS103.AutoSize = true;
            cbxCIS103.Location = new Point(274, 557);
            cbxCIS103.Name = "cbxCIS103";
            cbxCIS103.Size = new Size(99, 29);
            cbxCIS103.TabIndex = 12;
            cbxCIS103.Text = "CIS 103";
            cbxCIS103.UseVisualStyleBackColor = true;
            // 
            // lblFormName
            // 
            lblFormName.AutoSize = true;
            lblFormName.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormName.Location = new Point(278, 9);
            lblFormName.Name = "lblFormName";
            lblFormName.Size = new Size(224, 45);
            lblFormName.TabIndex = 13;
            lblFormName.Text = "Student Form";
            // 
            // txbScore1
            // 
            txbScore1.Location = new Point(422, 469);
            txbScore1.Name = "txbScore1";
            txbScore1.Size = new Size(150, 31);
            txbScore1.TabIndex = 14;
            // 
            // txbScore2
            // 
            txbScore2.Location = new Point(422, 512);
            txbScore2.Name = "txbScore2";
            txbScore2.Size = new Size(150, 31);
            txbScore2.TabIndex = 15;
            // 
            // txbScore3
            // 
            txbScore3.Location = new Point(422, 555);
            txbScore3.Name = "txbScore3";
            txbScore3.Size = new Size(150, 31);
            txbScore3.TabIndex = 16;
            // 
            // txbScore4
            // 
            txbScore4.Location = new Point(422, 598);
            txbScore4.Name = "txbScore4";
            txbScore4.Size = new Size(150, 31);
            txbScore4.TabIndex = 17;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(340, 660);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 18;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txbResult
            // 
            txbResult.Location = new Point(25, 700);
            txbResult.Multiline = true;
            txbResult.Name = "txbResult";
            txbResult.ReadOnly = true;
            txbResult.Size = new Size(709, 217);
            txbResult.TabIndex = 19;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(66, 660);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(149, 25);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "CNM Home Page";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cnmlogo;
            pictureBox1.Location = new Point(25, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // fCchavezStudentFormDemo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 929);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(txbResult);
            Controls.Add(btnSubmit);
            Controls.Add(txbScore4);
            Controls.Add(txbScore3);
            Controls.Add(txbScore2);
            Controls.Add(txbScore1);
            Controls.Add(lblFormName);
            Controls.Add(cbxCIS103);
            Controls.Add(cbxCIS104);
            Controls.Add(cbxCIS102);
            Controls.Add(cbxCIS101);
            Controls.Add(lblScores);
            Controls.Add(lblCourses);
            Controls.Add(groupBox1);
            Controls.Add(txbLastName);
            Controls.Add(txbFirstName);
            Controls.Add(txbStudentID);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblStudentID);
            Name = "fCchavezStudentFormDemo";
            Text = "CChavez Student Form Demo";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentID;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txbStudentID;
        private TextBox txbFirstName;
        private TextBox txbLastName;
        private GroupBox groupBox1;
        private RadioButton rbIT;
        private RadioButton rbWebDesign;
        private RadioButton rbProgramming;
        private Label lblCourses;
        private Label lblScores;
        private CheckBox cbxCIS101;
        private CheckBox cbxCIS102;
        private CheckBox cbxCIS104;
        private CheckBox cbxCIS103;
        private Label lblFormName;
        private TextBox txbScore1;
        private TextBox txbScore2;
        private TextBox txbScore3;
        private TextBox txbScore4;
        private Button btnSubmit;
        private TextBox txbResult;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}
