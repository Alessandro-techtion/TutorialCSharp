namespace GliEnumeratori
{
    internal class Program
    {
        enum Mesi
        {
            Gennaio=1,Febbraio,Marzo,Aprile,Maggio,Giugno,Luglio,Agosto,
            Settembre,Ottobre,Novembre,Dicembre
        }
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tGli enumeratori, enum");
            /*
             * GLI enum POSSIAMO VEDERLI COME UNA CLASSE SPECIALE che rappresenta un gruppo di costanti
             * 
             */
            Console.WriteLine(Mesi.Gennaio);
            Console.WriteLine((int)Mesi.Gennaio);
            
            Mesi mesiNascita = Mesi.Febbraio;
            int mese = (int)(Mesi.Settembre);

            Console.WriteLine();

            Mesi meseNascita = Mesi.Marzo;
            switch (meseNascita)
            {
                case Mesi.Marzo:
                    Console.WriteLine("Siamo in primavera");
                    break;
                case Mesi.Agosto:
                    Console.WriteLine("Siamo in estete");
                    break;
                default:
                    Console.WriteLine("Mese non riconosciuto");
                    break;
            }
        }
    }
}