using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_Ereditarietà
{

    internal class Insegnante : Persona
    {

        public string materia;

        //Costruttore                                       
        public Insegnante(string nome, string cognome, string materia) : base(nome, cognome)
        {

            this.materia = materia;
        }

        //Metodi
        public override void Saluta()
        {//Con override stiamo sovrascrivendo il metodo Saluta di Persona
            Console.WriteLine("Buongiorno ragazzi, ora iniziamo la lezione");
            //base.Saluta(); Usiamo il metodo normale di Saluta()

        }

        public void Insegna()
        {

        }
    }
}
