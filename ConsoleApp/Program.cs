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

        static string blogIndhold = " 🐾 En Dag i Dyrenes Tegn – Besøgsdag på Internatet\r\nDato: 18. maj 2025\r\nForfatter: Louise, medarbejder på Roskilde Internat\r\n\r\nSøndag formiddag vågnede vi op til solskin og fuglesang – det perfekte vejr til en besøgsdag her på Roskilde Dyreinternat. Allerede fra klokken 10 begyndte de første familier at dukke op med store smil og åbne hjerter, klar til at møde nogle af de dejlige dyr, der venter på deres nye hjem.\r\n\r\nDer var stor interesse for både hundene og kattene – især vores energibundt af en terrier, Buster, som hurtigt charmerede sig ind i hjertet på en børnefamilie fra Køge. I løbet af dagen fik vi også besøg af flere frivillige, som gerne ville høre mere om, hvordan de kan hjælpe – både med daglige opgaver og med kommende aktiviteter som \"Fælles hundeluftning\" og \"Kattens legestue\".\r\n\r\nVi fik snakket med mange søde besøgende, og både dyr og mennesker nød selskabet. Flere kunder bookede opfølgende besøg via vores nye online bookingsystem, som blev taget godt imod – det glæder os at se, at det gør hverdagen nemmere for både jer og os!\r\n\r\nUnder frokosten bød vi på hjemmelavede boller og kaffe – og vores lille maskotkanin Luna hoppede glad rundt mellem bordene, til stor fornøjelse for børnene.\r\n\r\nTak til alle jer, der kiggede forbi og gjorde dagen helt særlig. Og en ekstra tak til vores frivillige og medarbejdere, der sørger for, at både dyr og besøgende føler sig hjemme hos os.\r\n\r\nVi glæder os allerede til næste arrangement – og indtil da, kig gerne forbi bloggen her, hvor vi løbende deler nyheder, historier og små øjeblikke fra livet på internatet 🐶🐱💚\r\n\r\nHar du lyst til at blive frivillig eller booke et besøg? Det kan du nu gøre direkte her på siden!\r\n\r\n";

        static void Main(string[] args)
        {
            AktivitetRepo.TilføjAktivitet(new Activity(1, new DateOnly(2025, 5, 22), "Fælles HundeLuftning", "Kom ud og år en masse motion og socialisering med andre hunde og mennesker. God mulighed for at styrke deres adfærd og energi.")) ;
            AktivitetRepo.TilføjAktivitet(new Activity(2, new DateOnly(2025, 6, 15), "Løb I Hamsterhjul", " Kom ud og få motion og stimulering. Aktiviteten holdes under opsyn og indrettes som en del af deres daglige rutine."));
            AktivitetRepo.TilføjAktivitet(new Activity(3, new DateOnly(2025, 6, 25), "Katten Efter Mussen", " Interaktiv leg hvor katte jagter legetøjsmus på snor eller laserlys. Det aktiverer deres jagtinstinkter og giver dem både fysisk og mental stimulering."));
            
            DyrRepository.TilføjDyr(new Dyr(1, "Hund", "Polsk Hund", "Patrick", "3", "Ingen", "Stor", 2002, new DateTime(2020, 1, 1)));
            DyrRepository.TilføjDyr(new Dyr(2, "Kat", "Afrikansk Kat", "Mohib", "2", "Ingen", "Lille", 2021, new DateTime(2023, 5, 10)));
            DyrRepository.TilføjDyr(new Dyr(3, "Hamster", "Syrisk", "Adam", "1", "Brun plet", "Lille", 2015, new DateTime(2024, 3, 15)));

            BrugerRepo.TilføjBruger(new Medarbejder(1, "Adam", "Adam@gmail.com", "23252627"));
            BrugerRepo.TilføjBruger(new Kunde(2, "Mohib", "mohib@gmail.com", "27282930"));
            BrugerRepo.TilføjBruger(new Medarbejder(3, "Patrick", "Patrick@gmail.com", "23252627"));

            BookingRepo.TilføjBooking(new Booking(1, "Patrick", "Fælles HundeLuftning", new DateOnly(2025, 5, 22)));
            BookingRepo.TilføjBooking(new Booking(2, "Adam", "Løb I Hamsterhjul", new DateOnly(2025, 6, 15)));
            BookingRepo.TilføjBooking(new Booking(3, "Mohib", "Katten Efter Mussen", new DateOnly(2025, 6, 25)));

            
            Console.WriteLine("Velkommen til Roskilde Dyreinternat");
            bool running = true;

            while(running == true){


                Console.WriteLine("\nVælg en af valmulighederne");
                Thread.Sleep(700);

                Console.WriteLine("1: Se alle brugere");
                Thread.Sleep(200);

                Console.WriteLine("2: Administrer Medarbejder og Kunder");
                Thread.Sleep(200);

                Console.WriteLine("3: Se alle Aktiviter");
                Thread.Sleep(200);

                Console.WriteLine("4: Tilmeld aktiviteter");
                Thread.Sleep(200);

                Console.WriteLine("5: Se alle dyr");
                Thread.Sleep(200);

                Console.WriteLine("6: Administre dyr");
                Thread.Sleep(200);

                Console.WriteLine("7: Se Bookinger");
                Thread.Sleep(200);

                Console.WriteLine("8: Book en tid hos et dyr");
                Thread.Sleep(200);

                Console.WriteLine("9: Se og redigere Blogindlæg");
                Thread.Sleep(200);




                int valg = Convert.ToInt32(Console.ReadLine());

                switch(valg){

                    case 1: // Se alle brugere

                        if (BrugerRepo.ErTom())
                        {
                            Console.WriteLine("Der er ingen brugere endnu");
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

                        Console.WriteLine("1: Tiføj medarbejder");
                        Console.WriteLine("2: Tilføj kunde");
                        

                        int vælg = Convert.ToInt32(Console.ReadLine());

                        switch (vælg)
                        {
                            case 1: // Tilføj medarbejder
                                Console.Write("Indtast id: ");
                                int medarbejderId = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Indtast navn: ");
                                string navn = Console.ReadLine();
                                Console.Write("Indtast email: ");
                                string email = Console.ReadLine();
                                Console.Write("Indtast telefonnummer: ");
                                string telefonnummer = Console.ReadLine();

                                Medarbejder medarbejder = new Medarbejder(medarbejderId, navn, email, telefonnummer);
                                BrugerRepo.TilføjBruger(medarbejder);
                                Console.WriteLine("Medarbejder tilføjet.");
                                break;


                            case 2: // Tilføj kunde
                                Console.Write("Indtast id: ");
                                int kundeId = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Indtast navn: ");
                                string Navn = Console.ReadLine();
                                Console.Write("Indtast email: ");
                                string Email = Console.ReadLine();
                                Console.Write("Indtast telefonnummer: ");
                                string Telefonnummer = Console.ReadLine();

                                Kunde kunde1 = new Kunde(kundeId, Navn, Email,Telefonnummer);
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
                            Console.WriteLine("\nIndtast enten \n1 \n2 \n3");

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
                                var valgteBruger = brugere[vælger - 1];

                                Console.WriteLine($"{valgteBruger.Navn} Tilmeldt til [Fælles HundeLuftning]");


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
                                var valgteBruger = brugere[vælger - 1];

                                Console.WriteLine($"{valgteBruger.Navn} Tilmeldt til [Løb i HamsterHjul]");

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
                                var valgteBruger = brugere[vælger - 1];

                                Console.WriteLine($"{valgteBruger.Navn} Tilmeldt til [Katten efter Mussen]");


                                Run = false;
                            }
                            else
                            {

                                Console.WriteLine("Indtast venligst et af de givende tal");

                            }


                        }

                        break;

                    case 5: // Se alle dyr
                        foreach (var item in DyrRepository.HentAlleDyr())
                        {
                            Console.WriteLine(item.ToString());
                        }
                        break;

                    case 6: // Administrer dyr
                        Console.WriteLine("1: Tilføj Dyr");
                        Console.WriteLine("2: Rediger Dyr");
                        Console.WriteLine("3: Slet Dyr");
                        int dyrValg = Convert.ToInt32(Console.ReadLine());

                        switch (dyrValg)
                        {
                            case 1:
                                Console.Write("Indtast id: ");
                                int id = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Indtast art: ");
                                string art = Console.ReadLine();
                                Console.Write("Indtast race: ");
                                string race = Console.ReadLine();
                                Console.Write("Indtast navn: ");
                                string navn = Console.ReadLine();
                                Console.Write("Indtast chipnummer: ");
                                string chipnummer = Console.ReadLine();
                                Console.Write("Indtast særlige kendetegn: ");
                                string særligeKendetegn = Console.ReadLine();
                                Console.Write("Indtast størrelse: ");
                                string størrelse = Console.ReadLine();
                                Console.Write("Indtast fødselsår: ");
                                int fødselsår = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Indtast ankomstdato (yyyy-mm-dd): ");
                                DateTime ankomstdato = DateTime.Parse(Console.ReadLine());

                                Dyr nytDyr = new Dyr(id, art, race, navn, chipnummer, særligeKendetegn, størrelse, fødselsår, ankomstdato);
                                DyrRepository.TilføjDyr(nytDyr);
                                Console.WriteLine("Dyr tilføjet.");
                                break;

                            case 2: // Rediger Dyr
                                Console.Write("Indtast id på dyret der skal redigeres: ");
                                int redigerId = Convert.ToInt32(Console.ReadLine());
                                var dyrListe = DyrRepository.HentAlleDyr();
                                Dyr dyrAtRedigere = null;
                                foreach (var dyr in dyrListe)
                                {
                                    if (dyr.Id == redigerId)
                                    {
                                        dyrAtRedigere = dyr;
                                        break;
                                    }
                                }
                                if (dyrAtRedigere != null)
                                {
                                    Console.Write("Nyt navn (lad tom for ingen ændring): ");
                                    string nytNavn = Console.ReadLine();
                                    if (!string.IsNullOrWhiteSpace(nytNavn)) dyrAtRedigere.Navn = nytNavn;

                                    Console.Write("Ny art (lad tom for ingen ændring): ");
                                    string nyArt = Console.ReadLine();
                                    if (!string.IsNullOrWhiteSpace(nyArt)) dyrAtRedigere.Art = nyArt;

                                    Console.Write("Ny race (lad tom for ingen ændring): ");
                                    string nyRace = Console.ReadLine();
                                    if (!string.IsNullOrWhiteSpace(nyRace)) dyrAtRedigere.Race = nyRace;

                                    Console.Write("Nyt chipnummer (lad tom for ingen ændring): ");
                                    string nytChipnummer = Console.ReadLine();
                                    if (!string.IsNullOrWhiteSpace(nytChipnummer)) dyrAtRedigere.Chipnummer = nytChipnummer;

                                    Console.Write("Nye særlige kendetegn (lad tom for ingen ændring): ");
                                    string nyeKendetegn = Console.ReadLine();
                                    if (!string.IsNullOrWhiteSpace(nyeKendetegn)) dyrAtRedigere.SærligeKendetegn = nyeKendetegn;

                                    Console.Write("Ny størrelse (lad tom for ingen ændring): ");
                                    string nyStørrelse = Console.ReadLine();
                                    if (!string.IsNullOrWhiteSpace(nyStørrelse)) dyrAtRedigere.Størrelse = nyStørrelse;

                                    Console.Write("Nyt fødselsår (lad tom for ingen ændring): ");
                                    string nytFødselsår = Console.ReadLine();
                                    if (!string.IsNullOrWhiteSpace(nytFødselsår))
                                    {
                                        int nytfødselsår;
                                        if (int.TryParse(nytFødselsår, out fødselsår)) dyrAtRedigere.Fødselsår = fødselsår;
                                    }

                                    Console.Write("Ny ankomstdato (yyyy-mm-dd, lad tom for ingen ændring): ");
                                    string nyAnkomstdato = Console.ReadLine();
                                    if (!string.IsNullOrWhiteSpace(nyAnkomstdato))
                                    {
                                        DateTime ankomstdatoVal;
                                        if (DateTime.TryParse(nyAnkomstdato, out ankomstdatoVal)) dyrAtRedigere.Ankomstdato = ankomstdatoVal;
                                    }

                                    Console.WriteLine("Dyret er opdateret.");
                                }
                                else
                                {
                                    Console.WriteLine("Dyr med det id blev ikke fundet.");
                                }
                                break;
                            case 3: // Slet Dyr
                                Console.Write("Indtast id på dyret der skal slettes: ");
                                int sletId = Convert.ToInt32(Console.ReadLine());
                                var dyrListe2 = DyrRepository.HentAlleDyr();
                                Dyr dyrAtSlette = null;
                                foreach (var dyr in dyrListe2)
                                {
                                    if (dyr.Id == sletId)
                                    {
                                        dyrAtSlette = dyr;
                                        break;
                                    }
                                }
                                if (dyrAtSlette != null)
                                {
                                    DyrRepository.SletDyr(dyrAtSlette);
                                    Console.WriteLine("Dyret er slettet.");
                                }
                                else
                                {
                                    Console.WriteLine("Dyr med det id blev ikke fundet.");
                                }
                                break;
                            default:
                                Console.WriteLine("Ugyldigt valg.");
                                break;
                        }
                        break;

                    case 7: //Se Bookininger

                        if (BookingRepo.HentAlleBookings().Count == 0)
                        {
                            Console.WriteLine("Der er ingen bookinger endnu.");
                        }
                        else
                        {
                            foreach (var booking in BookingRepo.HentAlleBookings())
                            {
                                Console.WriteLine($"Booking ID: {booking.Id}, Bruger: {booking.BrugerNavn}, Dyr/Aktivitet: {booking.AktivitetNavn}, Dato: {booking.Dato:dd-MM-yyyy}");
                            }
                        }
                        break;


                    case 8: // Book en tid
                        Console.WriteLine("Vælg en bruger til booking (indtast ID):");
                        var brugereTilBooking = BrugerRepo.HentAlleBrugere();
                        for (int i = 0; i < brugereTilBooking.Count; i++)
                        {
                            Console.WriteLine($"ID: {brugereTilBooking[i].Id}, Navn: {brugereTilBooking[i].Navn}");
                        }
                        int brugerId = Convert.ToInt32(Console.ReadLine());
                        Bruger valgtBruger = null;
                        for (int i = 0; i < brugereTilBooking.Count; i++)
                        {
                            if (brugereTilBooking[i].Id == brugerId)
                            {
                                valgtBruger = brugereTilBooking[i];
                                break;
                            }
                        }
                        if (valgtBruger == null)
                        {
                            Console.WriteLine("Bruger med det ID blev ikke fundet.");
                            break;
                        }

                        // Vis alle dyr med ID
                        Console.WriteLine("Vælg et dyr at booke tid hos (indtast ID):");
                        var dyrListeBooking = DyrRepository.HentAlleDyr();
                        for (int i = 0; i < dyrListeBooking.Count; i++)
                        {
                            Console.WriteLine($"ID: {dyrListeBooking[i].Id}, Navn: {dyrListeBooking[i].Navn}, Art: {dyrListeBooking[i].Art}, Race: {dyrListeBooking[i].Race}");
                        }
                        int dyrId = Convert.ToInt32(Console.ReadLine());
                        Dyr valgtDyr = null;
                        for (int i = 0; i < dyrListeBooking.Count; i++)
                        {
                            if (dyrListeBooking[i].Id == dyrId)
                            {
                                valgtDyr = dyrListeBooking[i];
                                break;
                            }
                        }
                        if (valgtDyr == null)
                        {
                            Console.WriteLine("Dyr med det ID blev ikke fundet.");
                            break;
                        }

                        // Vælg dato for booking
                        Console.Write("Indtast dato for booking (yyyy-mm-dd): ");
                        string datoInput = Console.ReadLine();
                        DateTime bookingDato;
                        if (!DateTime.TryParse(datoInput, out bookingDato))
                        {
                            Console.WriteLine("Ugyldigt datoformat.");
                            break;
                        }

                        // Opret booking
                        int nyBookingId = BookingRepo.HentAlleBookings().Count + 1;
                        Booking nyBooking = new Booking(nyBookingId, valgtBruger.Navn, valgtDyr.Navn, DateOnly.FromDateTime(bookingDato));
                        BookingRepo.TilføjBooking(nyBooking);

                        Console.WriteLine($"Booking oprettet for {valgtBruger.Navn} hos dyret '{valgtDyr.Navn}' den {bookingDato:dd-MM-yyyy}.");
                        break;
                        

                    case 9: // Se og redigere blogindlæg
                    case 13: // Rediger blog

                        Console.WriteLine("Velkommen til Hillerød Sejlklubs Blog!");
                        Console.WriteLine("1: Se blogindhold");
                        Console.WriteLine("2: Rediger blogindhold");
                        int blogValg = Convert.ToInt32(Console.ReadLine());

                        switch (blogValg)
                        {
                            case 1: // Se blogindhold
                                Console.WriteLine(blogIndhold);
                                break;

                            case 2: // Rediger blogindhold
                                Console.WriteLine("Indtast nyt blogindhold:");
                                blogIndhold = Console.ReadLine();
                                Console.WriteLine("\nBlogindholdet er blevet opdateret:");
                                Console.WriteLine(blogIndhold);
                                break;

                            default:
                                Console.WriteLine("Ugyldigt valg.");
                                break;
                        }
                        break;

                     
                }
           

            }




        }
    }
}
