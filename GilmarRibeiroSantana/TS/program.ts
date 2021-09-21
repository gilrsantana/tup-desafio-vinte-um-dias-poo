import { Pessoa } from "./pessoa";

let p1 = new Pessoa();
p1.Id = 1;
p1.Nome = "Vagner";
p1.Endereco = "Rua A, 123";

let p2 = new Pessoa();
p2.Id = 2;
p2.Nome = "Roberto";
p2.Endereco = "Rua B, 456";

let p3 = new Pessoa();
p3.Id = 3;
p3.Nome = "Sandra";
p3.Endereco = "Rua C, 789";

const pessoas:Pessoa[] = []

pessoas.push(p1);
pessoas.push(p2);
pessoas.push(p3);

console.log(pessoas)