using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Booking
    {
        public int Id { get; set; } 
        public string BrugerNavn { get; set; } 
        public string AktivitetNavn { get; set; } 
        public DateOnly Dato { get; set; } 

        public Booking(int id, string brugerNavn, string aktivitetNavn, DateOnly dato)
        {
            Id = id;
            BrugerNavn = brugerNavn;
            AktivitetNavn = aktivitetNavn;
            Dato = dato;
        }

        public void VisInfo()
        {
            Console.WriteLine($"Booking ID: {Id}, Bruger: {BrugerNavn}, Aktivitet: {AktivitetNavn}, Dato: {Dato}");
        }
    }
}
