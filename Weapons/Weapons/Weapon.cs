using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    abstract class Weapon
    {
        private int cost;
        private string type;

        abstract public void Info();


        public int Cost
        {
            get
            {
                return cost;
            }
            protected set
            {
                if (value < 0)
                {
                    Console.WriteLine("Цена не может быть меньше нуля!");
                }
                else
                {
                    cost = value;
                }
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            protected set
            {
                type = value;
            }
        }
    }

    class Pistol : Weapon
    {
        private int damage;
        private static int price;

        public int Damage
        {
            get
            {
                return damage;
            }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Урон не может быть отрицательным!");
                }
                else
                {
                    damage = value;
                }
            }
        }

        public Pistol(string type, int cost, int dmg)
        {
            Type = type;
            Cost = cost;
            Damage = dmg;
            price += cost;
        }
        public override void Info()
        {
            Console.WriteLine($"Цена: {Cost}\t\tТип: {Type}\t\tТип: {Damage}");

        }
        public static void Price() // стоимость всех созданных оружий
        {
            Console.WriteLine($"Цена всех пистолетов: {price}");

        }


    }

    class Knife : Weapon
    {
        public enum enColor
        {
            White = 1,
            Red,
            Green,
            Blue,
            Orange
        }
        private enColor color =(enColor)4;  // значение по умолчанию 
        private static int price;

        public enColor Color
        {
            get
            {
                return color;
            }
            private set
            {
                if (Enum.IsDefined(typeof(enColor),value))
                {
                    color = value;
                }
                else
                {
                    Console.WriteLine($"Цвета под номером {value} нет");
                }
            }
        }

        public Knife(string type, int cost, enColor cl)
        {
            Type = type;
            Cost = cost;
            Color = cl;
            price += cost;
        }

        public override void Info()
        {
            Console.WriteLine($"Цена: {Cost}\t\tТип: {Type}\t\tЦвет: {Color}");

        }
        public static void Price() // стоимость всех созданных оружий
        {
            Console.WriteLine($"Цена всех ножей: {price}");

        }
    }
}
