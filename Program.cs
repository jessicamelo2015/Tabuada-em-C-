using System;

namespace aula02
{

    class Program
    {
        static async void Main(string[] args)
        {
            int tabuada;
            Console.WriteLine("digite um numero 2 a 1000");
            tabuada=int.Parse(Console.ReadLine());
            int resultado;
            for (int i = 1; i <= 10; i++)
            {
                resultado= tabuada * i;
                if (tabuada >= 2 && tabuada <= 1000)
                {
                    Console.WriteLine(tabuada +"X" + i + "=" + resultado);   
                }
                
            }
              
        if(tabuada < 2 || tabuada >1000)
                {
                    Console.WriteLine("valor invalido, digite um numero de 2 a 1000");
                }

        }
    }

}

/* int numero;
           Console.WriteLine("digite um numero");
           numero = int.Parse(Console.ReadLine());
           while (numero != null)
           {

               if (numero % 2 == 0)
               {
                   Console.WriteLine("o numero que voce digitou é PAR");
               }
               else
               {
                   Console.WriteLine("o numero que voce digitou é IMPAR");
               }
                Console.WriteLine("digite um numero");
                numero = int.Parse(Console.ReadLine());
               continue;
           }
         */