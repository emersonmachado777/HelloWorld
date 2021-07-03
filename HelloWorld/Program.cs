using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int ValorA;
            int ValorB;

            Console.WriteLine("Entre com ao valor A:");
            ValorA = Console.Read();
            Console.ReadLine();
  
            Console.WriteLine("Entre com ao valor B:");
            ValorB = Console.Read();        
            Console.ReadLine();

            if (ValorA > ValorB)
            {
                Console.WriteLine("A é maior que B");
            }
            else if (ValorA == ValorB)
            {
                Console.WriteLine("A e B são iguais.");
            }
            else
            {
                Console.WriteLine("B é maior que A");
            }
           
                    Console.ReadLine();

        }
    }
}
