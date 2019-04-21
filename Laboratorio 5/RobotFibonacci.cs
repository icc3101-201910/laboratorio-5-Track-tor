using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_5
{
    class RobotFibonacci : ICalcular
    {
        static int fibo(int num)
        {
            int pas1 = 1;
            int pas2 = 0;
            int actual = 0;
            if (num == 1)
                return num;
            for (int i = 0; i <= num; i++)
            {
                if (i <= 1)
                    continue;
                actual = pas1 + pas2;
                pas2 = pas1;
                pas1 = actual;
            }

            return actual;
        }

        public int Calcular(int x)
        {
            if (x > 46)
            {
                Console.WriteLine("el numero {0} es muy grande, retornando fibonacci de 46!",x);
                return fibo(46);

            }
            return fibo(x);
        }
    }
}
