using System;

namespace gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            string frasedigitada;
            Console.WriteLine("Digite uma frase: ");
            frasedigitada = Console.ReadLine();

            Console.WriteLine(frasedigitada.ToUpper());

        }
    }
}
