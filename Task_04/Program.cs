using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Расширьте пример 5 (русско-английский словарь) еще и украинским словарем. 
             * Реализуйте возможность поиска не только по ключевым русским словам и словам на остальных языках.
             */

            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["говорить"]); 
            Console.WriteLine(dictionary["читать"]);
            Console.WriteLine(dictionary["писать"]);
            Console.WriteLine(dictionary["ходить"]);

            Console.WriteLine();

            Console.WriteLine(dictionary["говорити"]); 
            Console.WriteLine(dictionary["читати"]);
            Console.WriteLine(dictionary["писати"]);
            Console.WriteLine(dictionary["ходити"]);

            Console.WriteLine();

            Console.WriteLine(dictionary["speak"]); 
            Console.WriteLine(dictionary["read"]);
            Console.WriteLine(dictionary["write"]);
            Console.WriteLine(dictionary["walk"]);

            Console.WriteLine();

            Console.WriteLine(dictionary[0]);
            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary[2]);
            Console.WriteLine(dictionary[3]);
            Console.WriteLine(dictionary[4]);

            Console.WriteLine();
            
            Console.WriteLine(dictionary["кенгуру"]);


            Console.ReadKey();
        }
    }
}
