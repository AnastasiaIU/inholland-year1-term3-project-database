using Microsoft.IdentityModel.Tokens;
using SomerenService;
using System;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class BaseForm : Form
    {
        protected DrinkService drinkService = new DrinkService();
        protected RoomService roomService = new RoomService();
        protected StudentService studentService = new StudentService();
        protected int zero = int.Parse(Properties.Resources.Zero);

        protected void ShowMessage(string message, string arg = null)
        {
            MessageBox.Show(message + arg);
        }

        protected string ValidateStringOrThrow(string str, string errorMessage)
        {
            if (str.IsNullOrEmpty())
                throw new Exception(errorMessage);
            return str;
        }
    }
}
