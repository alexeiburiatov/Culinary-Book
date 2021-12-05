using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Culinary_Book.Reg
{
    public class RegExpr
    {

        private static string emailPattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                        @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
        private static string passwordPattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$";
        private static string loginPattern= @"^[a-z]{8,}$";
        private static string flNamePattern = @"^[А-Я][а-яієїґ\']{3,20}$";
        public RegExpr(){}

        public string checkEmail(string email)
        {
            if (!Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase))
            {
                return "Некоректно введений email. Перевірте коректність";
            }
            else
            {
                return "OK";
            }
        }
        public string checkPassword(string password)
        {
            if (!Regex.IsMatch(password, passwordPattern))
            {
                return "Некоректно введений пароль. Повинен містити мінімум 8 символів, 1 великий символ та 1 цифру. Перевірте коректність";
            }
            else
            {
                return "OK";
            }
        }
        public string doubleCheckPassword(string password1, string password2)
        {
            if (password1!=password2)
            {
                return "Паролі не збігаються. Перевірте коректність";
            }
            else
            {
                return "OK";
            }
        }
        public string checkLogin(string login)
        {
            if (!Regex.IsMatch(login, loginPattern, RegexOptions.IgnoreCase))
            {
                return "Некоректно введений логін. Лише латиниця, мінімум 8 символів. Перевірте коректність";
            }
            else
            {
                return "OK";
            }
        }

        public string checkFName(string fName)
        {
            if (!Regex.IsMatch(fName, flNamePattern, RegexOptions.IgnoreCase))
            {
                return "Некоректно введено ім’я. Лише українські символи, від 3 символів. Перевірте коректність";
            }
            else
            {
                return "OK";
            }
        }


        public string checkLName(string lName)
        {
            if (!Regex.IsMatch(lName, flNamePattern, RegexOptions.IgnoreCase))
            {
                return "Некоректно введено прізвище. Лише українські символи, від 3 символів. Перевірте коректність";
            }
            else
            {
                return "OK";
            }
        }


    }
}
