using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificatoreDiAccesso
{
    internal class Persona
    {
        public string nome;
        public string cognome;

        public Persona(string nome, string cognome)
        {
        
        }
        
        public void Saluta()
        {
            Console.WriteLine("Ciaoooooooo");
            this.Cucina();
        }
        private void Cucina()
        {
            Console.WriteLine("Sto cucinando");
        }
        protected void Respira()
        {
            Console.WriteLine("Sto respirando");
        }
        internal void Balla()
        {
            Console.WriteLine("Sto ballando");
        }

    }
}
