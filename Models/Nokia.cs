namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string mei, int memoria) : base(numero, modelo, mei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp) 
        {
            Console.WriteLine($"Aplicativo {nomeApp} foi instalado com sucesso!");
        }
    }
}