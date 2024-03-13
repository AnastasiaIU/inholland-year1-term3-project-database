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

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlLecturers.Hide();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlRooms.Hide();
            pnlLecturers.Hide();

            // show students
            pnlStudents.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private void ShowRoomsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();

            // show students
            pnlRooms.Show();

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

        private void ShowLecturersPanel()
        {
            pnlDashboard.Hide();
            pnlStudents.Hide();

            pnlLecturers.Show();

            try
            {
                // get and display all students
                List<Lecturer> lecturers = GetLecturers();
                DisplayLecturers(lecturers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }

        private List<Lecturer> GetLecturers()
        {
            LecturerService lecturerService = new LecturerService();
            List<Lecturer> lecturers = lecturerService.GetLecturers();
            return lecturers;
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.Name);
                li.Tag = student;   // link student object to listview item
                listViewStudents.Items.Add(li);
            }
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

        private void DisplayLecturers(List<Lecturer> lecturers)
        {

            listViewLecturers.Items.Clear();

            foreach (Lecturer lecturer in lecturers)
            {
                ListViewItem li = new ListViewItem(lecturer.FirstName);
                li.Tag = lecturer;                
                li.SubItems.Add(lecturer.LastName);
                li.SubItems.Add(lecturer.PhoneNumber);
                li.SubItems.Add(lecturer.Age.ToString());
                listViewLecturers.Items.Add(li);
            }
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
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