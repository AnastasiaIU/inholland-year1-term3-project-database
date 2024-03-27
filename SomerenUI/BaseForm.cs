using SomerenService;
using System.Globalization;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class BaseForm : Form
    {
        protected DrinkService drinkService = new DrinkService();

        protected void ShowMessage(string message, string arg = null)
        {
            MessageBox.Show(message + arg);
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
