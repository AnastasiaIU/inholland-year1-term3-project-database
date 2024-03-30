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
        protected int zero = int.Parse(Properties.Resources.Zero);

        protected void ShowMessage(string message, string arg = null)
        {
            MessageBox.Show(message + arg);
        }

        protected string GetResourceStringWithArgument<T>(string resourceString, T arg)
        {
            return string.Format(resourceString, arg);
        }

        protected string ValidateStringOrThrow(string str, string errorMessage)
        {
            if (str.IsNullOrEmpty())
                throw new Exception(errorMessage);
            return str;
        }

        protected int ParseIntOrThrow(string number, string errorMesage)
        {
            if (!int.TryParse(number, out int result))
                throw new Exception(errorMesage);
            return result;
        }

        protected double ParsePriceOrThrow(string price)
        {
            return double.Parse(price.Replace(',', '.'), CultureInfo.InvariantCulture);
        }
    }
}
