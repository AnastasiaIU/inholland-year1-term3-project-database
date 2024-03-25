using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class BaseForm : Form
    {
        protected ActivityService activityService = new ActivityService();
        protected DrinkService drinkService = new DrinkService();
        protected LecturerService lecturerService = new LecturerService();
        protected PurchaseService purchaseService = new PurchaseService();
        protected RoomService roomService = new RoomService();
        protected StudentService studentService = new StudentService();

        protected List<Activity> GetActivities()
        {
            return activityService.GetActivities();
        }

        protected List<Drink> GetDrinks()
        {
            return drinkService.GetDrinks();
        }

        protected List<Lecturer> GetLecturers()
        {
            return lecturerService.GetLecturers();
        }

        protected List<Purchase> GetPurchases()
        {
            return purchaseService.GetPurchases();
        }

        protected List<Room> GetRooms()
        {
            return roomService.GetRooms();
        }

        protected List<Student> GetStudents()
        {
            return studentService.GetStudents();
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
        protected List<T> FetchData<T>(Func<List<T>> fetchData)
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
        /// Opens a new form dialog and executes an action to update the parent form upon the new form's closure.
        /// </summary>
        /// <param name="form">The form to be displayed as a modal dialog. This form is expected to perform some operation that requires the parent form to update once the dialog is closed.</param>
        /// <param name="updatePanel">An action delegate that encapsulates the updating logic for the parent form. This action is executed immediately after the modal dialog is closed, allowing the parent form to reflect any changes or updates made.</param>
        /// <remarks>
        /// This method is particularly useful for scenarios where opening a child form may result in changes that need to be reflected in the parent form (e.g., adding, editing, or deleting data). The <paramref name="updatePanel"/> action provides a flexible way to specify exactly how the parent form should respond once the child form is closed.
        /// </remarks>
        protected void OpenNewFormAndUpdateParentOnClose(Form form, Action updatePanel)
        {
            form.ShowDialog();
            updatePanel();
        }

        protected void ShowMessage(string message, string arg = null)
        {
            MessageBox.Show(message + arg);
        }

        protected void ShowMessageAndCloseForm(string message, Form form, string arg = null)
        {
            ShowMessage(message, arg);
            form.Close();
        }

        /// <summary>
        /// Converts a string representation of a number to its double-precision floating-point number equivalent.
        /// </summary>
        /// <param name="number">A string representing a number to convert. The method supports both dot (.) and comma (,) as decimal separators.</param>
        /// <returns>The double-precision floating-point number equivalent of the input string.</returns>
        /// <exception cref="System.FormatException">Thrown when the input string is not in a valid format.</exception>
        /// <exception cref="System.OverflowException">Thrown when the input string represents a number less than <see cref="System.Double.MinValue"/> or greater than <see cref="System.Double.MaxValue"/>.</exception>
        /// <remarks>
        /// This method uses <see cref="CultureInfo.InvariantCulture"/> to ensure consistent parsing of the number regardless of the current culture settings of the system. It is designed to handle input strings that may come from environments with different conventions for the decimal separator.
        /// </remarks>
        protected double GetDoubleFromString(string number)
        {
            return double.Parse(number.Replace(',', '.'), CultureInfo.InvariantCulture);
        }
    }
}
