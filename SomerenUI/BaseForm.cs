using Microsoft.IdentityModel.Tokens;
using SomerenService;
using System;
using System.Globalization;
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

        protected string ValidateString(string str, string errorMessage)
        {
            if (str.IsNullOrEmpty())
                throw new Exception(errorMessage);
            return str;
        }

        protected int ValidateInt(string number, string errorMesage)
        {
            if (!int.TryParse(number, out int tryGetInt))
                throw new Exception(errorMesage);
            return tryGetInt;
        }

        protected double ValidatePrice(string price)
        {
            return double.Parse(price.Replace(',', '.'), CultureInfo.InvariantCulture);
        }
    }
}
