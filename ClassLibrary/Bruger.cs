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
        

        public Bruger(string navn, string email)
        {
            Navn = navn;
            Email = email;
        }

        public virtual void VisInfo()
        {
            Console.WriteLine($"Navn: {Navn}, Email: {Email}");
        }
    }



    public class Medarbejder : Bruger
    {

        public Medarbejder(string navn, string email) : base(navn, email)
        {

        }

        public override void VisInfo()
        {
            Console.WriteLine($"[Medarbejder] Navn: {Navn},Email: {Email}");
        }

    }

    public class Kunde : Bruger
    {

        public Kunde(string navn, string email) : base(navn, email)
        {

        }
        public override void VisInfo()
        {
            Console.WriteLine($"[Kunde] Navn: {Navn},Email: {Email}");
        }


    }




}
