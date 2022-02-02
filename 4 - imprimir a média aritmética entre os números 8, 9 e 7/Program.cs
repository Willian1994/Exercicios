using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___imprimir_a_média_aritmética_entre_os_números_8__9_e_7
{
    class Program
    {
        static void Main(string[] args)

        #region Meu jeito
        //{
            //int X = 8;
            //int Y = 9;
            //int Z = 7;

            //int Soma = X + Y + Z;
            //int Media = Soma / 3;
            //int Resultado = Media;

            //Console.WriteLine("O valor é: " + Media);

            //Console.ReadKey();
        //}
        #endregion

        #region Correção
        {
        int x = 8;
        int y = 9;
        int z = 7;
        double resultado = 0;
        resultado = (x + y + z) / 3;
        Console.WriteLine(" A média é " + resultado);

        Console.ReadKey();

        }
        #endregion
    }
}
