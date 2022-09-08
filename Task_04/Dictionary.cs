using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Dictionary
    {
        private readonly string[] RU = new string[4];
        private readonly string[] UK = new string[4];
        private readonly string[] UA = new string[4];

        public Dictionary()
        {
            RU[0] = "говорить";     
            RU[1] = "читать";       
            RU[2] = "писать";       
            RU[3] = "ходить";       

            UK[0] = "speak";
            UK[1] = "read";
            UK[2] = "write";
            UK[3] = "walk";

            UA[0] = "говорити";
            UA[1] = "читати";
            UA[2] = "писати";
            UA[3] = "ходити";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < RU.Length; i++)
                {
                    if (RU[i] == index)
                        return $"{RU[i]} - {UA[i]} - {UK[i]}";
                    if (UA[i] == index)
                        return $"{UA[i]} - {RU[i]} - {UK[i]}";
                    if (UK[i] == index)
                        return $"{UK[i]} - {RU[i]} - {UA[i]}";
                }

                return $"слово {index} - не найдено в словаре.";
            }
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 || index > RU.Length-1)
                {
                    return "Попытка обращения за пределы массива.";
                }
                return RU[index] + " - " + UA[index] + " - " + UK[index];
            }
        }
    }
}
