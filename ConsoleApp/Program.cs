using System.Reflection.Metadata;
using System;
using System.Xml.Schema;
using ClassLibrary;
using ClassLibrary.repository;

namespace ConsoleApp
{
    internal class Program

    {
        static ActivityRepository AktivitetRepo= new ActivityRepository();
        static DyrRepository DyrRepository = new DyrRepository();
        static BrugerRepository BrugerRepo = new BrugerRepository();
        static BookingRepository BookingRepo = new BookingRepository();

        static void Main(string[] args)
        {
            AktivitetRepo.TilføjAktivitet(new Activity(new DateOnly(2025, 5, 22), "Fælles HundeLuftning", "kom ud og år en masse motion og socialisering med andre hunde og mennesker.God mulighed for at styrke deres adfærd og energi.")) ;
            AktivitetRepo.TilføjAktivitet(new Activity(new DateOnly(2025, 6, 15), "Løb I Hamsterhjul", " kom ud og få motion og stimulering. Aktiviteten holdes under opsyn og indrettes som en del af deres daglige rutine."));
            AktivitetRepo.TilføjAktivitet(new Activity(new DateOnly(2025, 6, 25), "Katten Efter Mussen", " Interaktiv leg hvor katte jagter legetøjsmus på snor eller laserlys. Det aktiverer deres jagtinstinkter og giver dem både fysisk og mental stimulering."));

            DyrRepository.TilføjDyr(new Dyr("hund","polsk hund","patrick","3","hun",2002,"hvid"));
            DyrRepository.TilføjDyr(new Dyr("kat", "afrikansk kat","mohib","2","han",1,"sort" ));
            DyrRepository.TilføjDyr(new Dyr("Hamster", "syriesk", "adam", "1", "han",  2015, "Brun"));

            BrugerRepo.TilføjBruger(new Medarbejder("adam","Adam@gmail.com"," 23252627"));
            BrugerRepo.TilføjBruger(new Kunde("mohib", "mohib@gmail.com", "27282930"));
            BrugerRepo.TilføjBruger(new Medarbejder("Patrick", "Patrick@gmail.com"," 23252627"));

            BookingRepo.TilføjBooking(new Booking(1, "Patrick", "Fælles HundeLuftning", new DateOnly(2025, 5, 22)));
            BookingRepo.TilføjBooking(new Booking(2, "adam", "Løb I Hamsterhjul", new DateOnly(2025, 6, 15)));
            BookingRepo.TilføjBooking(new Booking(3, "mohib", "Katten Efter Mussen", new DateOnly(2025, 6, 25)));


            Console.WriteLine("Velkommen til Roskilde Dyreinternat");
            bool running = true;

            while(running == true){


                Console.WriteLine("\nVælg en af valmulighederne");
                Thread.Sleep(700);

                Console.WriteLine("1: se alle brugere");
                Thread.Sleep(200);

                Console.WriteLine("2: Administrer Medarbejder og Kunder");
                Thread.Sleep(200);

                Console.WriteLine("3: se alle Aktiviter");
                Thread.Sleep(200);

                Console.WriteLine("4: tilmeld aktiviteter");
                Thread.Sleep(200);

                Console.WriteLine("5: se alle dyr");
                Thread.Sleep(200);

                Console.WriteLine("6: administre dyr");
                Thread.Sleep(200);

                Console.WriteLine("7: Book en tid");
                Thread.Sleep(200);

                Console.WriteLine("8: se og redigere Blogindlæg");
                Thread.Sleep(200);




                int valg = Convert.ToInt32(Console.ReadLine());

                switch(valg){

                    case 1: // Se alle brugere

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
                    case 2: // Administrer medarbejder og kunder

                        Console.WriteLine("1: tiføj medarbejder");
                        Console.WriteLine("2: tilføj kunde");
                        

                        int vælg = Convert.ToInt32(Console.ReadLine());

                        switch (vælg)
                        {
                            case 1: // Tilføj medarbejder
                                Console.Write("Indtast navn: ");
                                string navn = Console.ReadLine();
                                Console.Write("Indtast email: ");
                                string email = Console.ReadLine();
                                Console.Write("Indtast telefonnummer: ");
                                string telefonnummer = Console.ReadLine();

                                Medarbejder medarbejder = new Medarbejder(navn, email, telefonnummer);
                                BrugerRepo.TilføjBruger(medarbejder);
                                Console.WriteLine("Medarbejder tilføjet.");
                                break;


                            case 2: // Tilføj kunde
                                Console.Write("Indtast navn: ");
                                string Navn = Console.ReadLine();
                                Console.Write("Indtast email: ");
                                string Email = Console.ReadLine();
                                Console.Write("Indtast telefonnummer: ");
                                string Telefonnummer = Console.ReadLine();

                                Kunde kunde1 = new Kunde(Navn, Email,Telefonnummer);
                                BrugerRepo.TilføjBruger(kunde1);
                                Console.WriteLine("Kunde tilføjet.");
                                break;


                        }


                      break;
                    case 3: // Se alle aktiviteter

                        foreach (var item in AktivitetRepo.getAll())
                        {
                            item.VisInfo();
                        }


                        break;

                    case 4: // Tilmeld aktiviteter

                        bool Run = true;
                        while (Run == true)
                        {
                            Console.WriteLine("\nVælg en af følgende muligheder");

                            foreach (var item in AktivitetRepo.getAll())
                            {
                                item.VisInfo();

                            }
                            Console.WriteLine("\nindtast enten \n1 \n2 \n3");

                            int Indtast = Convert.ToInt32(Console.ReadLine());
                            if (BrugerRepo.ErTom())
                            {
                                Console.WriteLine("lav først en brugere");

                                Run = false;
                            }
                            else if (Indtast == 1)
                            {

                                var brugere = BrugerRepo.HentAlleBrugere();

                                Console.WriteLine("Vælg en bruger:");
                                int i = 1;
                                foreach (var item in brugere)
                                    Console.WriteLine($"{i++}: {item.Navn}");

                                int vælger = Convert.ToInt32(Console.ReadLine());
                                var valgtBruger = brugere[vælger - 1];

                                Console.WriteLine($"{valgtBruger.Navn} tilmeldt til [Fælles HundeLufting]");


                                Run = false;
                            }
                            else if (Indtast == 2)
                            {

                                var brugere = BrugerRepo.HentAlleBrugere();

                                Console.WriteLine("Vælg en bruger:");
                                int i = 1;
                                foreach (var item in brugere)
                                    Console.WriteLine($"{i++}: {item.Navn}");

                                int vælger = Convert.ToInt32(Console.ReadLine());
                                var valgtBruger = brugere[vælger - 1];

                                Console.WriteLine($"{valgtBruger.Navn} tilmeldt til [Løb i HamsterHjul]");

                                Run = false;
                            }
                            else if (Indtast == 3)
                            {

                                var brugere = BrugerRepo.HentAlleBrugere();

                                Console.WriteLine("Vælg en bruger:");
                                int i = 1;
                                foreach (var item in brugere)
                                    Console.WriteLine($"{i++}: {item.Navn}");

                                int vælger = Convert.ToInt32(Console.ReadLine());
                                var valgtBruger = brugere[vælger - 1];

                                Console.WriteLine($"{valgtBruger.Navn} tilmeldt til [Katten efter Mussen]");


                                Run = false;
                            }
                            else
                            {

                                Console.WriteLine("indtast venligst et af de givende tal");

                            }


                        }

                        break;

                    case 5: // Se alle dyr

                        foreach (var item in DyrRepository.HentAlleDyr())
                        {
                            item.VisInfo();

                        }

                        break;

                    case 6: // Administrer dyr
                        Console.WriteLine("1: tilføj Dyr");
                        Console.WriteLine("2: rediger Dyr");
                        Console.WriteLine("3: slet Dyr");
                        int dyrValg = Convert.ToInt32(Console.ReadLine());

                        switch (dyrValg)
                        {
                            case 1:
                                Console.Write("Indtast art: ");
                                string art = Console.ReadLine();
                                Console.Write("Indtast race: ");
                                string race = Console.ReadLine();
                                Console.Write("Indtast Navn: ");
                                string navn = Console.ReadLine();
                                Console.Write("Indtast chipnummer: ");
                                string chipnummer = Console.ReadLine();
                                Console.Write("Indtast køn: ");
                                string køn = Console.ReadLine();
                                Console.Write("Indtast fødelsaar: ");
                                int fødselsaar = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Intast farve: ");
                                string farve = Console.ReadLine();
                                Console.Write("Indtast farve: ");

                                Dyr nytDyr = new Dyr(art, race, navn, chipnummer, køn, fødselsaar, farve);
                                DyrRepository.TilføjDyr(nytDyr);
                                Console.WriteLine("Dyr tilføjet.");
                                break;

                            case 2: // Rediger Dyr

                                break;
                            case 3: // Slet Dyr

                                break;
                            default:
                                Console.WriteLine("Ugyldigt valg.");
                                break;
                        }
                        break;

                    case 7: // Book en tid

                        break;

                    case 8: // Se og redigere blogindlæg

                        break;

                     
                }
           

            }




        }
    }
}
