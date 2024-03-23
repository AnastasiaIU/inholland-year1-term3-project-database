using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SomerenUI
{
    public abstract partial class BaseForm : Form
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

        protected List<T> FetchData<T>(Func<List<T>> fetchData)
        {
            List<T> data = null;

            try
            {
                data = fetchData();
            }
            catch (Exception ex)
            {
                ShowError(Properties.Resources.ErrorMessage, ex);
            }

            return data;
        }

        protected void OpenNewFormAndUpdateParentOnClose(Form form, Action updatePanel)
        {
            form.ShowDialog();
            updatePanel();
        }

        protected void ShowError(string errorMessage, Exception ex)
        {
            MessageBox.Show(errorMessage + ex.Message);
        }

        protected void ShowMessage(string message, string arg = null)
        {
            MessageBox.Show(message + arg);
        }
    }
}
