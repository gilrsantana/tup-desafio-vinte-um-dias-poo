using System.Collections.Generic;

namespace bolo
{
    public class Receita
    {
        public string Nome { get; set; }
        public string Tamanho { get; set; }
        public double Peso { get; set; }
        public double Preço { get; set; }        

        public Receita(string nome = "")
        {
            this.Nome = nome;
        }

        public void Mostrar()
        {

        }

        public void Salvar()
        {
            System.Console.WriteLine("Está salvo como  ...");
        }
    }
}