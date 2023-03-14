namespace IGetterESetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tI Getter & Setters");
            /*
             * I Getter e i Setter ci permettono di accedere alle proprietà della nostra
             * classe Persona, tutto il codice che abbiamo scritto finora è:
             * CODICE NON SICURO!!
             * 
             * Perchè chiunque scriva che sia una persona fisica o una parte di codice
             * sia in grado di accedere a tutto ciò che una classe ha e ci hò che la definisce
             * 
             * Mettendo gli indentificatori private, non potremo pià accedere alla classe 
             * da altri classi
             * 
             * Come fare per accedergli anche se sono private?
             */

            /*
             * Tramite degli intermidiari, qualcosa che è in grado di accedere alla classe Persona
             * Il get e il set
             * 
             */
            
            //1' Soluzione
            Persona persona1 = new Persona("Alessandro", "Terzi", 20);
            persona1.SetNome("Antonio"); //Questo si chiama Setter
            Console.WriteLine(persona1.GetNome());//Questo si chiama Getter

            //Abbiamo altre soluzioni volendo:
            //2' Soluzione
            persona1.Nome = "Sofia";
            Console.WriteLine(persona1.Nome);

            //3' Soluzione
            persona1.Cognome = "Marini"; //Il metodo è uguale a quello sopra
            Console.WriteLine(persona1.Cognome);


            persona1.SetEtà(-1);
            Console.WriteLine(persona1.GetEtà());


        }
    }
}