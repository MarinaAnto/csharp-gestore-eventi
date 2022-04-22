// See https://aka.ms/new-console-template for more information
using GestoreEventi;
Evento nuovo=null;
while (nuovo == null)
{
    Console.WriteLine("Inserire il titolo dell'evento");
    string Nuovo_evento = Console.ReadLine();

    Console.WriteLine("Inserire la capienza massima dell' evento scelto");
    int Nuova_capienza = int.Parse(Console.ReadLine());

    try
    {
        Console.WriteLine("Inserire la data dell'evento");
        DateTime Nuova_data = DateTime.Parse(Console.ReadLine());

        nuovo = new Evento(Nuovo_evento, Nuova_data, Nuova_capienza);
    }
    catch (Exception ex)
    {
        Console.WriteLine("La data è precedente a oggi.Inserire nuova data");
    }
}
    Console.WriteLine("Quanti posti vuoi prenotare?");
    int numero=int.Parse(Console.ReadLine());
try { nuovo.PrenotaPosti(numero); }
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
    Console.WriteLine("Vuoi disdire i posti?Si/No");
    if (Console.ReadLine() == "Si")
    {
        Console.WriteLine("Quanti posti vuoi disdire?");
        int postidisdetti=int.Parse(Console.ReadLine());
        nuovo.DisdiciPosti(postidisdetti);
    }
    else
    {
        Console.WriteLine("Le auguro buon roseguimento.");
    }


Console.WriteLine("Vuoi creare un programma di eventi?");
Console.WriteLine("Qual'è il titolo del tuo programma eventi?");
string Nuovo_titolo=Console.ReadLine();

ProgrammaEventi ListaEventi = new ProgrammaEventi(Nuovo_titolo);

Console.WriteLine("Qunati eventi vuoi aggingere al programma?");
int numero_evento=int.Parse(Console.ReadLine());

Console.WriteLine("Inserire il titolo dell'evento");
string TitleEvento = Console.ReadLine();

Console.WriteLine("Inserire la data dell'evento");
DateTime DateEvent = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Inserire la capienza massima dell' evento scelto");
int CapienzaMaxEvent = int.Parse(Console.ReadLine());

ListaEventi.AggiungiEvento(numero_evento,TitleEvento ,DateEvent ,CapienzaMaxEvent);
ListaEventi.NumeroEventi();
ListaEventi.StampaTutto();

Console.WriteLine("Se vuoi vedere gli eventi presenti in un certo giorno inserisci data");
DateTime datains=DateTime.Parse(Console.ReadLine());
 ListaEventi.StessaData(datains);
ListaEventi.RimuoviTutto();



