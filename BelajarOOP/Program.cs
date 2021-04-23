using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Pertambahan a1 = new Pertambahan(1, 2);
            Console.Write("Pertambahan dari " +a1.A+ " dengan " +a1.B+ " = ");
            Console.WriteLine(a1.Proccess());
            a1.Display();

            Pengurangan a2 = new Pengurangan(4, 2);
            Console.Write("Pengurangan dari " + a2.A + " dengan " + a2.B + " = ");
            Console.WriteLine(a2.Proccess());
            a2.Display();

            Perkalian a3 = new Perkalian(3, 4);
            Console.Write("Perkalian dari " + a3.A + " dengan " + a3.B + " = ");
            Console.WriteLine(a3.Proccess());
            a3.Display();

            Pembagian a4 = new Pembagian(5, 2);
            Console.Write("Pembagian dari " + a4.A + " dengan " + a4.B + " = ");
            Console.WriteLine(a4.Proccess());
            a4.Display();
           

            Console.Read();

        }
    }
}
