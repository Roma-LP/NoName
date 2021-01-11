using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    static class Program
    {
        static bool flag; // для ввода флаг
        static string buf; // буфер для ввода

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            

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
