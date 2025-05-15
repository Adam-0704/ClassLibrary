using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Activity
    {
        public string Navn { get; set; }
        public string Beskrivelse{ get; set; }
        public DateOnly Dato { get; set; }

        public Activity(DateOnly dato, string navn, string beskrivelse) 
        {
            Dato = dato;

            Navn = navn;

            Beskrivelse = beskrivelse;

        }

        public void VisInfo()
        {
            Console.WriteLine($"\n[{Navn}]: {Beskrivelse} - {Dato}  ");

        }

       
        









    }
}
