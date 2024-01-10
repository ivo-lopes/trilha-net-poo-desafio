using System;

namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Adicionei um construtor que chama o construtor da classe base usando a palavra-chave "base"
        public Iphone(string numero, string modelo, double tamanhoTela) : base(numero, "iPhone", modelo, tamanhoTela)
        {
            // TODO: Adicionar quaisquer inicializações específicas da classe iPhone, se necessário
        }

        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na App Store do iPhone...");
        }
    }
}
