using System.Xml.Schema;
using ClassLibrary;
using ClassLibrary.repository;

namespace ConsoleApp
{
    internal class Program
    {
        static BrugerRepository BrugerRepo = new BrugerRepository();
        static void Main(string[] args)
        {


            Console.WriteLine("Velkommen til Roskilde Dyreinternat");

            bool running = true;

            while(running == true){


                Console.WriteLine("Vælg en af valmulighederne");
                Thread.Sleep(1000);

                Console.WriteLine("1: se alle brugere");
                Thread.Sleep(200);

                Console.WriteLine("2: Administrer Medarbejder og Kunder");
                Thread.Sleep(200);

                Console.WriteLine("3: se alle dyr");
                Thread.Sleep(200);

                int valg = Convert.ToInt32(Console.ReadLine());

                switch(valg){

                    case 1:

                        if (BrugerRepo.ErTom())
                        {
                            Console.WriteLine("der er ingen brugere endnu");
                        }
                        else
                        {
                            foreach (var item in BrugerRepo.HentAlleBrugere())
                            {
                                item.VisInfo();
                            }
                        }
                       

                        break;
                    case 2:

                        Console.WriteLine("1: tiføj medarbejder");
                        Console.WriteLine("2: tilføj kunde");
                        

                        int vælg = Convert.ToInt32(Console.ReadLine());

                        switch (vælg)
                        {
                            case 1:
                                Console.Write("Indtast navn: ");
                                string navn = Console.ReadLine();
                                Console.Write("Indtast email: ");
                                string email = Console.ReadLine();

                                Medarbejder M = new Medarbejder(navn, email);
                                BrugerRepo.TilføjBruger(M);
                                Console.WriteLine("Medarbejder tilføjet.");
                                break;


                            case 2:
                                Console.Write("Indtast navn: ");
                                string Navn = Console.ReadLine();
                                Console.Write("Indtast email: ");
                                string Email = Console.ReadLine();

                                Kunde kunde1 = new Kunde(Navn, Email);
                                BrugerRepo.TilføjBruger(kunde1);
                                Console.WriteLine("Kunde tilføjet.");
                                break;


                        }


                      break;


                }
           

            }




        }
    }
}
