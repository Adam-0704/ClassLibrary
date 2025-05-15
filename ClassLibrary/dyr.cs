using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Dyr
    {
        public string Art { get; set; }
        public string Race { get; set; }
        public string Navn { get; set; }
        public string Chipnummer { get; set; }
        public string Køn { get; set; }
        public int Fødselsaar { get; set; }
        public string Farve { get; set; }

        // Constructor
        public Dyr(string art, string race, string navn, string chipnummer, string køn, int fødselsaar, string farve)
        {
            Art = art;
            Race = race;
            Navn = navn;
            Chipnummer = chipnummer;
            Køn = køn;
            Fødselsaar = fødselsaar;
            Farve = farve;
        }
        public void VisInfo()
        {
            Console.WriteLine( $"Art: {Art}, Race: {Race}, Navn: {Navn}, Chipnummer: {Chipnummer}, Køn: {Køn}, Fødselsår {Fødselsaar}, Farve {Farve} ");
        }

    }
}
