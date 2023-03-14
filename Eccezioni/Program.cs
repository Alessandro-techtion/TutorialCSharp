namespace Eccezioni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t \t \t Eccezioni");
            /*
             * Try, Catch, Finally
             * Multiple Exception
             */


            Console.WriteLine("Inserisci un numero ");
            string inputUtente = Console.ReadLine();
            int num1=0;
            try
            {
                 num1 = int.Parse(inputUtente);
            }
            catch (FormatException e)
            {
                //throw;
                Console.WriteLine("Errore formato non corretto: inserire un numero");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Errore valore Null");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Errore valore troppo grande per essere un int");
            }
            catch (Exception e)
            {
                Console.WriteLine("Si è verificato un errore generico");
            }
            finally
            {
                Console.WriteLine("Questa stringa verrà stmapata a prescindere");
            }
            Console.WriteLine(num1 + 2);

        }
    }
}