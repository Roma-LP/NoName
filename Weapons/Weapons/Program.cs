using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    class Program
    {
        static void Main(string[] args)
        {
            Pistol ps1 = new Pistol("Glock",200,105);
            Pistol ps2 = new Pistol("Deagle",940,200);
            ps1.Info();
            ps2.Info();
            Pistol.Price();

            Console.WriteLine();

            Knife kn1 = new Knife("Steel", 640, Knife.enColor.Orange);
            Knife kn2 = new Knife("Paper", 98, Knife.enColor.Blue);
            Knife kn3 = new Knife("Wood", 125, (Knife.enColor)78);
            kn1.Info();
            kn2.Info();
            kn3.Info();
            Knife.Price();
            

        }
    }
}
