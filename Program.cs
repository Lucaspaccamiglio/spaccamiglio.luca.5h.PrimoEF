using System;

namespace spaccamiglio.luca._5h.PrimoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DbPersone db = new();

            db.Persone.Add(new Persona{Nome= "Luca", Cognome="Spaccamiglio",EMail="luca@gmail.com"});
            db.SaveChanges();
        }
    }
}
