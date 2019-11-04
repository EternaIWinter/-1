using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание__1
{

    class Program
    {
        /// <summary>
        /// Обработка ситуаций по ходу игры
        /// </summary>
        /// <returns></returns>
        static bool Play()
        {
            RandomNumber game = new RandomNumber();
            Console.WriteLine(" Введите число попыток k:\n");
            int k = ExceptionHandling.Input();
            while (k != 0)
            {
                Console.WriteLine("\tОсталось попыток {0}\n", k);
                Console.WriteLine(" Введите число:");
                int attempt = ExceptionHandling.Input();
                if (game.EqualityCheck(attempt))
                    return true;
                k--;
                if (game.CompareNumbers(attempt))
                    Console.WriteLine(" Загаданное число больше\n");
                else
                    Console.WriteLine(" Загаданное число меньше\n");
            }
            return false;
        }

        static void Main(string[] args)
        {
            if (Play())
                Console.WriteLine(" Вы угадали!\n");
            else
                Console.WriteLine(" Попытки закончились\n");
            // Обработка результата игры
            Console.WriteLine(" Для завершения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
