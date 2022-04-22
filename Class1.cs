using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Conferenza : Evento
    {

        private string relatore { get; set; }
        private double prezzo { get; set; }

        public Conferenza(string Relatore,double Prezzo, string titolo,DateTime data,int capmax) : base(titolo,data,capmax)
        {
            this.relatore = Relatore;
            this.prezzo = Prezzo;
        }
    }
}
