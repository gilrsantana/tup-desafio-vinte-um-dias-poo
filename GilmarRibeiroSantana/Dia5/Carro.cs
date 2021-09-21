namespace Dia5
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }    
        public bool Novo { get; set; }
        public double Valor { get; set; }
        
        private int velocidade;
        public int Velocidade
        {
            get { return velocidade; }
            private set 
            { 
                if(value <= 100)
                {
                    velocidade = value;
                }
                else
                {
                    System.Console.WriteLine("Carro atingiu velocidade máxima.");
                } 
            }
        }
        
        private bool Ligado { get; set; }

        public Carro()
        {
            this.Velocidade = 0;
            this.Ligado = false;
        }
        public void Ligar(){
            if(!this.Ligado)
            {
                this.Ligado = true;
                System.Console.WriteLine("Ligou o carro.");
            }
            else
            {
                System.Console.WriteLine("Carro já está ligado.");
            }
        }

        public void Acelerar(){
            if(!this.Ligado)
            {
                System.Console.WriteLine("Acionando Start-Stop Automático");
                Ligar();
            }
            this.Velocidade++;
            System.Console.WriteLine($"Carro acelerou\n{this.Velocidade}Km/h.");
        }

        public void Frear(){
            if(this.Velocidade > 0)
            {
                this.Velocidade--;
                System.Console.WriteLine($"Carro freou\n{this.Velocidade}Km/h.");
            }
            else
            {
                if(this.Velocidade == 0 || this.Ligado == false)
                {
                    System.Console.WriteLine("Carro parado.");
                    if(this.Velocidade == 0 && this.Ligado == true)
                    {
                        System.Console.WriteLine("Acionando Start-Stop Automático");
                        Desligar();
                    }
                }
            }
        }

        public void Desligar(){
            if(this.Velocidade > 0)
            {
                System.Console.WriteLine("Carro em movimento não pode ser desligado.");
            }
            else
            {
                this.Ligado = false;
                System.Console.WriteLine("Carro desligou.");
            }
        }
    }
}