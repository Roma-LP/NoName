using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static bool flag; // для ввода флаг
        static string buf; // буфер для ввода

        static void Main(string[] args)
        {
            string choice;  // для выбора меню глобально

            CollectionTR CTR = new CollectionTR();
            do
            {
                Console.Clear();
                Menu();
                Console.WriteLine("Ввод: ");
                choice = Console.ReadLine();
                if (!CheckNumer(choice))
                {
                    Console.WriteLine("Ошибка ввода, попробуйте ещё");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    choice = "999";
                    continue;
                }

                switch (Convert.ToInt32(choice))
                {
                    case 1:
                        {
                            CTR.Add(new TRAIN(WriteDest(), WriteTrainNumber(), WriteTime()));
                            break;
                        }
                    case 2:
                        {
                            CTR.PrintAll();
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            CTR.Save(); // TaskC#\TestConsole\TestConsole\bin\Debug
                            break;
                        }
                    case 4:
                        {
                            CTR.Load(); // TaskC#\TestConsole\TestConsole\bin\Debug
                            break;
                        }
                    case 6:
                        {
                            CTR.Claer();
                            break;
                        }
                    case 7:
                        {
                            CTR.SortTrNumber();
                            break;
                        }
                    case 8:
                        {
                            CTR.SortTime();
                            break;
                        }
                    case 9:
                        {
                            CTR.FindDestination();
                            Console.ReadKey();
                            break;
                        }
                    case 10:
                        {
                            CTR.FindTrainNumber();
                            Console.ReadKey();
                            break;
                        }
                    case 11:
                        {
                            CTR.FindTime();
                            Console.ReadKey();
                            break;
                        }
                    default:
                        break;
                }

            } while (Convert.ToInt32(choice) != 0);
        }

        static void Menu()
        {
            Console.WriteLine(" 1 - добавление элемента Train в коллекцию ");
            Console.WriteLine(" 2 - вывод коллекции ");
            Console.WriteLine(" 3 - сохранить коллекцию ");
            Console.WriteLine(" 4 - загрузить коллекцию ");
            Console.WriteLine(" 6 - очистить коллекцию ");
            Console.WriteLine(" 7 - отсортировать по номеру поезда коллекцию ");
            Console.WriteLine(" 8 - отсортировать по времени коллекцию ");
            Console.WriteLine(" 9 - поиск по пункту назначения ");
            Console.WriteLine(" 10 - поиск по номеру поезда ");
            Console.WriteLine(" 11 - поиск по времени ");
            Console.WriteLine(" 0 - вывход");

        }

        public static bool CheckNumer(string str)     // проверка на ввод чисел
        {
            if (str.Length == 0) return false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static string WriteDest()
        {
            Console.WriteLine("Пункта назначения: ");
            return Console.ReadLine();
        }

        public static int WriteTrainNumber()
        {

            do
            {
                flag = false;
                Console.WriteLine("Номер поезда: ");
                buf = Console.ReadLine();

                if (!CheckNumer(buf))
                {
                    Console.WriteLine("Ошибка ввода, только целые числа. Попробуйте ещё");
                    System.Threading.Thread.Sleep(1000);
                    flag = true;
                    continue;
                }
            } while (flag);
            return Convert.ToInt32(buf);
        }

        public static string WriteTime()
        {
            string[] Stime = { "", "" };
            do
            {
                flag = false;
                Console.WriteLine("Время отправления: ");
                buf = Console.ReadLine();
                if (!buf.Contains(":"))
                {
                    Console.WriteLine("Ошибка ввода, отсутствует разделитель \":\". Попробуйте ещё");
                    System.Threading.Thread.Sleep(1000);
                    flag = true;
                    continue;
                }
                Stime = buf.Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries); // StringSplitOptions.RemoveEmptyEntries говорит, что надо удалить все пустые подстроки
                if (!CheckNumer(Stime[0]))
                {
                    Console.WriteLine("Ошибка ввода часа. Попробуйте ещё");
                    System.Threading.Thread.Sleep(1000);
                    flag = true;
                    continue;
                }
                else
                {
                    if (Convert.ToInt32(Stime[0]) < 0 || Convert.ToInt32(Stime[0]) >= 24)
                    {
                        Console.WriteLine("Ошибка ввода часа 0-23. Попробуйте ещё");
                        System.Threading.Thread.Sleep(1000);
                        flag = true;
                        continue;
                    }
                }
                if (Stime[0].Length == 1) // если без нуля был ввод
                {
                    Stime[0] = "0" + Stime[0];
                }
                if (!CheckNumer(Stime[1]))
                {
                    Console.WriteLine("Ошибка ввода минут. Попробуйте ещё");
                    System.Threading.Thread.Sleep(1000);
                    flag = true;
                    continue;
                }
                else
                {
                    if (Convert.ToInt32(Stime[1]) < 0 || Convert.ToInt32(Stime[1]) >= 60)
                    {
                        Console.WriteLine("Ошибка ввода минут 0-60. Попробуйте ещё");
                        System.Threading.Thread.Sleep(1000);
                        flag = true;
                        continue;
                    }
                }
                if (Stime[1].Length == 1) // если без нуля был ввод
                {
                    Stime[1] = "0" + Stime[1];
                }
            } while (flag);
            return Stime[0] + ":" + Stime[1];
        }
    }
}
