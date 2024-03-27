using SomerenService;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class BaseForm : Form
    {
        protected DrinkService drinkService = new DrinkService();
        protected RoomService roomService = new RoomService();
        protected StudentService studentService = new StudentService();

        protected void ShowMessage(string message, string arg = null)
        {
            MessageBox.Show(message + arg);
        }

        protected string GetResourceStringWithArgument(string resourceString, string arg)
        {
            return string.Format(resourceString, arg);
        }
    }
}
