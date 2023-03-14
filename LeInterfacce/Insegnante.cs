using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_Ereditarietà
{

    internal class Insegnante : IEquatable<Insegnante>
    {
        public string nome;
        public string cognome;
        public string materia;

        //Costruttore                                       
        public Insegnante(string nome, string cognome, string materia)
        {
            this.nome = nome;
            this.cognome=cognome;
            this.materia = materia;
        }

        //Metodi
        public void Saluta()
        {//Con override stiamo sovrascrivendo il metodo Saluta di Persona
            Console.WriteLine("Buongiorno ragazzi, ora iniziamo la lezione");
            //base.Saluta(); Usiamo il metodo normale di Saluta()

        }

        public void Insegna()
        {

        }
        //Metodo di IEquatable
        public bool Equals(Insegnante insegnante)
        {
            return this.nome == insegnante.nome;
            
        }
    }
}
