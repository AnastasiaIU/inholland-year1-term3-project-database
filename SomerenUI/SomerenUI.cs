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
            ShowPanel(pnlDashboard);
        }

        #region UI Logic

        private void ShowPanel(Panel panel)
        {
            string panelName = Properties.Resources.PanelName;

            foreach (Control control in Controls)
                if (control.Name.StartsWith(panelName)) control.Hide();

            panel.Show();
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
        private T GetSelectedItemFromListViewOrThrow<T>(ListView listView, string errorMessage)
        {
            T selectedItem =
                listView.SelectedItems.Count != zero ?
                (T)listView.SelectedItems[zero].Tag :
                throw new Exception(errorMessage);

            return selectedItem;
        }

        /// <summary>
        /// Formats a resource string by inserting the provided argument.
        /// </summary>
        /// <typeparam name="T">The type of the argument to be inserted into the resource string.</typeparam>
        /// <param name="resourceString">The resource string that contains a format item.</param>
        /// <param name="arg">The argument to insert into the resource string's format item.</param>
        /// <returns>A formatted string with the argument inserted.</returns>
        private string GetResourceStringWithArgument<T>(string resourceString, T arg)
        {
            return string.Format(resourceString, arg);
        }

        /// <summary>
        /// Retrieves the localized string representation of a specified stock level.
        /// </summary>
        /// <param name="stockLevel">The stock level to convert to a string.</param>
        /// <returns>A localized string that represents the specified stock level.</returns>
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

        /// <summary>
        /// Displays the total price of the staged purchase in the UI.
        /// </summary>
        /// <remarks>
        /// Attempts to calculate and show the total price of the currently staged purchase. If the calculation fails, displays a default value indicating zero.
        /// </remarks>
        private void ShowTotalPrice()
        {
            try
            {
                StagePurchaseFromPlaceOrderForm();
                double totalPrice = purchaseService.StagedPurchase.TotalPrice;
                lblPlaceOrderTotalPriceValue.Text = totalPrice.ToString(Properties.Resources.MoneyFormat);
            }
            catch
            {
                lblPlaceOrderTotalPriceValue.Text = Properties.Resources.Zero;
            }
        }

        /// <summary>
        /// Stages a purchase for creation based on the selections made in the Place Order form.
        /// </summary>
        /// <remarks>
        /// Retrieves the selected student and drink from their respective list views, along with the specified quantity, to stage a new purchase.
        /// Throws an exception if either the student or drink is not selected, or if the quantity is invalid.
        /// </remarks>
        private void StagePurchaseFromPlaceOrderForm()
        {
            Student currentStudent = GetSelectedItemFromListViewOrThrow<Student>(listViewPlaceOrderStudents, Properties.Resources.ErrorMessageStudentNotSelected);
            Drink currentDrink = GetSelectedItemFromListViewOrThrow<Drink>(listViewPlaceOrderDrinks, Properties.Resources.ErrorMessageDrinkNotSelected);
            int quantity = int.Parse(txtBoxPlaceOrderQuantity.Text);
            purchaseService.StagePurchaseForCreation(currentStudent, currentDrink, quantity);
        }

        /// <summary>
        /// Validates the staged purchase for any business rule violations.
        /// </summary>
        /// <remarks>
        /// Checks if the staged purchase has sufficient stock available and if the specified quantity is not zero.
        /// Throws an exception if the stock is insufficient or if the quantity is zero.
        /// </remarks>
        private void ValidatePurchaseOrThrow()
        {
            if (!purchaseService.StagedPurchase.IsQuantityAvailable)
                throw new Exception(Properties.Resources.ErrorMessageInsufficientStock);

            if (purchaseService.StagedPurchase.Quantity == zero)
                throw new Exception(Properties.Resources.ErrorMessageWrongQuantityFormat);
        }

        #endregion

        #region Form Handling

        /// <summary>
        /// Opens a new form dialog and executes an action to update the parent form upon the new form's closure.
        /// </summary>
        /// <param name="form">The form to be displayed as a modal dialog. This form is expected to perform some operation that requires the parent form to update once the dialog is closed.</param>
        /// <param name="updatePanel">An action delegate that encapsulates the updating logic for the parent form. This action is executed immediately after the modal dialog is closed, allowing the parent form to reflect any changes or updates made.</param>
        /// <remarks>
        /// This method is particularly useful for scenarios where opening a child form may result in changes that need to be reflected in the parent form (e.g., adding, editing, or deleting data). The <paramref name="updatePanel"/> action provides a flexible way to specify exactly how the parent form should respond once the child form is closed.
        /// </remarks>
        private void OpenNewFormAndUpdateParentOnClose<T>(Form form, Panel panel, Func<List<T>> getData, ListView listView, Func<T, ListViewItem> createListViewItem)
        {
            form.ShowDialog();
            ShowPanel(panel);
            GetAndDisplayDataInListView(getData, listView, createListViewItem);
        }

        /// <summary>
        /// Resets the Place Order form to its initial state.
        /// </summary>
        /// <remarks>
        /// Clears any staged purchase in the purchase service, resets the quantity text box,
        /// and refreshes the lists of students and drinks by retrieving the latest data from the services
        /// and displaying it in their respective list views.
        /// </remarks>
        private void ResetPlaceOrderForm()
        {
            purchaseService.ClearStagedPurchase();
            txtBoxPlaceOrderQuantity.Clear();
            GetAndDisplayDataInListView(studentService.GetAllStudents, listViewPlaceOrderStudents, CreatePlaceOrderStudentListViewItem);
            GetAndDisplayDataInListView(drinkService.GetAllDrinks, listViewPlaceOrderDrinks, CreatePlaceOrderDrinkListViewItem);
        }

        /// <summary>
        /// Displays a confirmation dialog box asking the user to confirm the deletion of a specified item.
        /// </summary>
        /// <typeparam name="T">The type of the item subject to deletion.</typeparam>
        /// <param name="deletionSubject">The item that is being considered for deletion. This item will be displayed in the deletion confirmation prompt.</param>
        /// <returns>
        /// A <see cref="DialogResult"/> indicating whether the user confirmed or cancelled the deletion.
        /// <see cref="DialogResult.Yes"/> if the user confirms the deletion, or <see cref="DialogResult.No"/> if the user cancels.
        /// </returns>
        /// <remarks>
        /// The message text for the confirmation dialog is retrieved using a resource string that is formatted to include
        /// the specific subject of deletion. This approach allows for localization and customization of the deletion prompt message.
        /// </remarks>
        private DialogResult ShowConfirmDeletionMessageBox<T>(T deletionSubject)
        {
            string messageText = GetResourceStringWithArgument(Properties.Resources.DeletePrompt, deletionSubject);
            DialogResult confirmResult = MessageBox.Show(messageText, Properties.Resources.ConfirmDeletion, MessageBoxButtons.YesNo);
            return confirmResult;
        }

        #endregion

        #region Events

        private void TextBoxPlaceOrderQuantity_TextChanged(object sender, EventArgs e)
        {
            ShowTotalPrice();
        }

        private void ListViewPlaceOrderDrinks_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ShowTotalPrice();
        }

        /// <summary>
        /// Handles the event triggered when the selection changes in the listViewActivitySupervisorsActivities ListView.
        /// </summary>
        /// <param name="sender">The source of the event, typically the listViewActivitySupervisorsActivities ListView.</param>
        /// <param name="e">Details about the item selection change event.</param>
        /// <remarks>
        /// When an activity is selected in the listViewActivitySupervisorsActivities ListView, this method retrieves and displays
        /// the current supervisors for the selected activity and also lists all available supervisors who can be assigned to it.
        /// This dual-display facilitates managing and assigning supervisors to activities.
        /// 
        /// In case of an exception, such as a failure to retrieve data, an error message is displayed to the user.
        /// 
        /// This method assumes that the Tag property of each ListViewItem contains an Activity object representing the associated activity.
        /// </remarks>
        private void ListViewActivitySupervisors_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if (listViewActivitySupervisorsActivities.SelectedItems.Count != zero)
                {
                    Activity currentActivity = (Activity)listViewActivitySupervisorsActivities.SelectedItems[zero].Tag;

                    GetAndDisplayDataInListView(supervisorService.GetAllSupervisorsForActivity, currentActivity, listViewSupervisors, CreateLecturerListViewItem);
                    GetAndDisplayDataInListView(supervisorService.GetAllAvailableSupervisorsForActivity, currentActivity, listViewAvailableLecturers, CreateLecturerListViewItem);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }
        }

        #endregion

        #region Data Handling

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

        /// <summary>
        /// Executes a provided function to fetch a list of data items of type <typeparamref name="T"/>, using an additional parameter of type <typeparamref name="TParam"/>.
        /// </summary>
        /// <typeparam name="T">The type of the data items in the returned list.</typeparam>
        /// <typeparam name="TParam">The type of the parameter required by the <paramref name="fetchData"/> function.</typeparam>
        /// <param name="fetchData">A function delegate that, when invoked with an argument of type <typeparamref name="TParam"/>, returns a list of items of type <typeparamref name="T"/>. This function encapsulates the actual data fetching operation and allows for more targeted data retrieval by using the provided parameter.</param>
        /// <param name="param">The parameter of type <typeparamref name="TParam"/> to be passed to the <paramref name="fetchData"/> function. This parameter can influence the scope or specifics of the data fetching operation.</param>
        /// <returns>
        /// A list containing the fetched data items of type <typeparamref name="T"/> if the operation is successful; otherwise, returns null if an exception is caught during the fetching operation.
        /// </returns>
        /// <remarks>
        /// If an exception occurs during the execution of the <paramref name="fetchData"/> function, the exception message is displayed to the user using <c>ShowMessage</c>, and null is returned. This method extends the functionality of fetching data by allowing parameters to be specified, which can tailor the data fetching operation to specific needs or contexts.
        /// </remarks>
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

        private void GetAndDisplayDataInListView<T>(Func<List<T>> getData, ListView listView, Func<T, ListViewItem> createListViewItem)
        {
            List<T> data = FetchData(getData);
            DisplayDataInListView(listView, data, createListViewItem);
        }

        private void GetAndDisplayDataInListView<T, TParam>(Func<TParam, List<T>> getData, TParam param, ListView listView, Func<T, ListViewItem> createListViewItem)
        {
            List<T> data = FetchData(getData, param);
            DisplayDataInListView(listView, data, createListViewItem);
        }

        #endregion

        #region Create ListViewItem

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

        #endregion

        #region MenuItem Click Events

        private void MenuItemDashboard_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlDashboard);
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemStudents_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlStudents);
            GetAndDisplayDataInListView(studentService.GetAllStudents, listViewStudents, CreateStudentListViewItem);
        }

        private void MenuItemManageStudents_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlManageStudents);
            GetAndDisplayDataInListView(studentService.GetAllStudents, listViewManageStudents, CreateStudentListViewItem);
        }

        private void MenuItemLecturers_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlLecturers);
            GetAndDisplayDataInListView(lecturerService.GetAllLecturers, listViewLecturers, CreateLecturerListViewItem);
        }

        private void MenuItemActivities_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlActivities);
            GetAndDisplayDataInListView(activityService.GetAllActivities, listViewActivities, CreateActivityListViewItem);
        }

        private void MenuItemActivitySupervisors_Click(object sender, EventArgs e)
        {
            listViewSupervisors.Items.Clear();
            listViewAvailableLecturers.Items.Clear();
            ShowPanel(pnlActivitySupervisors);
            GetAndDisplayDataInListView(activityService.GetAllActivities, listViewActivitySupervisorsActivities, CreateActivityListViewItem);
        }

        private void MenuItemRooms_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlRooms);
            GetAndDisplayDataInListView(roomService.GetAllRooms, listViewRooms, CreateRoomListViewItem);
        }

        private void MenuItemDrinks_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlDrinks);
            GetAndDisplayDataInListView(drinkService.GetAllDrinks, listViewDrinks, CreateDrinkListViewItem);
        }

        private void MenuItemDrinkSupplies_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlDrinkSupplies);
            GetAndDisplayDataInListView(drinkService.GetAllDrinks, listViewDrinkSupplies, CreateDrinkSuppliesListViewItem);
        }

        private void MenuItemPlaceOrder_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlPlaceOrder);
            GetAndDisplayDataInListView(studentService.GetAllStudents, listViewPlaceOrderStudents, CreatePlaceOrderStudentListViewItem);
            GetAndDisplayDataInListView(drinkService.GetAllDrinks, listViewPlaceOrderDrinks, CreatePlaceOrderDrinkListViewItem);
        }

        #endregion

        #region Button Click Events

        private void ButtonCreateStudent_Click(object sender, EventArgs e)
        {
            OpenNewFormAndUpdateParentOnClose(new EditStudentForm(), pnlManageStudents, studentService.GetAllStudents, listViewManageStudents, CreateStudentListViewItem);
        }

        private void ButtonCreateDrink_Click(object sender, EventArgs e)
        {
            OpenNewFormAndUpdateParentOnClose(new EditDrinkForm(), pnlDrinkSupplies, drinkService.GetAllDrinks, listViewDrinkSupplies, CreateDrinkSuppliesListViewItem);
        }

        /// <summary>
        /// Handles the click event on the "Delete student" button.
        /// </summary>
        /// <remarks>
        /// Prompts the user to confirm the deletion of the selected student. If confirmed, the selected student is deleted from the system.
        /// Refreshes the student list view after deletion. Displays an error message if no student is selected or if an exception occurs.
        /// </remarks>
        private void ButtonDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                Student currentStudent = GetSelectedItemFromListViewOrThrow<Student>(listViewManageStudents, Properties.Resources.ErrorMessageStudentNotSelected);

                DialogResult confirmResult = ShowConfirmDeletionMessageBox(currentStudent);
                if (confirmResult == DialogResult.Yes)
                {
                    studentService.DeleteStudent(currentStudent);
                    GetAndDisplayDataInListView(studentService.GetAllStudents, listViewManageStudents, CreateStudentListViewItem);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }
        }

        /// <summary>
        /// Handles the click event on the "Delete supervisor" button.
        /// </summary>
        /// <remarks>
        /// Prompts the user to confirm the deletion of the selected supervisor from an activity. If confirmed, the supervisor is removed
        /// from the selected activity. The list views for supervisors and available supervisors are refreshed accordingly.
        /// Displays an error message if no supervisor or activity is selected or if an exception occurs.
        /// </remarks>
        private void ButtonDeleteSupervisor_Click(object sender, EventArgs e)
        {
            try
            {
                Activity currentActivity = GetSelectedItemFromListViewOrThrow<Activity>(listViewActivitySupervisorsActivities, Properties.Resources.ErrorMessageActivityNotSelected);
                Lecturer currentSupervisor = GetSelectedItemFromListViewOrThrow<Lecturer>(listViewSupervisors, Properties.Resources.ErrorMessageSupervisorNotSelected);

                DialogResult confirmResult = ShowConfirmDeletionMessageBox(currentSupervisor);
                if (confirmResult == DialogResult.Yes)
                {
                    supervisorService.DeleteSupervisorFromActivity(currentSupervisor, currentActivity);
                    GetAndDisplayDataInListView(supervisorService.GetAllSupervisorsForActivity, currentActivity, listViewSupervisors, CreateLecturerListViewItem);
                    GetAndDisplayDataInListView(supervisorService.GetAllAvailableSupervisorsForActivity, currentActivity, listViewAvailableLecturers, CreateLecturerListViewItem);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }
        }

        /// <summary>
        /// Handles the click event on the "Delete drink" button.
        /// </summary>
        /// <remarks>
        /// Asks the user for confirmation before deleting the selected drink from the inventory. Updates the drink list view
        /// to reflect the change. An error message is shown if no drink is selected or if an error occurs during the deletion process.
        /// </remarks>
        private void ButtonDeleteDrink_Click(object sender, EventArgs e)
        {
            try
            {
                Drink currentDrink = GetSelectedItemFromListViewOrThrow<Drink>(listViewDrinkSupplies, Properties.Resources.ErrorMessageDrinkNotSelected);

                DialogResult confirmResult = ShowConfirmDeletionMessageBox(currentDrink);
                if (confirmResult == DialogResult.Yes)
                {
                    drinkService.DeleteDrink(currentDrink);
                    GetAndDisplayDataInListView(drinkService.GetAllDrinks, listViewDrinkSupplies, CreateDrinkSuppliesListViewItem);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }
        }

        /// <summary>
        /// Handles the click event on the "Edit student" button.
        /// </summary>
        /// <remarks>
        /// Opens the form to edit the details of the selected student. The student list view is updated upon successful modification.
        /// An error message is displayed if no student is selected or if an exception occurs.
        /// </remarks>
        private void ButtonEditStudent_Click(object sender, EventArgs e)
        {
            try
            {
                Student currentStudent = GetSelectedItemFromListViewOrThrow<Student>(listViewManageStudents, Properties.Resources.ErrorMessageStudentNotSelected);
                OpenNewFormAndUpdateParentOnClose(new EditStudentForm(currentStudent), pnlManageStudents, studentService.GetAllStudents, listViewManageStudents, CreateStudentListViewItem);
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }
        }

        /// <summary>
        /// Handles the click event on the "Edit drink" button.
        /// </summary>
        /// <remarks>
        /// Opens the drink editing form for the selected drink. Refreshes the drink list view to reflect any changes made.
        /// Displays an error message if no drink is selected or if an error occurs during the process.
        /// </remarks>
        private void ButtonEditDrink_Click(object sender, EventArgs e)
        {
            try
            {
                Drink currentDrink = GetSelectedItemFromListViewOrThrow<Drink>(listViewDrinkSupplies, Properties.Resources.ErrorMessageDrinkNotSelected);
                OpenNewFormAndUpdateParentOnClose(new EditDrinkForm(currentDrink), pnlDrinkSupplies, drinkService.GetAllDrinks, listViewDrinkSupplies, CreateDrinkSuppliesListViewItem);
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }
        }

        /// <summary>
        /// Handles the click event on the "Add supervisor" button.
        /// </summary>
        /// <remarks>
        /// Assigns the selected lecturer as a supervisor to the selected activity. Updates the supervisor and available supervisor
        /// list views to reflect the new assignment. Shows an error message if either the lecturer or activity is not selected,
        /// or if an exception is encountered.
        /// </remarks>
        private void ButtonAddSupervisor_Click(object sender, EventArgs e)
        {
            try
            {
                Activity currentActivity = GetSelectedItemFromListViewOrThrow<Activity>(listViewActivitySupervisorsActivities, Properties.Resources.ErrorMessageActivityNotSelected);
                Lecturer currentLecturer = GetSelectedItemFromListViewOrThrow<Lecturer>(listViewAvailableLecturers, Properties.Resources.ErrorMessageLecturerNotSelected);
                supervisorService.AddSupervisorToActivity(currentLecturer, currentActivity);
                GetAndDisplayDataInListView(supervisorService.GetAllSupervisorsForActivity, currentActivity, listViewSupervisors, CreateLecturerListViewItem);
                GetAndDisplayDataInListView(supervisorService.GetAllAvailableSupervisorsForActivity, currentActivity, listViewAvailableLecturers, CreateLecturerListViewItem);
            }
            catch (Exception ex)
            {
                ShowMessage(Properties.Resources.ErrorMessage, ex.Message);
            }
        }

        /// <summary>
        /// Handles the click event on the "Add purchase" button.
        /// </summary>
        /// <remarks>
        /// Finalizes the purchase based on the user's input from the Place Order form. Updates the stock for the purchased drink and
        /// creates a new purchase record. Resets the Place Order form upon completion. Specific error messages are displayed for invalid
        /// quantity inputs or other exceptions during the process.
        /// </remarks>
        private void ButtonAddPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                StagePurchaseFromPlaceOrderForm();
                ValidatePurchaseOrThrow();
                drinkService.UpdateStock(purchaseService.StagedPurchase.Drink, purchaseService.StagedPurchase.Quantity);
                drinkService.UpdateDrink(purchaseService.StagedPurchase.Drink);
                purchaseService.CreatePurchase(purchaseService.StagedPurchase);
                ResetPlaceOrderForm();
            }
            catch (Exception ex)
            {
                string errorMessage = ex is FormatException ? Properties.Resources.ErrorMessageWrongQuantityFormat : ex.Message;
                ShowMessage(Properties.Resources.ErrorMessage, errorMessage);
            }
        }

        #endregion
    }
}