using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGetterESetters
{
    internal class Persona
    {
        //Con private siamo vietando l'accesso esterno
        private string nome = "";
        private string cognome = "";
        private int età;

        //Metodi Setter 1'Soluzione
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public void SetCognome(string cognome)
        {
            this.cognome = cognome;
        }
        public void SetEtà(int età)
        {
            if(età >= 0) this.età = età;
            else Console.WriteLine("Hai messo un'età non valida");
        }
        
        //Metodi Getter 1' Soluzione
        public string GetNome()
        {
            return this.nome;
        }
        public string GetCognnome()
        {
            return this.cognome;
        }
        public int GetEtà()
        {
            return this.età;
        }

        
        //2' Soluzione
        public string Nome
        {
            get => this.nome;
            set => this.nome = value; //persona1.nome= "Marco";
        }

        //3' Soluzione
        public string Cognome { get; set; }



        //Costruttore
        public Persona(string nome, string cognome, int età)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.età = età;
        }


        //Metodi
        public void Saluta()
        {
            Console.WriteLine($"Ciao il mio nome è {nome} e il mio cognome è {this.cognome}");
        }

    }
  
}
