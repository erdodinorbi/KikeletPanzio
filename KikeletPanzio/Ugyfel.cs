using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KikeletPanzio
{
    public class Ugyfel
    {
        string azonosito;
        string nev;
        DateTime szuletesi_datum;
        string email;
        bool vip;

        public Ugyfel(string azonosito, string nev, DateTime szuletesi_datum, string email, bool vip)
        {
            this.Azonosito = azonosito;
            this.Nev = nev;
            this.Szuletesi_datum = szuletesi_datum;
            this.Email = email;
            this.Vip = vip;
        }

        public string Azonosito { get => azonosito; set => azonosito = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Szuletesi_datum { get => szuletesi_datum; set => szuletesi_datum = value; }
        public string Email { get => email; set => email = value; }
        public bool Vip { get => vip; set => vip = value; }
    }
}
