using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Требуется: Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.
             * Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов, 
             * среднее арифметическое всех элементов, вывести все нечетные значения. 
            */

            Console.Write("Укажите размер массива: ");
            int.TryParse(Console.ReadLine(), out int size);
            int[] array = new int[size];

            Console.Write("Исходный массив: ");
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-1000, 1000);
                Console.Write(array[i] + " ");
            }

            int maxValue = 0, minValuer = 0, sum = 0;
            double average;
            string allOddValues = "";
            for (int i = 0; i < size; i++)
            {
                maxValue = Math.Max(array[i], maxValue);
                minValuer = Math.Min(array[i], minValuer);
                sum += array[i];
                if (array[i] % 2 == 1)
                {
                    allOddValues += array[i] + " ";
                }
            }

            average = sum / size;

            Console.WriteLine($"Максимальное число {maxValue}");
            Console.WriteLine($"Минимальное число {minValuer}");
            Console.WriteLine($"Общая сумма элементов {sum}");
            Console.WriteLine($"Среднее арифметическое значение: {average}");
            Console.WriteLine($"Все нечетные значения: {allOddValues}");

            Console.ReadKey();
        }
    }
}
