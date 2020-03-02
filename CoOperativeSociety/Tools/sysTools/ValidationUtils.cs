using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CoOperativeSociety
{
   public static class ValidationUtils
    {

        public static bool EmailValidation(this string email)
        {
            Regex expr = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (expr.IsMatch(email))
            {
                return true;
            }
            else return false;
        }

        public static bool PhoneValidation(this string no)
        {
            Regex expr = new Regex(@"^[6-9]\d{9}$");
            if (expr.IsMatch(no))
            {
                return true;
            }
            else return false;
        }

        public static bool FlotingNumberValidation(this string no)
        {
            Regex expr = new Regex(@"^[0-9]*\.?[0-9]+$");
            if (expr.IsMatch(no))
            {
                return true;
            }
            else return false;
        }

        public static bool NumberValidation(this string no)
        {
            Regex expr = new Regex(@"^[0-9]+$");
            if (expr.IsMatch(no))
            {
                return true;
            }
            else return false;
        }

        public static void FlotingNumberValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public static void NumberValidation(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
