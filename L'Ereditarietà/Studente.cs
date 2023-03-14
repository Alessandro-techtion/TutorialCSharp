using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_Ereditarietà
{
    //La classe Studente estende la classe Persona
    internal class Studente : Persona
    {
        
        public string classe;

        //Costruttore
        public Studente(string nome, string cognome, string classe): base(nome, cognome)
        {
            
            this.classe = classe;
        }

    

        //Metodi
        
        public void Studia()
        {

        }
    }
}
