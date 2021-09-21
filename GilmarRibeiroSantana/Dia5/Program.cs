using System;

namespace Dia5
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            c1.Marca = "Chevrolet";
            c1.Modelo = "Cruze";

            for(int i = 0; i < 110; i++){
                c1.Acelerar();
            }

            c1.Desligar();

            for(int i = 0; i < 90; i++){
                c1.Frear();
            }
            c1.Desligar();
            c1.Ligar();

            for(int i = 0; i < 20; i++){
                c1.Frear();
            }
        }
    }
}
