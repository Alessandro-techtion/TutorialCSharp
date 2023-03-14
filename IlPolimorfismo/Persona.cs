using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlPolimorfismo
{
    internal class Persona
    {
        public string nome;
        public string cognome;

        //Costruttore
        public Persona(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
        }

        //Metodi
        public virtual void Saluta()
        {
            Console.WriteLine($"Ciao sono {nome} e {cognome}");
        }
    }
}
