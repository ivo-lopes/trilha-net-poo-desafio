using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testar a classe Nokia
            Nokia nokia = new Nokia("123456789", "Nokia 8", 5.5);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            // Testar a classe iPhone
            Iphone iPhone = new Iphone("987654321", "iPhone X", 6.0);
            iPhone.Ligar();
            iPhone.ReceberLigacao();
            iPhone.InstalarAplicativo("Instagram");

            Console.ReadLine();
        }
    }
}
