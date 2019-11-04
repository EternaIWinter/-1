using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание__1
{
    class RandomNumber
    {
        int randomNumber;

        public RandomNumber()
        {
            var random = new Random();
            Console.WriteLine(" Введите число n");
            int n = ExceptionHandling.ZeroCheck();
            randomNumber = random.Next(1, n + 1);
            Console.WriteLine(" Число от 1 до {0} загадано\n", n);
        }
        /// <summary>
        /// Проверяет равенство загаданного числа и попытки игрока
        /// </summary>
        /// <param name="attempt"></param>
        /// <returns></returns>
        public bool EqualityCheck(int attempt)
        {
            if (attempt == randomNumber)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Сравнивает числа, если они не равны
        /// </summary>
        /// <param name="attempt"></param>
        /// <returns></returns>
        public bool CompareNumbers(int attempt)
        {
            if (randomNumber > attempt)
                return true;
            else
                return false;
        }
    }
}
