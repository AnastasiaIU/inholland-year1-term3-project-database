using SomerenModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SomerenUI
{
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
        /// Populates the specified ListView with items generated from a list of data.
        /// </summary>
        /// <typeparam name="T">The type of data items in the list. Each data item will be used to generate a ListViewItem via the <paramref name="createListViewItem"/> function.</typeparam>
        /// <param name="listView">The ListView control to be populated with items.</param>
        /// <param name="data">A list of data items of type <typeparamref name="T"/>. This list is used to generate the ListView items. If this parameter is null, a message indicating no data is available will be shown.</param>
        /// <param name="createListViewItem">A function that takes a single data item of type <typeparamref name="T"/> and returns a ListViewItem. This function defines how each data item is represented as a ListViewItem in the ListView.</param>
        /// <remarks>
        /// This method first clears any existing items in the <paramref name="listView"/>. It then iterates over the <paramref name="data"/> list, using the <paramref name="createListViewItem"/> function to create a ListViewItem for each data item, which is then added to the ListView. If the data list is null, an error message is displayed to the user indicating that no data is available to show.
        /// </remarks>
        private void DisplayDataInListView<T>(ListView listView, List<T> data, Func<T, ListViewItem> createListViewItem)
        {
            if (data != null)
            {
                listView.Items.Clear();

                foreach (T t in data)
                {
                    ListViewItem item = createListViewItem(t);
                    listView.Items.Add(item);
                }
            }
            else
            {
                ShowMessage(Properties.Resources.ErrorMessage, Properties.Resources.ErrorMessageNoDataToShow);
            }
        }

        private void ShowDashboardPanel()
        {
            ShowPanel(pnlDashboard);
        }

        private void ShowStudentsPanel()
        {
            ShowPanel(pnlStudents);
            List<Student> data = FetchData(GetStudents);
            DisplayDataInListView(listViewStudents, data, CreateStudentListViewItem);
        }

        private void ShowLecturersPanel()
        {
            ShowPanel(pnlLecturers);
            List<Lecturer> data = FetchData(GetLecturers);
            DisplayDataInListView(listViewLecturers, data, CreateLecturerListViewItem);
        }

        private void ShowActivitiesPanel()
        {
            ShowPanel(pnlActivities);
            List<Activity> data = FetchData(GetActivities);
            DisplayDataInListView(listViewActivities, data, CreateActivityListViewItem);
        }

        private void ShowActivitiesSupervisorsPanel()
        {
            ShowPanel(pnlActivitiesSupervisors);
            List<Activity> activities = FetchData(GetActivities);
            DisplayDataInListView(listViewActivitiesSupervisors, activities, CreateActivityListViewItem);

            Activity activity = GetSelectedItemFromListView<Activity>(listViewActivities, Properties.Resources.ErrorMessage);
            List<Lecturer> supervisors = FetchData(GetSupervisors, activity);
            DisplayDataInListView(listViewSupervisors, supervisors, CreateLecturerListViewItem);

            List<Lecturer> availableLecturers = FetchData(GetLecturers);
            DisplayDataInListView(listViewActivitiesSupervisorsLecturers, availableLecturers, CreateLecturerListViewItem);
        }

        private void ShowRoomsPanel()
        {
            ShowPanel(pnlRooms);
            List<Room> data = FetchData(GetRooms);
            DisplayDataInListView(listViewRooms, data, CreateRoomListViewItem);
        }

        private void ShowDrinksPanel()
        {
            ShowPanel(pnlDrinks);
            List<Drink> data = FetchData(GetDrinks);
            DisplayDataInListView(listViewDrinks, data, CreateDrinkListViewItem);
        }

        private void ShowPlaceOrderPanel()
        {
            ShowPanel(pnlPlaceOrder);
            List<Student> dataStudents = FetchData(GetStudents);
            DisplayDataInListView(listViewPlaceOrderStudents, dataStudents, CreatePlaceOrderStudentListViewItem);
            List<Drink> dataDrinks = FetchData(GetDrinks);
            DisplayDataInListView(listViewPlaceOrderDrinks, dataDrinks, CreatePlaceOrderDrinkListViewItem);
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

        private ListViewItem CreatePlaceOrderStudentListViewItem(Student student)
        {
            ListViewItem item = new ListViewItem(student.FirstName);
            item.SubItems.Add(student.LastName);
            item.SubItems.Add(student.StudentNumber.ToString());
            item.Tag = student;     // link students object to listview item

            return item;
        }

        private ListViewItem CreatePlaceOrderDrinkListViewItem(Drink drink)
        {
            string isAlcoholic = drink.IsAlcoholic ? Properties.Resources.Yes : Properties.Resources.No;

            ListViewItem item = new ListViewItem(drink.Name);
            item.SubItems.Add(drink.Price.ToString(Properties.Resources.MoneyFormat));
            item.SubItems.Add(drink.Stock.ToString());
            item.SubItems.Add(isAlcoholic);
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

        private void CreatePurchase(Student currentStudent, Drink currentDrink, int quantity)
        {
            int studentId = currentStudent.StudentNumber;
            int drinkId = currentDrink.Id;

            Purchase purchase = new Purchase(studentId, drinkId, quantity);
            purchaseService.CreatePurchase(purchase);
        }

        private void UpdateStock(Drink currentDrink, int quantity)
        {
            currentDrink.Stock -= quantity;
            drinkService.UpdateDrink(currentDrink);
        }

        private void calculateTotalPrice()
        {
            try
            {
                Drink currentDrink = (Drink)listViewPlaceOrderDrinks.SelectedItems[0].Tag;
                int quantity = int.Parse(txtBoxPlaceOrderQuantity.Text);
                double totalPrice = drinkService.GetTotalPrice(currentDrink, quantity);
                lblPlaceOrderTotalPriceValue.Text = totalPrice.ToString(Properties.Resources.MoneyFormat);
            }
            catch
            {
                lblPlaceOrderTotalPriceValue.Text = Properties.Resources.Zero;
            }
        }

        private void ResetPlaceOrderForm()
        {
            listViewPlaceOrderStudents.SelectedIndices.Clear();
            listViewPlaceOrderDrinks.SelectedIndices.Clear();
            txtBoxPlaceOrderQuantity.Clear();
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

        private void menuItemActivitiesSupervisors_Click(object sender, EventArgs e)
        {
            ShowActivitiesSupervisorsPanel();
        }

        private void menuItemRooms_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }

        private void menuItemDrinks_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }

        private void menuItemDrinksSupplies_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }

        private void menuItemPlaceOrder_Click(object sender, EventArgs e)
        {
            ShowPlaceOrderPanel();
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
                ShowMessage(errorMessage, ex.Message);
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
                ShowMessage(errorMessage, ex.Message);
            }
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Student currentStudent = GetSelectedItemFromListView<Student>(listViewPlaceOrderStudents, Properties.Resources.ErrorMessageStudentNotSelected);
                Drink currentDrink = GetSelectedItemFromListView<Drink>(listViewPlaceOrderDrinks, Properties.Resources.ErrorMessageDrinkNotSelected);
                int quantity = int.Parse(txtBoxPlaceOrderQuantity.Text);

                CreatePurchase(currentStudent, currentDrink, quantity);
                UpdateStock(currentDrink, quantity);

                ShowMessage(Properties.Resources.SuccessfullyAdded, Properties.Resources.NewPurchase);
                ResetPlaceOrderForm();
            }
            catch (Exception ex)
            {
                string errorMessage = ex is FormatException ? Properties.Resources.ErrorMessageWrongQuantityFormat : ex.Message;
                ShowMessage(Properties.Resources.ErrorMessage, errorMessage);
            }
        }

        private void calculateTotalPricePlaceOrder_Event(object sender, EventArgs e)
        {
            calculateTotalPrice();
        }

        private void calculateTotalPricePlaceOrder_Event(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            calculateTotalPrice();
        }
    }
}