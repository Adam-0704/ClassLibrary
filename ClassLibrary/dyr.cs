using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Dyr
    {
        public int Id { get; set; }
        public string Art { get; set; }                // Species
        public string Race { get; set; }               // Breed
        public string Navn { get; set; }               // Name
        public string Chipnummer { get; set; }         // ChipNumber
        public string SærligeKendetegn { get; set; }   // SpecialFeatures
        public string Størrelse { get; set; }          // Size
        public int Fødselsår { get; set; }             // BirthYear
        public DateTime Ankomstdato { get; set; }      // ArrivalDate


        // Constructor
        public Dyr(int id, string art, string race, string navn, string chipnummer, string særligeKendetegn, string størrelse, int fødselsår, DateTime ankomstdato)
        {
            Id = id;
            Art = art;
            Race = race;
            Navn = navn;
            Chipnummer = chipnummer;
            SærligeKendetegn = særligeKendetegn;
            Størrelse = størrelse;
            Fødselsår = fødselsår;
            Ankomstdato = ankomstdato;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Art: {Art}, Race: {Race}, Navn: {Navn}, Chipnummer: {Chipnummer}, Særlige kendetegn: {SærligeKendetegn}, Størrelse: {Størrelse}, Fødselsår: {Fødselsår}, Ankomstdato: {Ankomstdato:dd-MM-yyyy}";
        }

    }
}
