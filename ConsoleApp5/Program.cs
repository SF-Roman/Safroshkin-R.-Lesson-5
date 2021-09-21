using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Task_1
{
    class Program
    {
        /// <summary>
        /// Проверка без регулярного выражения
        /// </summary>
        /// <param name="login"></param>
        //static bool CheckLogin_noReg(string login)
        //{
            
        //    if (login.Length >= 2 && login.Length <= 10 && char.GetNumericValue(login[0]) == -1)
        //    {
        //        foreach (char let in login)
        //        {
        //            if (char.IsLetterOrDigit(let) == false)
        //            {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }
        //    return false;
        //}

        ///Проверка с регулярным выражением
        static void CheckLogin_Reg(string login)
        {
            Regex LoginMask = new Regex("^[a-zA-Z]{1}[a-zA-Z0-9]{1,9}$");

            if (LoginMask.IsMatch(login) is true)
            {
                 Console.WriteLine($"{login} - Подходящее значение для логина");
            }
            else
            {
                Console.WriteLine($"{login} -Некорректное значение для логина");
            }
        }
       
        static void Main(string[] args)
        {
          
            Console.Write("Введите логин: ");
            string _login = Console.ReadLine();
            CheckLogin_Reg(_login);


            Console.ReadKey();
        }
    }
}
