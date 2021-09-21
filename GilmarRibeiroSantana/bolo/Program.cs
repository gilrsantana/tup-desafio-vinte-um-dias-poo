using System;
using System.Collections.Generic;

namespace bolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Receita b3 = new Receita("Abacxi");
            b3.Tamanho = "P";
            b3.Peso = 500;
            b3.Preço = 10.99;

            Receita b1 = new Receita("Coco");
            b1.Tamanho = "M";
            b1.Peso = 700;
            b1.Preço = 12.99;
            List<string> tamanhos = new List<string>();
            tamanhos.Add("Pequeno");
            tamanhos.Add("Medio");
            tamanhos.Add("Grande");
        
            Receita b2 = new Receita("Chocolate");
            b2.Tamanho = "G";
            b2.Peso = 1000;
            b2.Preço = 15.99;
        }
    }
}
