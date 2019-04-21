using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_5
{
    class PerroFactorial:ICalcular
    {
        static int fact(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * fact(num - 1);
            }
          
        }


        public int Calcular(int x)
        {
            if(x>13)
            {
                Console.WriteLine("el numero {0} es muy grande, retornando factorial de 13!", x);
                return fact(13);
            }
            return fact(x);
        }
    }
}
