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
        public Persona(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
        }


        //Metodi
        public virtual void Saluta()
        {//Con virtual stiamo dicendo che il metodo può essere sovrascritto da altre classi
            Console.WriteLine("Ciao, sono una persona");
        }
    }
}
