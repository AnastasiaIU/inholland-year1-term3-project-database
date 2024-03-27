using Microsoft.IdentityModel.Tokens;
using SomerenModel;
using System;
using System.Collections.Generic;

namespace SomerenUI
{
    public partial class EditStudentForm : BaseForm
    {
        Student currentStudent;
        public EditStudentForm()
        {
            InitializeComponent();
            Size = new System.Drawing.Size(411, 486);
            Text = "Create Student";
            btnUpdateStudent.Hide();
            List<Room> rooms = roomService.GetRooms();

            foreach (Room room in rooms)
                if (!room.ToString().StartsWith("A0"))
                    cmbRooms.Items.Add(room);

            cmbRooms.SelectedIndex = 0;
        }

        public EditStudentForm(Student student)
        {
            InitializeComponent();
            Size = new System.Drawing.Size(411, 350);
            Text = "Edit Student";
            btnCreateStudent.Hide();
            txtStudentNumber.Hide();
            txtClassNumber.Hide();
            cmbRooms.Hide();
            lblStudentNumber.Hide();
            lblClassNumber.Hide();
            lblRoomNumber.Hide();
            currentStudent = student;
            LoadText();
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs(out int studentNumber, out string firstName, out string lastName, out string phoneNumber, out string classNumber);
                string roomNumber = ((Room)cmbRooms.SelectedItem).ToString();

                Student student = new Student(studentNumber, roomNumber, firstName, lastName, phoneNumber, classNumber);
                studentService.CreateStudent(student);
                Close();
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs(out string firstName, out string lastName, out string phoneNumber);

                Student student = new Student(currentStudent.StudentNumber, currentStudent.RoomNumber, firstName, lastName, phoneNumber, currentStudent.ClassNumber);
                studentService.UpdateStudent(student);
                Close();
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }
        }

        private void ValidateInputs(out string firstName, out string lastName, out string phoneNumber)
        {
            if (txtFirstName.Text.IsNullOrEmpty())
                throw new Exception(Properties.Resources.ErrorMessageNoFirstName);
            else
                firstName = txtFirstName.Text;

            if (txtLastName.Text.IsNullOrEmpty())
                throw new Exception(Properties.Resources.ErrorMessageNoLastName);
            else
                lastName = txtLastName.Text;

            phoneNumber = txtPhoneNumber.Text;
        }

        private void ValidateInputs(out int studentNumber, out string firstName, out string lastName, out string phoneNumber, out string classNumber)
        {
            if (txtFirstName.Text.IsNullOrEmpty())
                throw new Exception(Properties.Resources.ErrorMessageNoFirstName);
            else
                firstName = txtFirstName.Text;

            if (txtLastName.Text.IsNullOrEmpty())
                throw new Exception(Properties.Resources.ErrorMessageNoLastName);
            else
                lastName = txtLastName.Text;

            phoneNumber = txtPhoneNumber.Text;

            if (txtStudentNumber.Text.Length > 6)
                throw new Exception(Properties.Resources.ErrorMessageStudentNumberLength);
            else if (!int.TryParse((txtStudentNumber.Text), out int tryGetStudentNumber))
                throw new Exception(Properties.Resources.ErrorMessageWrongStudentNumber);
            else
                studentNumber = tryGetStudentNumber;

            List<Student> students = studentService.GetStudents();
            foreach (Student student in students)
                if (student.StudentNumber == studentNumber)
                    throw new Exception(Properties.Resources.ErrorMessageExistingStudentNumber);

            if (txtClassNumber.Text.IsNullOrEmpty())
                throw new Exception(Properties.Resources.ErrorMessageWrongClass);
            else
                classNumber = txtClassNumber.Text;
        }

        private void LoadText()
        {
            txtFirstName.Text = currentStudent.FirstName;
            txtLastName.Text = currentStudent.LastName;
            txtPhoneNumber.Text = currentStudent.PhoneNumber;
        }
    }
}
