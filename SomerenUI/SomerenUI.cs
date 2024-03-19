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
            pnlActivities.Hide();
            pnlDrinks.Hide();

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
                // get and display all students                
                DisplayLecturers(GetLecturers());
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
                DisplayRooms(GetRooms());
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }

        private void ShowActivitiesPanel()
        {
            ShowPanel(pnlActivities);

            try
            {
                // get and display all activities
                List<Activity> activities = GetActivities();
                DisplayActivities(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }

        private void ShowDrinksPanel()
        {
            ShowPanel(pnlDrinks);

            try
            {
                // get and display all rooms                
                DisplayDrinks(GetDrinks());
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drinks: " + e.Message);
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

        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            return activityService.GetActivities();
        }

        private List<Drink> GetDrinks()
        {
            DrinkService drinkService = new DrinkService();
            return drinkService.GetDrinks();
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

        private void DisplayActivities(List<Activity> activities)
        {
            // clear the listview before filling it
            listViewActivities.Items.Clear();

            foreach (Activity activity in activities)
            {
                ListViewItem item = CreateActivityListViewItem(activity);
                listViewActivities.Items.Add(item);
            }
        }

        private ListViewItem CreateActivityListViewItem(Activity activity)
        {
            ListViewItem item = new ListViewItem(activity.ActivityName);
            item.SubItems.Add(activity.StartTime.ToString());
            item.SubItems.Add(activity.EndTime.ToString());
            item.Tag = activity;     // link room object to listview item

            return item;
        }

        private void DisplayDrinks(List<Drink> drinks)
        {
            // clear the listview before filling it
            listViewDrinks.Items.Clear();

            foreach (Drink drink in drinks)
            {
                ListViewItem item = CreateDrinkListViewItem(drink);
                listViewDrinks.Items.Add(item);
            }
        }

        private ListViewItem CreateDrinkListViewItem(Drink drink)
        {
            string isAlcoholic = drink.IsAlcholic ? "Yes" : "No";

            ListViewItem item = new ListViewItem(drink.Name);
            item.SubItems.Add(drink.Price.ToString("0.00"));
            item.SubItems.Add(isAlcoholic);
            item.SubItems.Add(drink.Stock.ToString());
            item.SubItems.Add(drink.StockLevel);
            item.Tag = drink;     // link room object to listview item

            return item;
        }

        /*CreateDrink click event
         * 
         * bool isAlcoholic = combobox for IsAlcocholic 
         * 
         * Drink drink = new Drink(fakeId, txtDrinkPrice.Text, isAlcoholic, txtDrinkName.Text, txtDrinkStock.Text);
         * DrinkService drinkService = new DrinkService();
         * drinkService.CreateDrink(drink);
         * 
         * MessageBox.Show($"Successfully added: {drink.Name});
         * 
         */

        /*UpdateDrink click event
         * 
         * bool isAlcoholic = combobox for IsAlcocholic 
         * 
         * Drink drink = new Drink(txtDrinkPrice.Text, isAlcoholic, txtDrinkName.Text, txtDrinkStock.Text);
         * DrinkService drinkService = new DrinkService();
         * drinkService.UpdateDrink(drink);
         * 
         * MessageBox.Show($"Successfully updated: {drink.Name});
         * 
         */

        /*Load txt
         * 
         * DrinkService drinkService = new DrinkService();
         * Drink drink = drinkService.GetById(id);
         * txtDrinkName.Text = drink.Name;
         * txtDrinkPrice.Text = drink.Price;
         * combox select isAlcoholic
         * txtDrinkStock.Text = drink.Stock; 
         * 
         */

        /*DeleteDrink click event
         * 
         * DrinkService drinkService = new DrinkService();
         * Drink drink = (Drink)listViewDrinks.SelectedItem;
         * drinkService.DeleteDrink((Drink)listViewDrinks.SelectedItem);
         * 
         * MessageBox.Show($"Successfully deleted: {drink.Name}");
         * 
         */

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

        private void menuItemDrinks_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
        }
    }
}