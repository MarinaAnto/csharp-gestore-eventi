using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        internal string titolo;
        private DateTime data;
        private int capienzaMax { get; }
        private int postiPrenotati { get; set; }

        public void SetTitolo(string titolo)
        {
            if (titolo == "") { throw new ArgumentNullException(); }
        }
        public void SetData(DateTime data)
        {
            if (data < DateTime.Now) { throw new ArgumentOutOfRangeException(); }

        }
        public DateTime GetData()
        {
            return this.data;
        }
        public string GetTitolo()
        {
            return this.titolo;
        }

        public void SetCapienza(int capienzaMax) 
        {
            if (capienzaMax<0) { throw new ArgumentNullException(); }
        }

        public Evento(string Titolo, DateTime Data,int CapienzaMax)
        {
            
            this.titolo = Titolo;
            this.data = Data;
            this.capienzaMax = CapienzaMax;
            postiPrenotati = 0;

            if (DateTime.Now > Data)
            {
                throw new Exception();
            }

        }
        public int PrenotaPosti(int posti)
        {
            if (posti>capienzaMax) { throw new ArgumentOutOfRangeException(); }
            else { postiPrenotati+=posti; }
            Console.WriteLine("Posti Rimaneneti  Posti Prenotati");
            return postiPrenotati + posti;
        }
        public int DisdiciPosti(int noposti)
        {
            if(noposti<postiPrenotati) { throw new ArgumentOutOfRangeException(); }
            postiPrenotati-=noposti;
            Console.WriteLine("Posti Residui   Posti Disdetti");
            return  postiPrenotati + noposti;
        }
        public override string ToString()
        {
             return data.ToString()+ "-" +titolo;
        }


    }
}
