using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
//sing System.Text.Json;
//using Newtonsoft.Json;
using System.Xml.Serialization;

namespace TestConsole
{
    [Serializable]
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
            Collect = Collect.OrderBy(x => x.Destination).ToList();
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

        public void SortTrNumber()  // сортировка по номеру поезда  
        {
            Collect = Collect.OrderBy(x => x.TrNumber).ToList();
        }

        public void SortTime()  // сортировка по времени
        {
            Collect = Collect.OrderBy(x => x.StartTime).ToList();
        }
        
        public void Save()  // сохранить
        {
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(List<TRAIN>));
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("TrainCollection.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Collect);
                Console.WriteLine("Объект сериализован");
            }
        }

        public void Load()  // загрузить
        {
            // десериализация
            using (FileStream fs = new FileStream("TrainCollection.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<TRAIN>));
                Collect = (List<TRAIN>)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
            }
        }

    }
}
