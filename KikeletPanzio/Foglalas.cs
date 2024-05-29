using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KikeletPanzio
{
    public class Foglalas
    {
        int szobaszam;
        string nev;
        DateTime erkezes;
        DateTime tavozas;
        int fo;
        int ejszakak;
        int fizetes;
        string allapot;

        public Foglalas(int szobaszam, string nev, DateTime erkezes, DateTime tavozas, int fo, int ejszakak, int fizetes, string allapot)
        {
            this.Szobaszam = szobaszam;
            this.Nev = nev;
            this.Erkezes = erkezes;
            this.Tavozas = tavozas;
            this.Fo = fo;
            this.Ejszakak = ejszakak;
            this.Fizetes = fizetes;
            this.Allapot = allapot;
        }

        public int Szobaszam { get => szobaszam; set => szobaszam = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Erkezes { get => erkezes; set => erkezes = value; }
        public DateTime Tavozas { get => tavozas; set => tavozas = value; }
        public int Fo { get => fo; set => fo = value; }
        public int Ejszakak { get => ejszakak; set => ejszakak = value; }
        public int Fizetes { get => fizetes; set => fizetes = value; }
        public string Allapot { get => allapot; set => allapot = value; }
    }
}
