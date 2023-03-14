namespace ModificatoreDiAccesso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tI Modificatori d'accesso");
            //public, protected, private, internal
            /*
             * I modificatori d'accesso sono parole chiavi che vanno a modificare
             * l'accesso a metodi e proprietà, in diverse parti del codice
             */

            //public:
            //Possiamo utilizzare questa proprietà o metodo, in qualsiasi parte del nostro codice
            Persona persona1 = new Persona("Marco", "Antonio");
            persona1.Saluta(); //Essendo public posso accedere in ogni parte del codice

            //private:
            //Possiamo utilizzarlo solo all'interno della sua classe
            //Se vogliamo accedere al metodo possiamo andare a inserirlo in um metodo
            //public e richiamarlo
            persona1.Saluta();

            //protected
            //è un tipo di modificatore che permette di accedere all'inerno della propria 
            //classe oppure alle classe derivateb  

            //internal
            //permette di accedervi ovunque ma all'interno dello stesso assembly

        }
    }
}