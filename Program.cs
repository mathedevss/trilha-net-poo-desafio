using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia tijolex");
Nokia tijolex = new Nokia("213 1542-2573", "Tijolão", "1111111", 64);
tijolex.Ligar();
tijolex.InstalarAplicativo("Brawl stars");

Console.WriteLine("");

Console.WriteLine("Iphone Quadrado");
Iphone quadrado = new Iphone("213 1542-2573", "Quadrado", "1111111", 256);
quadrado.ReceberLigacao();
quadrado.InstalarAplicativo("Instagram");