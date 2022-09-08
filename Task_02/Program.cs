using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Требуется: Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера 
             * с возможностью изменения числа строк и столбцов. 
             * Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков. 
             */

            MyMatrix myMatrix = new MyMatrix(4, 4);
            myMatrix.Show();

            Console.WriteLine("");

            myMatrix.Change(7, 12);
            myMatrix.Show();

            Console.WriteLine("");

            myMatrix.Change(2, 2);
            myMatrix.Show();

            Console.ReadKey();
        }
    }
}
