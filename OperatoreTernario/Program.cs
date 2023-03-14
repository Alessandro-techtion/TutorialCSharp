namespace OperatoreTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t \t \t Operatore Ternario");
            string nome="Alessio";
            if (5 < 6) nome = "Luca";
            Console.WriteLine(nome);

            if (5 < 6) nome = "Alessio"; Console.WriteLine(nome);
            //Il programma in questo caso non prenderà l'istruzione nome="Alessio"
            //Se si ha più di un'istruzione si dovrà usare le graffe

            string parola = "Buongiorno";
            if (parola == "Buongiorno") Console.WriteLine("Buongiornoooo");
            else Console.WriteLine("Buonasera");


            //OPERATORE TERNARIO EFFETTIVO
            nome = "Matteo";
            nome = 5 < 6 ? "Alessio" : "Luca";
            //Se è vero il nome sarà Alessio

            Console.WriteLine();

            int numero = 10;
            string parola2 = "mh";
            parola2 = numero % 2 != 0 ? "Dispari" : (numero < 10 ? "Pari e minore di 10" : "Pari e maggiore di 10");
            Console.WriteLine(parola2);

            //Oppure
            if (numero % 2 != 0) parola2 = "Dispari";
            else
            {
                if (numero < 10) parola2 = "Pari minore di 10";
                else parola2 = "Pari maggiore di 10";
            }

        }
    }
}