using System;

namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Adicionei um construtor que chama o construtor da classe base usando a palavra-chave "base"
        public Nokia(string numero, string modelo, double tamanhoTela) : base(numero, "Nokia", modelo, tamanhoTela)
        {
            // TODO: Adicionar quaisquer inicializações específicas da classe Nokia, se necessário
        }

        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na loja da Nokia...");
        }
    }
}
