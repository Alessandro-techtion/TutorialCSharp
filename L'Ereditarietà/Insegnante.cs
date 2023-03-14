using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_Ereditarietà
{
    //La classe Insegnante estende la classe Persona
    internal class Insegnante : Persona
    {
        
        public string materia;
        
        //Costruttore                                       Passiamo nome e cognome dalla classe Persona
        public Insegnante(string nome, string cognome,string materia): base(nome,cognome)
        {
            
            this.materia = materia;
        }

        //Metodi
        
        public void Insegna()
        {

        }
    }
}
