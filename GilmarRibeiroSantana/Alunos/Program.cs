using System;
using System.Collections.Generic;
using Alunos.Biblioteca;

namespace Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Id = 1;
            p1.Nome = "Vagner";
            p1.Endereco = "Rua A, 123";

            Pessoa p2 = new Pessoa();
            p2.Id = 2;
            p2.Nome = "Roberto";
            p2.Endereco = "Rua B, 456";

            Pessoa p3 = new Pessoa();
            p3.Id = 3;
            p3.Nome = "Sandra";
            p3.Endereco = "Rua C, 789";

            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(p1);
            pessoas.Add(p2);
            pessoas.Add(p3);

            Livro livro = new Livro();
            livro.Nome = "Matemática";
            livro.Versao = "1.00.1";

        }
    }
}
