using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcularNumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean mostrouMsg = false;
            Int32 n=1, n2, cont, final;
            Double r=0;

            Console.Write("Informe o número inicial: ");
            n=Console.Read();
            Console.Write("Informe o número Final");
            final = Console.Read();

            while(n < 100)
            {
                n2=n-1;
                for (cont = n2; cont >= 2; --cont)
                {
                    r = n % cont;
                    if(r == 0)
                    {
                        //Console.WriteLine("O numero "+n+" não é primo!");
                        cont=1;
                    }
                }
                if(r!=0)
                {
                    if (!mostrouMsg)
                    {
                        Console.WriteLine("Segue o números primos encontrados");
                        mostrouMsg = true;
                    }
                    Console.WriteLine(n);
                }
                n++;
            }
            Console.ReadLine();
        }
    }
}
