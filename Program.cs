using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de utilização das classes
            Nokia nokiaPhone = new Nokia("123456789", "Nokia", "Nokia 3310");
            Iphone iphone = new Iphone("987654321", "Apple", "iPhone 12");

            nokiaPhone.Ligar();
            nokiaPhone.InstalarAplicativo("WhatsApp");

            iphone.Ligar();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}
