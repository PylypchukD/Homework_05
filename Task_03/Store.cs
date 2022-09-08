using System;

namespace Task_03
{
    internal class Store
    {
        private readonly Article[] articles;

        public Store(int size)
        {
            articles = new Article[size];
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 && index > articles.Length)
                {
                    return "Индекс находиться за пределом массива";
                }
                return articles[index].Info();
            }
        }

        public void Add(Article value, int index)
        {
            if (index >= 0 && index < articles.Length)
            {
                articles[index] = value;
            }
            else
            {
                Console.WriteLine("Попытка записи за пределами массива.");
            }
        }

        public string this[string index] //Перегрузка индексатора
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].Name == index)
                    {
                        return articles[i].Info();
                    }
                }
                return $"Товара {index} нет в наличии.";
            }
        }

        public void Show()
        {
            for (int i = 0; i < articles.Length; i++)
            {
                Console.WriteLine(articles[i].Info());
            }
        }
    }
}
