using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Marca { get; set; } // Implementando a propriedade Marca
        public string Modelo { get; set; } // Implementando a propriedade Modelo

        public Smartphone(string numero, string marca, string modelo)
        {
            Numero = numero;
            Marca = marca;
            Modelo = modelo;
            // Passando os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
