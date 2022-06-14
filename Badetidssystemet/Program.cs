using System;

namespace Badetidssystemet
{
    class Program
    {
        static void Main(string[] args)
        {
            //opgave 1//
            Console.WriteLine("Opgave - 1");            

            try
            {
                Console.WriteLine();
                Kreds opgave1 = new Kreds() { ID = "1", Navn = "FDF", Adresse = "Her", AntalDeltagere = 20, MaxAlder = 99, MinAlder = 18 };
                Console.WriteLine(opgave1);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
            }                        

            //opgave 2//

            Console.WriteLine("Opgave - 2");

            try
            {
                BadetidsPeriode opgave2 = new BadetidsPeriode() { Type = "Børn", UgeDag = DayOfWeek.Friday, SlutTidspunkt = new DateTime(2022, 6, 14, 20, 0, 0), StartTidspunkt = new DateTime(2022, 6, 14, 18, 0, 0), MaxAlder = 99, MinAlder = 18 };
                Console.WriteLine(opgave2);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
            }

            //opgave 4//

            Console.WriteLine("Opgave - 4");

            try
            {
                BadetidsPeriode opgave40 = new BadetidsPeriode() { Type = "Voksne", UgeDag = DayOfWeek.Friday, SlutTidspunkt = new DateTime(2022, 6, 14, 22, 0, 0), StartTidspunkt = new DateTime(2022, 6, 14, 20, 0, 0), MaxAlder = 99, MinAlder = 18 };
                BadetidsPeriode opgave41 = new BadetidsPeriode() { Type = "Unge", UgeDag = DayOfWeek.Friday, SlutTidspunkt = new DateTime(2022, 6, 14, 22, 0, 0), StartTidspunkt = new DateTime(2022, 6, 14, 20, 0, 0), MaxAlder = 99, MinAlder = 18 };

                Console.WriteLine(opgave40);
                Console.WriteLine(opgave41);

                opgave40.SletKreds("1");
                opgave41.SletKreds("3");

                Console.WriteLine(opgave40);
                Console.WriteLine(opgave41);

                opgave40.AdderKreds(new Kreds() { ID = "1", Navn = "OP2.0", Adresse = "Her", AntalDeltagere = 21, MaxAlder = 99, MinAlder = 18 });
                opgave41.AdderKreds(new Kreds() { ID = "3", Navn = "OP2.2", Adresse = "Her", AntalDeltagere = 18, MaxAlder = 99, MinAlder = 18 });

                Console.WriteLine(opgave40);
                Console.WriteLine(opgave41);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
            }

            //opgave 7

            Console.WriteLine("Opgave - 7");          

            try
            {
                BadetidsPeriode opgave70 = new BadetidsPeriode() { Type = "", UgeDag = DayOfWeek.Friday, SlutTidspunkt = new DateTime(2022, 6, 14, 22, 0, 0), StartTidspunkt = new DateTime(2022, 6, 14, 20, 0, 0), MaxAlder = 99, MinAlder = 18 };                
                Console.WriteLine(opgave70);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }            

            try
            {
                BadetidsPeriode opgave71 = new BadetidsPeriode() { Type = "Unge", UgeDag = DayOfWeek.Friday, SlutTidspunkt = new DateTime(2022, 6, 14, 19, 0, 0), StartTidspunkt = new DateTime(2022, 6, 14, 20, 0, 0), MaxAlder = 99, MinAlder = 18 };
                Console.WriteLine(opgave71);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }            

            try
            {
                Kreds opgave72 = new Kreds() { ID = "1", Navn = "FDF", Adresse = "Her", AntalDeltagere = 0, MaxAlder = 99, MinAlder = 18 };
                Console.WriteLine(opgave72);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
            }

            //Opgave - 9//

            Console.WriteLine("Opgave - 9");

            try
            {
                BadetidsPeriode opgave9 = new BadetidsPeriode() { Type = "Unge", UgeDag = DayOfWeek.Friday, SlutTidspunkt = new DateTime(2022, 6, 14, 22, 0, 0), StartTidspunkt = new DateTime(2022, 6, 14, 20, 0, 0), MaxAlder = 99, MinAlder = 18 };
                Console.WriteLine(opgave9);
                opgave9.MinAlder = 100;
                Console.WriteLine(opgave9);
                opgave9.AdderKreds(new Kreds() { ID = "1", Navn = "FDF", Adresse = "Her", AntalDeltagere = 0, MaxAlder = 17, MinAlder = 1 });
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
            }

            try
            {
                BadetidsPeriode opgave9 = new BadetidsPeriode() { Type = "Unge", UgeDag = DayOfWeek.Friday, SlutTidspunkt = new DateTime(2022, 6, 14, 22, 0, 0), StartTidspunkt = new DateTime(2022, 6, 14, 20, 0, 0), MaxAlder = 99, MinAlder = 18 };                
                Console.WriteLine(opgave9);
                opgave9.AdderKreds(new Kreds() { ID = "4", Navn = "FDF", Adresse = "Her", AntalDeltagere = 1, MaxAlder = 17, MinAlder = 1 });
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
            }

            //Opgave - 10//

            Console.WriteLine("Opgave - 10");            

            try
            {
                BadetidsPeriodeForLoopAndList opgave7 = new BadetidsPeriodeForLoopAndList() { Type = "Senior", UgeDag = DayOfWeek.Monday, SlutTidspunkt = new DateTime(2022, 6, 14, 8, 0, 0), StartTidspunkt = new DateTime(2022, 6, 14, 7, 0, 0), MaxAlder = 99, MinAlder = 18 };
                Console.WriteLine(opgave7);
                opgave7.SletKreds("3");
                Console.WriteLine(opgave7);
                opgave7.AdderKreds(new Kreds() { ID = "3", Navn = "OP10.2", Adresse = "Der", AntalDeltagere = 1, MaxAlder = 99, MinAlder = 18 });
                Console.WriteLine(opgave7);
                opgave7.StartTidspunkt = new DateTime(2022, 6, 14, 9, 0, 0);
                Console.WriteLine(opgave7);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
