using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание__1
{
    static class ExceptionHandling
    {
        /// <summary>
        /// Следит за значением n, которое не может быть меньше 1
        /// </summary>
        /// <returns></returns>
        public static int ZeroCheck()
        {
            int N = Input();
            while (true)
            {
                if (N > 0)
                    return N;
                Console.WriteLine(" Подразумевалось положительное число, повторите попытку");
                N = Input();
            }
        }
        /// <summary>
        /// Получает и возвращает проверенные входные данные типа int для проверки корректности ввода
        /// </summary>
        /// <returns></returns>
        public static int Input()
        {
            while (true)
            {
                string input_data = Console.ReadLine();
                if (CheckForTheNumber(input_data))
                    return Convert.ToInt32(input_data);
            }
        }
        /// <summary>
        /// Проверяет корректность введеных данных типа int
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool CheckForTheNumber(string number)
        {
            try
            {
                int check = Convert.ToInt32(number);
                return true;
            }
            catch
            {
                Console.WriteLine(" Введено не число, попробуйте снова");
                return false;
            }
        }
    }
}
