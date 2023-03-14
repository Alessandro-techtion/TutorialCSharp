namespace IMetodi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tI Metodi");
            /*
             * I METODI SONO LE FUNZIONI PRESENTI NEI LINGUAGGI AD OGGETTI
             * SONO LE FUNZIONI DELLE CLASSI
             * 
             * I METODI SONO DEL CODICE CHE SCRIVIAMO UNA VOLTA E LO ANDREMO 
             * A RICHIAMARE PIù VOLTE NEL PROGRAMMA
             * 
             * ESEMPIO
             * fareCarne()
             * {
             *  scongelare carne
             *  prendere la padella
             *  far scaldare padella
             *  mettere la carne
             *  mettere spezie
             *  girarla
             *  aspettare tot minuti
             *  impiattare 
             */

            //Richiamiamo la funzione
            Saluta();

            Saluta2("Marco");

            Saluta3("Simone", 2);

            Saluta4(saluti: "CIAOOOOOOOO", nome : "Federico");


            int risultato = FaiSomma(10, 20);
            Console.WriteLine("Il risultato della somma è:");

        }
        //Creiamo la funzione
        static void Saluta()
        {
            Console.WriteLine("Ciao");
        }

        //Quando richiamiamo la funzione accetta un parametro in ingresso
        //I parametri sono dei dati dinamici che noi passiamo alla funzione
        static void Saluta2(string nome)
        {
            Console.WriteLine($"Ciao {nome}");
        }

        static void Saluta3(string nome, int ora = 0) //Il valore default di ora è 0
        {
            switch (ora)
            {
                case 0:
                    Console.WriteLine($"Ciao {nome}, buongiorno");
                    break;
                case 1:
                    Console.WriteLine($"Ciao {nome}, buon pomeriggio");
                    break;
                case 2:
                    Console.WriteLine($"Ciao {nome}, buona serata");
                    break;

            }  
        }

        static void Saluta4(string nome, string saluti)
        {
            Console.WriteLine("{saluti} {nome}");
        }
        //void è il tipo di dato che ci riporterà la funzione
        //che in caso di void non riportèrà nulla
    
        static int FaiSomma(int numero1, int numero2)
        {
            int retvale;
            retvale= numero1 + numero2;
            return retvale;
        }
        //abbiamo cambiato il tipo di ritorno della funzione da void a int
        //per esempio quando facciamo una somma su una calcolatrice
        //ci farà vedere il risultato, quindi ci sarà un ritorno di un valore
        //Se fosse void la calcolatrice, esegue la somma, ma non ci mostra il valore

    }

}