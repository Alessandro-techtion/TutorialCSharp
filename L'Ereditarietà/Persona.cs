using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_Ereditarietà
{
    internal class Persona
    {
        public string nome;
        public string cognome;

        //Costruttore
        public Persona(string nome,string cognome)
        {
            this.nome=nome;
            this.cognome = cognome;
        }


        //Metodi
        public void Saluta()
        {
            Console.WriteLine("Ciao, sono una persona");
        }
    }
}
