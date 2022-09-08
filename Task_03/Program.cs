using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: Создать класс Article, 
             * содержащий следующие закрытые поля:
             * • название товара;
             * • стоимость товара в гривнах. Создать класс Store, содержащий закрытый массив элементов типа Article. 
             * Обеспечить следующие возможности:
             * • вывод информации о товаре по номеру с помощью индекса;
             * • вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, 
             * выдать соответствующее сообщение; 
             * Написать программу, вывода на экран информацию о товаре. 
             * • название магазина, в котором продается товар;
             */

            Store store = new Store(3);

            store.Add(new Article("Ipad 5",      "Rozetka", 25000), 0);
            store.Add(new Article("Asus Zenbook","Rozetka", 35000), 1);
            store.Add(new Article("Mouse ATech", "Rozetka", 699),   2);

            Console.WriteLine(store["Ipad 5"]); 
            Console.WriteLine(store[2]);

            Console.WriteLine("");
            store.Show();

            Console.ReadKey();
        }
    }
}
