using SomerenModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SomerenUI
{
    // MAKE RESEARCH ON PROPER BASE CLASS FOR FORMS
    // ADD COMMENTS
    public partial class SomerenUI : BaseForm
    {
        public SomerenUI()
        {
            InitializeComponent();
            ShowDashboardPanel();
        }

        private void ShowPanel(Panel panel)
        {
            string panelName = Properties.Resources.PanelName;

            foreach (Control control in Controls)
                if (control.Name.StartsWith(panelName)) control.Hide();

            panel.Show();
        }

        /// <summary>
        /// Calculates the total price for a given drink and quantity.
        /// </summary>
        /// <param name="price">The drink for which to calculate the total price.</param>
        /// <param name="isAlcholic">The quantity of the drink.</param>
        /// <returns>The total price for the given drink and quantity.</returns>
        private void DisplayDataInListView<T>(ListView listView, List<T> data, Func<T, ListViewItem> createListViewItem)
        {
            // clear the listview before filling it
            listView.Items.Clear();

            foreach (T t in data)
            {
                ListViewItem item = createListViewItem(t);
                listView.Items.Add(item);
            }
        }

        private void ShowPanelWithList<T>
            (
            Panel panel,
            ListView listView,
            List<T> data,
            Func<T, ListViewItem> createListViewItem,
            Action<ListView, List<T>, Func<T, ListViewItem>> displayData
            )
        {
            ShowPanel(panel);

            if (data != null)
                displayData(listView, data, createListViewItem);
        }

        private void ShowDashboardPanel()
        {
            ShowPanel(pnlDashboard);
        }

        private void ShowStudentsPanel()
        {
            List<Student> data = FetchData(GetStudents);
            ShowPanelWithList(pnlStudents, listViewStudents, data, CreateStudentListViewItem, DisplayDataInListView);
        }

        private void ShowLecturersPanel()
        {
            List<Lecturer> data = FetchData(GetLecturers);
            ShowPanelWithList(pnlLecturers, listViewLecturers, data, CreateLecturerListViewItem, DisplayDataInListView);
        }

        private void ShowActivitiesPanel()
        {
            List<Activity> data = FetchData(GetActivities);
            ShowPanelWithList(pnlActivities, listViewActivities, data, CreateActivityListViewItem, DisplayDataInListView);
        }

        private void ShowRoomsPanel()
        {
            List<Room> data = FetchData(GetRooms);
            ShowPanelWithList(pnlRooms, listViewRooms, data, CreateRoomListViewItem, DisplayDataInListView);
        }

        private void ShowDrinksPanel()
        {
            List<Drink> data = FetchData(GetDrinks);
            ShowPanelWithList(pnlDrinks, listViewDrinks, data, CreateDrinkListViewItem, DisplayDataInListView);
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

        private ListViewItem CreateLecturerListViewItem(Lecturer lecturer)
        {
            ListViewItem item = new ListViewItem(lecturer.FirstName);
            item.SubItems.Add(lecturer.LastName);
            item.SubItems.Add(lecturer.PhoneNumber);
            item.SubItems.Add(lecturer.Age.ToString());
            item.Tag = lecturer;     // link lecturer object to listview item

            return item;
        }

        private ListViewItem CreateActivityListViewItem(Activity activity)
        {
            ListViewItem item = new ListViewItem(activity.Name);
            item.SubItems.Add(activity.StartTime.ToString());
            item.SubItems.Add(activity.EndTime.ToString());
            item.Tag = activity;     // link activity object to listview item

            return item;
        }

        private ListViewItem CreateRoomListViewItem(Room room)
        {
            string roomType = room.IsForLecturer ? Properties.Resources.Lecturer : Properties.Resources.Student;

            ListViewItem item = new ListViewItem(room.Number);
            item.SubItems.Add(room.Capacity.ToString());
            item.SubItems.Add(roomType);
            item.Tag = room;     // link room object to listview item

            return item;
        }

        private ListViewItem CreateDrinkListViewItem(Drink drink)
        {
            string isAlcoholic = drink.IsAlcoholic ? Properties.Resources.Yes : Properties.Resources.No;
            string stockLevel = GetStockLevelString(drink.StockLevel);

            ListViewItem item = new ListViewItem(drink.Name);
            item.SubItems.Add(drink.Price.ToString(Properties.Resources.MoneyFormat));
            item.SubItems.Add(isAlcoholic);
            item.SubItems.Add(drink.Stock.ToString());
            item.SubItems.Add(stockLevel);
            item.Tag = drink;     // link drink object to listview item

            return item;
        }

        private string GetStockLevelString(StockLevel stockLevel)
        {
            string stockLevelString;

            switch (stockLevel)
            {
                case StockLevel.Empty:
                    stockLevelString = Properties.Resources.Empty;
                    break;
                case StockLevel.NearlyDepleted:
                    stockLevelString = Properties.Resources.NearlyDepleted;
                    break;
                default:
                    stockLevelString = Properties.Resources.Sufficient;
                    break;
            }

            return stockLevelString;
        }

        private void menuItemDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItemStudents_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void menuItemLecturers_Click(object sender, EventArgs e)
        {
            ShowLecturersPanel();
        }

        private void menuItemActivities_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
        }

        private void menuItemRooms_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }

        private void menuItemDrinks_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }

        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            OpenNewFormAndUpdateParentOnClose(new PurchaseDrinkForm(), ShowDrinksPanel);
        }

        private void btnCreateDrink_Click(object sender, EventArgs e)
        {
            OpenNewFormAndUpdateParentOnClose(new EditDrinkForm(), ShowDrinksPanel);
        }

        private void btnDeleteDrink_Click(object sender, EventArgs e)
        {
            try
            {
                Drink currentDrink = (Drink)listViewDrinks.SelectedItems[0].Tag;
                drinkService.DeleteDrink(currentDrink);
                ShowMessage(Properties.Resources.SuccessfullyDeleted, currentDrink.Name);
                ShowDrinksPanel();
            }
            catch (Exception ex)
            {
                string errorMessage = ex is ArgumentException ? Properties.Resources.ErrorMessageDrinkNotSelected : Properties.Resources.ErrorMessage;
                ShowError(errorMessage, ex);
            }
        }

        private void btnEditDrink_Click(object sender, EventArgs e)
        {
            try
            {
                Drink currentDrink = (Drink)listViewDrinks.SelectedItems[0].Tag;
                OpenNewFormAndUpdateParentOnClose(new EditDrinkForm(currentDrink), ShowDrinksPanel);
            }
            catch (Exception ex)
            {
                string errorMessage = ex is ArgumentException ? Properties.Resources.ErrorMessageDrinkNotSelected : Properties.Resources.ErrorMessage;
                ShowError(errorMessage, ex);
            }
        }
    }
}