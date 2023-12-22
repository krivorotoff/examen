using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace экзамен
{
    internal class Class1
    {
        static void Main()
        {
            int[] numbers = new int[50];
            Random random = new();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 31);
            }

            Console.Write("введите желаемое число: ");
            int userNumb = Convert.ToInt32(Console.ReadLine());

            bool haveNumb = false;
            foreach (int number in numbers)
            {
                if (number == userNumb)
                {
                    haveNumb = true;
                    break;
                }
            }

            if (haveNumb)
            {
                Console.WriteLine($"число {userNumb} есть в массиве");
            }
            else
            {
                Console.WriteLine($"числа {userNumb} в массиве нет.");
            }
        }
    }
}
