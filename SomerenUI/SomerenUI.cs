using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
            ShowDashboardPanel();
        }

        private void ShowPanel(Panel panel)
        {
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlLecturers.Hide();
            pnlRooms.Hide();

            panel.Show();
        }

        private void ShowDashboardPanel()
        {
            ShowPanel(pnlDashboard);
        }

        private void ShowStudentsPanel()
        {
            ShowPanel(pnlStudents);

            try
            {
                // get and display all students                
                DisplayStudents(GetStudents());
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private void ShowLecturersPanel()
        {
            ShowPanel(pnlLecturers);

            try
            {
                // get and display all lecturers
                List<Lecturer> lecturers = GetLecturers();
                DisplayLecturers(lecturers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private void ShowRoomsPanel()
        {
            ShowPanel(pnlRooms);

            try
            {
                // get and display all rooms
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            return studentService.GetStudents();
        }

        private List<Lecturer> GetLecturers()
        {
            LecturerService lecturerService = new LecturerService();
            return lecturerService.GetLecturers();
        }

        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            return roomService.GetRooms();
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem item = CreateStudentListViewItem(student);                
                listViewStudents.Items.Add(item);
            }
        }

        private ListViewItem CreateStudentListViewItem(Student student)
        {
            ListViewItem item = new ListViewItem(student.FirstName);
            item.SubItems.Add(student.LastName);
            item.SubItems.Add(student.PhoneNumber);
            item.SubItems.Add(student.StudentNumber.ToString());
            item.SubItems.Add(student.ClassNumber);
            item.Tag = student;     // link students object to listview item

            return item;
        }

        private void DisplayLecturers(List<Lecturer> lecturers)
        {
            // clear the listview before filling it
            listViewLecturers.Items.Clear();

            foreach (Lecturer lecturer in lecturers)
            {
                ListViewItem item = CreateLecturerListViewItem(lecturer);
                listViewLecturers.Items.Add(item);
            }
        }

        private ListViewItem CreateLecturerListViewItem(Lecturer lecturer)
        {
            ListViewItem item = new ListViewItem(lecturer.FirstName);
            item.SubItems.Add(lecturer.LastName);
            item.SubItems.Add(lecturer.PhoneNumber);
            item.SubItems.Add(lecturer.Age.ToString());
            item.Tag = lecturer;     // link lecturer object to listview item

            return item;
        }

        private void DisplayRooms(List<Room> rooms)
        {
            // clear the listview before filling it
            listViewRooms.Items.Clear();

            foreach (Room room in rooms)
            {
                ListViewItem item = CreateRoomListViewItem(room);
                listViewRooms.Items.Add(item);
            }
        }

        private ListViewItem CreateRoomListViewItem(Room room)
        {
            string roomType = room.Type ? "Lecturer" : "Student";

            ListViewItem item = new ListViewItem(room.Number);
            item.SubItems.Add(room.Capacity.ToString());
            item.SubItems.Add(roomType);
            item.Tag = room;     // link room object to listview item

            return item;
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturersPanel();
        }
    }
}