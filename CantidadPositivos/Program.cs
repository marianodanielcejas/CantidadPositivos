using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantidadPositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            int ContadorPositivos = 0;
            for(int i = 1; i <= 20; i++)
            {
                Console.Write("Ingrese un Número por favor: ");
                Num = int.Parse(Console.ReadLine());
                if(Num > 0)
                {
                    ContadorPositivos = ContadorPositivos + 1;
                }
            }
            Console.WriteLine("La cantidad de números positivos ingresados es: {0}", ContadorPositivos);
            Console.Read();
        }
    }
}
