using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class ProgrammaEventi 
    {
        private string title { get; set; }
        private List<Evento> events { get; set; }

        public ProgrammaEventi(string Title)
        {
            this.title = Title;
            events = new List<Evento>();
        }
        public void AggiungiEvento(int n,string titoloevento,DateTime dataevento,int capienzaevento)
        {
            for (int i = 0; i < n; i++)
            {
                Evento eventonuovo = new Evento(titoloevento,dataevento,capienzaevento);
                events.Add(eventonuovo);
            }
            Console.WriteLine("Hai aggiunto" + n + " eventi alla tua lista");
        } 
        public void StampaTutto()
        {
            events.ForEach(delegate (Evento events)
            {
                Console.WriteLine(events);
            });
        }
        public void StessaData(DateTime datainserita)
        {
            foreach (Evento evento1 in events)
            {
                if (datainserita.Equals(evento1.GetData()))
                {
                    Console.WriteLine(evento1.GetData() + evento1.GetTitolo()  );
                }
            }
        }
        public void NumeroEventi()
        {
            Console.WriteLine("Nella lista ci sono " + events.Count()+"eventi.");
        }
        public void RimuoviTutto()
        {
            events.Clear();
            Console.WriteLine("Hai rimmosso tutti gli eventi dalla lista");       
        }



    }
}
