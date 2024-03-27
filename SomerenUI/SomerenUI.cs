using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class SomerenUI : BaseForm
    {
        private ActivityService activityService = new ActivityService();
        private LecturerService lecturerService = new LecturerService();
        private SupervisorService supervisorService = new SupervisorService();
        private PurchaseService purchaseService = new PurchaseService();

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
        /// Executes the provided function to fetch a list of data items of type <typeparamref name="T"/>.
        /// </summary>
        /// <param name="fetchData">A function delegate that, when invoked, returns a list of items of type <typeparamref name="T"/>. This function encapsulates the actual data fetching operation, which can vary depending on the specific type of data being requested.</param>
        /// <returns>
        /// A list containing the fetched data items of type <typeparamref name="T"/> if the operation is successful; otherwise, returns null if an exception is caught during the fetching operation.
        /// </returns>
        /// <remarks>
        /// If an exception occurs during the execution of the <paramref name="fetchData"/> function, the exception message is displayed to the user using <c>ShowMessage</c>, and null is returned. This method allows for a generic way to fetch different types of data while handling exceptions uniformly.
        /// </remarks>
        private List<T> FetchData<T>(Func<List<T>> fetchData)
        {
            List<T> data = null;

            try
            {
                data = fetchData();
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }

            return data;
        }

        private List<T> FetchData<T, TParam>(Func<TParam, List<T>> fetchData, TParam param)
        {
            List<T> data = null;

            try
            {
                data = fetchData(param);
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }

            return data;
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
            List<Student> data = FetchData(studentService.GetAllStudents);
            DisplayDataInListView(listViewStudents, data, CreateStudentListViewItem);
        }

        private void ShowManageStudentsPanel()
        {
            ShowPanel(pnlManageStudents);
            List<Student> data = FetchData(studentService.GetAllStudents);
            DisplayDataInListView(listViewManageStudents, data, CreateStudentListViewItem);
        }

        private void ShowLecturersPanel()
        {
            ShowPanel(pnlLecturers);
            List<Lecturer> data = FetchData(lecturerService.GetAllLecturers);
            DisplayDataInListView(listViewLecturers, data, CreateLecturerListViewItem);
        }

        private void ShowActivitiesPanel()
        {
            ShowPanel(pnlActivities);
            List<Activity> data = FetchData(activityService.GetAllActivities);
            DisplayDataInListView(listViewActivities, data, CreateActivityListViewItem);
        }

        private void ShowActivitySupervisorsPanel()
        {
            listViewSupervisors.Items.Clear();
            listViewActivitySupervisorsLecturers.Items.Clear();
            ShowPanel(pnlActivitySupervisors);
            List<Activity> activities = FetchData(activityService.GetAllActivities);
            DisplayDataInListView(listViewActivitySupervisors, activities, CreateActivityListViewItem);
        }

        private void ShowRoomsPanel()
        {
            ShowPanel(pnlRooms);
            List<Room> data = FetchData(roomService.GetAllRooms);
            DisplayDataInListView(listViewRooms, data, CreateRoomListViewItem);
        }

        private void ShowDrinksPanel()
        {
            ShowPanel(pnlDrinks);
            List<Drink> data = FetchData(drinkService.GetAllDrinks);
            DisplayDataInListView(listViewDrinks, data, CreateDrinkListViewItem);
        }

        private void ShowDrinkSuppliesPanel()
        {
            ShowPanel(pnlDrinkSupplies);
            List<Drink> data = FetchData(drinkService.GetAllDrinks);
            DisplayDataInListView(listViewDrinkSupplies, data, CreateDrinkSuppliesListViewItem);
        }

        private void ShowPlaceOrderPanel()
        {
            ShowPanel(pnlPlaceOrder);
            List<Student> dataStudents = FetchData(studentService.GetAllStudents);
            DisplayDataInListView(listViewPlaceOrderStudents, dataStudents, CreatePlaceOrderStudentListViewItem);
            List<Drink> dataDrinks = FetchData(drinkService.GetAllDrinks);
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

        private ListViewItem CreateDrinkSuppliesListViewItem(Drink drink)
        {
            string isAlcoholic = drink.IsAlcoholic ? Properties.Resources.Yes : Properties.Resources.No;
            string stockLevel = GetStockLevelString(drink.StockLevel);

            ListViewItem item = new ListViewItem(drink.Name);
            item.SubItems.Add(drink.Price.ToString(Properties.Resources.MoneyFormat));
            item.SubItems.Add(isAlcoholic);
            item.SubItems.Add(drink.Stock.ToString());
            item.SubItems.Add(stockLevel);
            item.SubItems.Add(drink.NumberOfPurchases.ToString());
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

        /// <summary>
        /// Retrieves the selected item of type <typeparamref name="T"/> from the provided ListView.
        /// </summary>
        /// <typeparam name="T">The type of the object associated with the ListView item. It is expected that the Tag property of each ListViewItem contains an object of this type.</typeparam>
        /// <param name="listView">The ListView control from which the selected item should be retrieved.</param>
        /// <param name="errorMessage">The error message to be included in the exception if no item is selected in the ListView.</param>
        /// <returns>The object of type <typeparamref name="T"/> associated with the selected ListViewItem's Tag property.</returns>
        /// <exception cref="Exception">Throws an exception with the provided <paramref name="errorMessage"/> if no item is selected in the ListView.</exception>
        /// <remarks>
        /// This method assumes that the Tag property of each ListViewItem in the ListView contains an object of type <typeparamref name="T"/>. It is designed to be used in scenarios where the ListView selection is expected to always contain exactly one selected item. If no item is selected, the method throws an exception with a custom error message.
        /// </remarks>
        protected T GetSelectedItemFromListView<T>(ListView listView, string errorMessage)
        {
            T selectedItem =
                listView.SelectedItems.Count != 0 ?
                (T)listView.SelectedItems[0].Tag :
                throw new Exception(errorMessage);

            return selectedItem;
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

        private void CalculateTotalPrice()
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

        /// <summary>
        /// Opens a new form dialog and executes an action to update the parent form upon the new form's closure.
        /// </summary>
        /// <param name="form">The form to be displayed as a modal dialog. This form is expected to perform some operation that requires the parent form to update once the dialog is closed.</param>
        /// <param name="updatePanel">An action delegate that encapsulates the updating logic for the parent form. This action is executed immediately after the modal dialog is closed, allowing the parent form to reflect any changes or updates made.</param>
        /// <remarks>
        /// This method is particularly useful for scenarios where opening a child form may result in changes that need to be reflected in the parent form (e.g., adding, editing, or deleting data). The <paramref name="updatePanel"/> action provides a flexible way to specify exactly how the parent form should respond once the child form is closed.
        /// </remarks>
        private void OpenNewFormAndUpdateParentOnClose(Form form, Action updatePanel)
        {
            form.ShowDialog();
            updatePanel();
        }

        private void ResetPlaceOrderForm()
        {
            listViewPlaceOrderStudents.SelectedIndices.Clear();
            listViewPlaceOrderDrinks.SelectedIndices.Clear();
            txtBoxPlaceOrderQuantity.Clear();
        }

        private void DisplaySupervisorsForActivity(Activity activity)
        {
            List<Lecturer> supervisors = FetchData(supervisorService.GetAllSupervisorsForActivity, activity);
            DisplayDataInListView(listViewSupervisors, supervisors, CreateLecturerListViewItem);
            List<Lecturer> availableLecturers = FetchData(supervisorService.GetAllAvailableSupervisorsForActivity, activity);
            DisplayDataInListView(listViewActivitySupervisorsLecturers, availableLecturers, CreateLecturerListViewItem);
        }

        private void menuItemDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItemLecturers_Click(object sender, EventArgs e)
        {
            ShowLecturersPanel();
        }

        private void menuItemActivities_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
        }

        private void menuItemActivitySupervisors_Click(object sender, EventArgs e)
        {
            ShowActivitySupervisorsPanel();
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
            ShowDrinkSuppliesPanel();
        }

        private void menuItemPlaceOrder_Click(object sender, EventArgs e)
        {
            ShowPlaceOrderPanel();
        }

        private void btnAddSupervisor_Click(object sender, EventArgs e)
        {
            try
            {
                Activity currentActivity = GetSelectedItemFromListView<Activity>(listViewActivitySupervisors, Properties.Resources.ErrorMessageActivityNotSelected);
                Lecturer currentLecturer = GetSelectedItemFromListView<Lecturer>(listViewActivitySupervisorsLecturers, Properties.Resources.ErrorMessageLecturerNotSelected);
                supervisorService.AddSupervisorToActivity(currentLecturer, currentActivity);
                ShowMessage(Properties.Resources.SuccessfullyAdded, currentLecturer.FullName);
                DisplaySupervisorsForActivity(currentActivity);
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }
        }

        private void btnDeleteSupervisor_Click(object sender, EventArgs e)
        {
            try
            {
                Activity currentActivity = GetSelectedItemFromListView<Activity>(listViewActivitySupervisors, Properties.Resources.ErrorMessageActivityNotSelected);
                Lecturer currentSupervisor = GetSelectedItemFromListView<Lecturer>(listViewSupervisors, Properties.Resources.ErrorMessageSupervisorNotSelected);

                DialogResult confirmResult = ShowConfirmDeletionMessageBox(currentSupervisor.FullName);
                if (confirmResult == DialogResult.Yes)
                {
                    supervisorService.DeleteSupervisorFromActivity(currentSupervisor, currentActivity);
                    ShowMessage(Properties.Resources.SuccessfullyDeleted, currentSupervisor.FullName);
                    DisplaySupervisorsForActivity(currentActivity);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }
        }

        private DialogResult ShowConfirmDeletionMessageBox(string deletionSubject)
        {
            string messageText = GetResourceStringWithArgument(Properties.Resources.DeletePrompt, deletionSubject);
            DialogResult confirmResult = MessageBox.Show(messageText, Properties.Resources.ConfirmDeletion, MessageBoxButtons.YesNo);
            return confirmResult;
        }

        private void btnCreateDrink_Click(object sender, EventArgs e)
        {
            OpenNewFormAndUpdateParentOnClose(new EditDrinkForm(), ShowDrinkSuppliesPanel);
        }

        private void btnDeleteDrink_Click(object sender, EventArgs e)
        {
            try
            {
                Drink currentDrink = GetSelectedItemFromListView<Drink>(listViewDrinkSupplies, Properties.Resources.ErrorMessageDrinkNotSelected);
                var confirmResult = MessageBox.Show($"Are you sure you want to delete {currentDrink.Name}?", Properties.Resources.ConfirmDeletion, MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    drinkService.DeleteDrink(currentDrink);
                    ShowMessage(Properties.Resources.SuccessfullyDeleted, currentDrink.Name);
                    ShowDrinkSuppliesPanel();
                }
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }
        }

        private void btnEditDrink_Click(object sender, EventArgs e)
        {
            try
            {
                Drink currentDrink = GetSelectedItemFromListView<Drink>(listViewDrinkSupplies, Properties.Resources.ErrorMessageDrinkNotSelected);
                OpenNewFormAndUpdateParentOnClose(new EditDrinkForm(currentDrink), ShowDrinkSuppliesPanel);
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
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
            CalculateTotalPrice();
        }

        private void calculateTotalPricePlaceOrder_Event(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            CalculateTotalPrice();
        }

        private void listViewActivitySupervisors_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if (listViewActivitySupervisors.SelectedItems.Count != 0)
                {
                    Activity activity = (Activity)listViewActivitySupervisors.SelectedItems[0].Tag;
                    DisplaySupervisorsForActivity(activity);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }
        }

        private void menuItemStudents_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void menuItemManageStudents_Click(object sender, EventArgs e)
        {
            ShowManageStudentsPanel();
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            OpenNewFormAndUpdateParentOnClose(new EditStudentForm(), ShowManageStudentsPanel);
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                Student currentStudent = GetSelectedItemFromListView<Student>(listViewManageStudents, Properties.Resources.ErrorMessageStudentNotSelected);
                var confirmResult = MessageBox.Show($"Are you sure you want to delete {currentStudent.FullName}?", Properties.Resources.ConfirmDeletion, MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    studentService.DeleteStudent(currentStudent);
                    ShowManageStudentsPanel();
                }
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            try
            {
                Student currentStudent = GetSelectedItemFromListView<Student>(listViewManageStudents, Properties.Resources.ErrorMessageStudentNotSelected);
                OpenNewFormAndUpdateParentOnClose(new EditStudentForm(currentStudent), ShowManageStudentsPanel);
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }
        }
    }
}