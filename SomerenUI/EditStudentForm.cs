using SomerenModel;
using System;
using System.Collections.Generic;

namespace SomerenUI
{
    public partial class EditStudentForm : BaseForm
    {
        Student currentStudent;
        const int FormWidth = 290;
        const int CreateStudentHeight = 300;
        const int EditStudentHeight = 200;
        const int StudentNumberLength = 6;

        public EditStudentForm()
        {
            InitializeComponent();
            LoadForm(Properties.Resources.CreateStudent);
        }

        public EditStudentForm(Student student)
        {
            InitializeComponent();
            currentStudent = student;
            LoadForm(Properties.Resources.EditStudent);
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = ValidateStringOrThrow(txtFirstName.Text, Properties.Resources.ErrorMessageNoFirstName);
                string lastName = ValidateStringOrThrow(txtLastName.Text, Properties.Resources.ErrorMessageNoLastName);
                int studentNumber = ValidateStudentNumberOrThrow(txtStudentNumber.Text);
                string roomNumber = ((Room)cmbRooms.SelectedItem).ToString();
                string classNumber = ValidateStringOrThrow(txtClassNumber.Text, Properties.Resources.ErrorMessageNoClass);

                Student student = new Student(studentNumber, roomNumber, firstName, lastName, txtPhoneNumber.Text, classNumber);
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
                string firstName = ValidateStringOrThrow(txtFirstName.Text, Properties.Resources.ErrorMessageNoFirstName);
                string lastName = ValidateStringOrThrow(txtLastName.Text, Properties.Resources.ErrorMessageNoLastName);

                Student student = new Student(currentStudent.StudentNumber, currentStudent.RoomNumber, firstName, lastName, txtPhoneNumber.Text, currentStudent.ClassNumber);
                studentService.UpdateStudent(student);
                Close();
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }
        }

        private int ValidateStudentNumberOrThrow(string studentNumberString)
        {
            int studentNumber;
            if (studentNumberString.Length != StudentNumberLength)
                throw new Exception(Properties.Resources.ErrorMessageStudentNumberLength);
            else if (!int.TryParse((studentNumberString), out int parsedStudentNumber))
                throw new Exception(Properties.Resources.ErrorMessageWrongStudentNumber);
            else
                studentNumber = parsedStudentNumber;

            List<Student> students = studentService.GetAllStudents();
            foreach (Student student in students)
                if (student.StudentNumber == studentNumber)
                    throw new Exception(Properties.Resources.ErrorMessageExistingStudentNumber);

            return studentNumber;
        }

        private void LoadForm(string formName)
        {
            Text = formName;
            HideControls();
            if (formName.Equals(Properties.Resources.CreateStudent))
            {
                Size = new System.Drawing.Size(FormWidth, CreateStudentHeight);
                FillComboBoxRooms();
            }
            else
            {
                Size = new System.Drawing.Size(FormWidth, EditStudentHeight);
                LoadText();
            }
        }

        private void HideControls()
        {
            if (Text.Equals(Properties.Resources.CreateStudent))
                btnUpdateStudent.Hide();
            else
            {
                btnCreateStudent.Hide();
                txtStudentNumber.Hide();
                txtClassNumber.Hide();
                cmbRooms.Hide();
                lblStudentNumber.Hide();
                lblClassNumber.Hide();
                lblRoomNumber.Hide();
            }
        }

        private void FillComboBoxRooms()
        {
            List<Room> rooms = roomService.GetAllRooms();
            foreach (Room room in rooms)
                if (!room.ToString().StartsWith(Properties.Resources.LecturerRoomStart))
                    cmbRooms.Items.Add(room);

            cmbRooms.SelectedIndex = zero;
        }

        private void LoadText()
        {
            txtFirstName.Text = currentStudent.FirstName;
            txtLastName.Text = currentStudent.LastName;
            txtPhoneNumber.Text = currentStudent.PhoneNumber;
        }
    }
}
