using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Bruger
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Email { get; set; }
        public string Telefonnummer { get; set; }


        public Bruger(int id, string navn, string email, string telefonnummer)
        {
            Id = id;
            Navn = navn;
            Email = email;
            Telefonnummer = telefonnummer;
        }

        public virtual void VisInfo()
        {
            Console.WriteLine($" ID:{Id},Navn: {Navn}, Email: {Email}, Telefonnummer {Telefonnummer}");
        }
    }



    public class Medarbejder : Bruger
    {

        public Medarbejder(int id, string navn, string email, string telefonnummer) : base(id,navn, email, telefonnummer)
        {

        }

        public override void VisInfo()
        {
            Console.WriteLine($"[Medarbejder] ID:{Id}, Navn: {Navn},Email: {Email}, Telefonnummer: {Telefonnummer}");
        }

    }

    public class Kunde : Bruger
    {

        public Kunde(int id, string navn, string email,string telefonnummer) : base(id, navn, email, telefonnummer)
        {

        }
        public override void VisInfo()
        {
            Console.WriteLine($"[Kunde] ID:{Id}, Navn: {Navn},Email: {Email}, Telefonnummer: {Telefonnummer}");
        }


    }




}
