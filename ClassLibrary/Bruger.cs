using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Bruger
    {
        public string Navn { get; set; }
        public string Email { get; set; }
        public string Telefonnummer { get; set; }


        public Bruger(string navn, string email, string telefonnummer)
        {
            Navn = navn;
            Email = email;
            Telefonnummer = telefonnummer;
        }

        public virtual void VisInfo()
        {
            Console.WriteLine($"Navn: {Navn}, Email: {Email}, Telefonnummer {Telefonnummer}");
        }
    }



    public class Medarbejder : Bruger
    {

        public Medarbejder(string navn, string email, string telefonnummer) : base(navn, email, telefonnummer)
        {

        }

        public override void VisInfo()
        {
            Console.WriteLine($"[Medarbejder] Navn: {Navn},Email: {Email}, Telefonnummer: {Telefonnummer}");
        }

    }

    public class Kunde : Bruger
    {

        public Kunde(string navn, string email,string telefonnummer) : base(navn, email, telefonnummer)
        {

        }
        public override void VisInfo()
        {
            Console.WriteLine($"[Kunde] Navn: {Navn},Email: {Email}, Telefonnummer: {Telefonnummer}");
        }


    }




}
