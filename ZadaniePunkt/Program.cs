using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniePunkt
{
    class Program
    {
        static void Main(string[] args)
        {

            string x1;
            int x2;

            string y1;
            int y2;

            /*Punkt punkt1 = new Punkt(1, 1);
            Punkt punkt2 = new Punkt(2, 2);
            Punkt punkt3 = punkt1 + punkt2;

            punkt3.Wyswietl();
            Punkt punkt4 = punkt1 - punkt2;
            punkt4.Wyswietl();
            Punkt punkt5 = punkt1 * 2;
            punkt5.Wyswietl();
            Punkt punkt6 = 2*punkt1;
            punkt6.Wyswietl();*/

            for (int i = 0; i < 11; i++)
            {
                Punkt punkt = new Punkt(i, i);
            }
            Console.WriteLine(Punkt.Licznik);

            Console.ReadLine();
            
            /*Punkt XY = new Punkt(5,5); // 2) Współrzędne punktu są ustalane na etapie tworzenia obiektu (konstruktor)

            XY.Wyswietl();

            Console.WriteLine("Jarek");

            Console.WriteLine("Przesuń w prawo o:");
            x1 = Console.ReadLine();
            x2 = System.Int32.Parse(x1);
            XY.Prawo(x2);

            Console.WriteLine("Przesuń w lewo o:");
            x1 = Console.ReadLine();
            x2 = System.Int32.Parse(x1);
            XY.Lewo(x2);

            Console.WriteLine("Przesuń w górę o:");
            y1 = Console.ReadLine();
            y2 = System.Int32.Parse(y1);
            XY.Gora(y2);

            Console.WriteLine("Przesuń w dół o:");
            y1 = Console.ReadLine();
            y2 = System.Int32.Parse(y1);
            XY.Dol(y2);


            XY.Wyswietl();


            Console.ReadLine();*/


        }
    }
}
