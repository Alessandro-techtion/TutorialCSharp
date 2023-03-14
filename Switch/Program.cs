namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t \t \t Switch");

            int anni = 30;
            if(anni == 18)
            {
                Console.WriteLine("Yeee sei maggiorenne!");
            }else if(anni == 20)
            {
                Console.WriteLine("Sei un ventenne");
            }else if (anni == 30)
            {
                Console.WriteLine("La vecchiaia si fa sentire");
            }

            string nome = "Luca";
            switch (anni)
            {
                case 18:
                    if (nome == "Luca")
                    {
                        Console.WriteLine("Yeee Luca! sei maggiorenne!");
                    }                   
                    break;
                case 20:
                    Console.WriteLine("Sei un ventenne");
                    break ;
                case 30:
                    Console.WriteLine("La vecchiaia si fa sentire");
                    break;
                default:
                    Console.WriteLine("Non so quanti anni hai");
                    break;
            }
        }
    }
}