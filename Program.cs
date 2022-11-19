using DesafioPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Aparelho Nokia - Testes");
        Smartphone nokia = new Nokia(numero: "988224455", modelo: "N8", imei: "000111222", memoria: 8);
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Whatsapp");

        Console.WriteLine("\n");

        Console.WriteLine("Aparelho Iphone - Testes");
        Smartphone iphone = new Iphone(numero: "955331177", modelo: "12 Pro", imei: "555666777", memoria: 128);
        iphone.Ligar();
        iphone.InstalarAplicativo("Telegram");
    }
}   