using SomerenModel;
using System;
using System.Collections.Generic;

namespace SomerenUI
{
    public partial class EditStudentForm : BaseForm
    {
        Student currentStudent;
        const int FormWidth = 290;
        const int CreateStudentHeight = 310;
        const int EditStudentHeight = 205;
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

        /// <summary>
        /// Handles the click event for the "Create student" button.
        /// </summary>
        /// <remarks>
        /// Validates the student details entered in the form fields, creates a new Student instance, and then calls the studentService to create the student record in the database.
        /// Closes the form upon successful creation. Displays an error message if any validation fails or if an exception occurs.
        /// </remarks>
        private void ButtonCreateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = ReadStudent();
                studentService.CreateStudent(student);
                Close();
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }
        }

        /// <summary>
        /// Handles the click event for the "Update student" button.
        /// </summary>
        /// <remarks>
        /// Gathers updated student details from the form fields, creates a new Student instance with these details while preserving the student's number, and updates the student record in the database using studentService.
        /// Closes the form upon successful update. An error message is displayed if validation fails or an exception occurs.
        /// </remarks>
        private void ButtonUpdateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                bool forEditStudent = true;

                Student student = ReadStudent(forEditStudent);
                studentService.UpdateStudent(student);
                Close();
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }
        }

        /// <summary>
        /// Validates the format and uniqueness of a student number.
        /// </summary>
        /// <param name="studentNumberString">The student number as a string to validate.</param>
        /// <returns>The validated student number as an integer.</returns>
        /// <exception cref="Exception">Throws an exception if the student number does not meet length requirements, cannot be parsed to an integer, or already exists in the database.</exception>
        /// <remarks>
        /// Checks that the student number string has the correct length and can be parsed to an integer. Also ensures that no existing student has the same student number.
        /// </remarks>
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

        /// <summary>
        /// Configures the form based on the specified form name.
        /// </summary>
        /// <param name="formName">The name of the form to load, determining whether it's for creating or editing a student.</param>
        /// <remarks>
        /// Sets the form's title and size based on whether it's used for creating or editing a student. For creating a student, it fills the rooms combo box with available rooms.
        /// </remarks>
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

        /// <summary>
        /// Populates the rooms combo box with available rooms, excluding those designated for lecturers.
        /// </summary>
        /// <remarks>
        /// Retrieves all rooms from roomService, filtering out lecturer rooms based on a naming convention, and adds them to the rooms combo box.
        /// Selects the first room in the list by default.
        /// </remarks>
        private void FillComboBoxRooms()
        {
            List<Room> rooms = roomService.GetAllRooms();
            foreach (Room room in rooms)
                if (!room.ToString().StartsWith(Properties.Resources.LecturerRoomStart))
                    cmbRooms.Items.Add(room);

            cmbRooms.SelectedIndex = zero;
        }

        /// <summary>
        /// Loads the current student's details into the form fields.
        /// </summary>
        /// <remarks>
        /// Fills the form fields with the current student's first name, last name, and phone number. This method is typically called when initializing the form for student updates.
        /// </remarks>
        private void LoadText()
        {
            txtFirstName.Text = currentStudent.FirstName;
            txtLastName.Text = currentStudent.LastName;
            txtPhoneNumber.Text = currentStudent.PhoneNumber;
        }

        private Student ReadStudent(bool forEditStudent = false)
        {
            string firstName = ValidateStringOrThrow(txtFirstName.Text, Properties.Resources.ErrorMessageNoFirstName);
            string lastName = ValidateStringOrThrow(txtLastName.Text, Properties.Resources.ErrorMessageNoLastName);

            if (!forEditStudent)
            {
                int studentNumber = ValidateStudentNumberOrThrow(txtStudentNumber.Text);
                string roomNumber = ((Room)cmbRooms.SelectedItem).ToString();
                string classNumber = ValidateStringOrThrow(txtClassNumber.Text, Properties.Resources.ErrorMessageNoClass);

                return new Student(studentNumber, roomNumber, firstName, lastName, txtPhoneNumber.Text, classNumber);
            }

            return new Student(currentStudent.StudentNumber, currentStudent.RoomNumber, firstName, lastName, txtPhoneNumber.Text, currentStudent.ClassNumber);
        }
    }
}
