
using System;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            // vamos verificar se o ano 2008
            // é bissexto

            int numero1, numero2, numero3;
            int aux = 0;
            
            Console.WriteLine("Informe o primeiro numero");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Infome o segundo numero");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Infome o terceiro numero");
            numero3 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                aux = numero1;
                numero1 = numero2;

                numero2 = aux;

            }
            if(numero1 > numero3)
            {
                aux = numero1;
                numero1 = numero3;
                numero3 = aux;
            }
            if (numero2 > numero3)
            {
                aux = numero2;
                numero2 = numero3;
                numero2 = aux;
            }


            Console.WriteLine("valores ordenados: " + numero1 +"," + numero2 +"," + numero3);



            

            // pausa o programa
            Console.ReadKey();
        }
    }
}
