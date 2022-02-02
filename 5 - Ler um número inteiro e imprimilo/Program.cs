using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Ler_um_número_inteiro_e_imprimilo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou o numero: " + numero);
            Console.ReadKey();

        }
    }
}
