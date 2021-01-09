using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class CollectionTR
    {
        List<TRAIN> Collect = new List<TRAIN>();

        public CollectionTR()
        {
        }
        public CollectionTR(params TRAIN[] org)
        {
            for (int i = 0; i < org.Length; i++)
            {
                Collect.Add(org[i]);
            }
        }

        public void Add(TRAIN org)
        {
            Collect.Add(org);
            var sortedList = Collect.OrderBy(x => x).ToList();
        }
        public void Add(TRAIN[] org)
        {
            for (int i = 0; i < org.Length; i++)
            {
                Collect.Add(org[i]);
            }
        }
        public void RemoveLast()    // удаляет последний элемент коллекции
        {
            Collect.RemoveAt(Collect.Count);
        }
        public void Claer()     // очищает коллекцию
        {
            Collect.Clear();
        }
        public void PrintAll()  // вывод коллекции через метод ToString()
        {
            foreach (TRAIN i in Collect)
                Console.WriteLine(i);
        }
        public void PrintAt(int i)  // вывод по индексу
        {
            if (i <= Collect.Count && i > 0)
                Console.WriteLine(Collect[i - 1]);
            else
                Console.WriteLine("Выход за пределы коллекции");
        }

    }
}
