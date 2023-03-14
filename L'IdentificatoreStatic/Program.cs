namespace L_IdentificatoreStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tLo Static");

            /*
             * Quando abbiamo la parola static intendiamo che quella:
             * classe, proprieta, metodo o qualcos'altro esistono esclusivamente
             * come una copia, non ne esiste un'altra
             * 
             * Non essendo la classe Persona static noi possiamo riprodurla più volte
             * Persona persona2 = new Persona("Alessandro", "Terzi", 20);
             * Persona persona3 = new Persona("Alessandro", "Terzi", 20);
             * 
             * statica vuol dire che è fissa
             * CON UNA CLASSE STATIC NOI NON POSSIAMO ISTANZIARLA, NON POSSIAMO
             * OTTENERE UN OGGETTO
             * 
             * SE ALL'INTERNO DI UNA CLASSE NON STATICA NOI ABBIAMO UNA PROPRIETà
             * STATICA, ESSA SARà CONDIVISA TRA TUTTI GLI OGGETTI, QUINDI
             * NON SARà SPECIFICO DI QUELL'OGGETTO
             */

            Persona persona1 = new Persona("Alessandro", "Terzi", 20);
            Persona persona2 = new Persona("Anna", "Leoni", 27);
            Persona persona3 = new Persona("Andrea", "Lorenzi", 15);
            Persona persona4 = new Persona("Lucia", "Marchesi", 17);

            persona2.nome = "Francesca";

            Console.WriteLine("\n" + persona2.nome + "\n");
            Console.WriteLine(Persona.numeroPersone);

            Console.WriteLine();
            Persona.Saluta("Pasquale");
            /*
             * QUANDO CREARE DEI METODI STATICI?
             * CREIAMO DEI METODI STATICI QUANDO GLI VOGLIAMO A NOSTRA DISPOSIZIONE 
             * ANCHE SE NON ABBIAMO CREATO NESSUNA ISTANZA DI QUESTA CLASSE
             * 
             * ANCHE SE NON ABBIAMO NESSUN OGGETTO MA VOGLIAMO COMUNQUE USARE IL METODO
             */
            Persona.Saluta("Federico"); //Sono uguali
            Console.WriteLine(Math.Max(10,20));//Sono uguali
        } 
    }
}