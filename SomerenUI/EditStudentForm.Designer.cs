namespace SomerenUI
{
    partial class EditStudentForm
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
            lblFirstName = new System.Windows.Forms.Label();
            lblLastName = new System.Windows.Forms.Label();
            lblPhoneNumber = new System.Windows.Forms.Label();
            txtFirstName = new System.Windows.Forms.TextBox();
            txtLastName = new System.Windows.Forms.TextBox();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            btnCreateStudent = new System.Windows.Forms.Button();
            btnUpdateStudent = new System.Windows.Forms.Button();
            txtClassNumber = new System.Windows.Forms.TextBox();
            txtStudentNumber = new System.Windows.Forms.TextBox();
            cmbRooms = new System.Windows.Forms.ComboBox();
            lblStudentNumber = new System.Windows.Forms.Label();
            lblClassNumber = new System.Windows.Forms.Label();
            lblRoomNumber = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new System.Drawing.Point(80, 30);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(103, 25);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First name: ";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new System.Drawing.Point(82, 90);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(101, 25);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last name: ";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new System.Drawing.Point(45, 150);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new System.Drawing.Size(138, 25);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "Phone number: ";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new System.Drawing.Point(189, 30);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(150, 31);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(189, 90);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(150, 31);
            txtLastName.TabIndex = 4;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new System.Drawing.Point(189, 150);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new System.Drawing.Size(150, 31);
            txtPhoneNumber.TabIndex = 5;
            // 
            // btnCreateStudent
            // 
            btnCreateStudent.Location = new System.Drawing.Point(120, 390);
            btnCreateStudent.Name = "btnCreateStudent";
            btnCreateStudent.Size = new System.Drawing.Size(150, 34);
            btnCreateStudent.TabIndex = 10;
            btnCreateStudent.Text = "Create student";
            btnCreateStudent.UseVisualStyleBackColor = true;
            btnCreateStudent.Click += btnCreateStudent_Click;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.Location = new System.Drawing.Point(120, 210);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new System.Drawing.Size(150, 34);
            btnUpdateStudent.TabIndex = 10;
            btnUpdateStudent.Text = "Update student";
            btnUpdateStudent.UseVisualStyleBackColor = true;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            // 
            // txtClassNumber
            // 
            txtClassNumber.Location = new System.Drawing.Point(189, 270);
            txtClassNumber.Name = "txtClassNumber";
            txtClassNumber.Size = new System.Drawing.Size(150, 31);
            txtClassNumber.TabIndex = 7;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new System.Drawing.Point(189, 210);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new System.Drawing.Size(150, 31);
            txtStudentNumber.TabIndex = 6;
            // 
            // cmbRooms
            // 
            cmbRooms.FormattingEnabled = true;
            cmbRooms.Location = new System.Drawing.Point(189, 330);
            cmbRooms.Name = "cmbRooms";
            cmbRooms.Size = new System.Drawing.Size(150, 33);
            cmbRooms.TabIndex = 9;
            // 
            // lblStudentNumber
            // 
            lblStudentNumber.AutoSize = true;
            lblStudentNumber.Location = new System.Drawing.Point(34, 216);
            lblStudentNumber.Name = "lblStudentNumber";
            lblStudentNumber.Size = new System.Drawing.Size(149, 25);
            lblStudentNumber.TabIndex = 12;
            lblStudentNumber.Text = "Student number: ";
            // 
            // lblClassNumber
            // 
            lblClassNumber.AutoSize = true;
            lblClassNumber.Location = new System.Drawing.Point(55, 273);
            lblClassNumber.Name = "lblClassNumber";
            lblClassNumber.Size = new System.Drawing.Size(128, 25);
            lblClassNumber.TabIndex = 13;
            lblClassNumber.Text = "Class number: ";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new System.Drawing.Point(114, 333);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new System.Drawing.Size(69, 25);
            lblRoomNumber.TabIndex = 14;
            lblRoomNumber.Text = "Room: ";
            // 
            // EditStudentForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(389, 437);
            Controls.Add(lblRoomNumber);
            Controls.Add(lblClassNumber);
            Controls.Add(lblStudentNumber);
            Controls.Add(cmbRooms);
            Controls.Add(txtStudentNumber);
            Controls.Add(txtClassNumber);
            Controls.Add(btnUpdateStudent);
            Controls.Add(btnCreateStudent);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "EditStudentForm";
            Text = "EditStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.TextBox txtClassNumber;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.ComboBox cmbRooms;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblClassNumber;
        private System.Windows.Forms.Label lblRoomNumber;
    }
}