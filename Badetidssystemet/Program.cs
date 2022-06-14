using System;

namespace Badetidssystemet
{
    class Program
    {
        static void Main(string[] args)
        {
            //opgave 1//
            Console.WriteLine("Opgave - 1");
            Console.WriteLine();

            Kreds opgave1 = new Kreds() { ID = "1", Navn = "FDF", Adresse = "Her", AntalDeltagere = 20 };

            Console.WriteLine(opgave1);
            Console.WriteLine();

            //opgave 2//

            Console.WriteLine("Opgave - 2");

            BadetidsPeriode opgave2 = new BadetidsPeriode() { Type = "Børn", UgeDag = DayOfWeek.Friday, StartTidspunkt = new DateTime(2022, 6, 14, 18, 0, 0), SlutTidspunkt = new DateTime(2022, 6, 14, 20, 0, 0) };

            Console.WriteLine(opgave2);

            //opgave 4//

            Console.WriteLine("Opgave - 4");

            BadetidsPeriode opgave4 = new BadetidsPeriode() { Type = "Voksne", UgeDag = DayOfWeek.Friday, StartTidspunkt = new DateTime(2022, 6, 14, 20, 0, 0), SlutTidspunkt = new DateTime(2022, 6, 14, 22, 0, 0) };

            Console.WriteLine(opgave4);

            opgave2.SletKreds("1");
            opgave4.SletKreds("3");

            Console.WriteLine(opgave2);
            Console.WriteLine(opgave4);

            opgave2.AdderKreds(new Kreds() { ID = "1", Navn = "OP2.0", Adresse = "Her", AntalDeltagere = 21 });
            opgave4.AdderKreds(new Kreds() { ID = "3", Navn = "OP2.2", Adresse = "Her", AntalDeltagere = 18 });

            Console.WriteLine(opgave2);
            Console.WriteLine(opgave4);

            //opgave 6

            Console.ReadKey();
        }
    }
}
