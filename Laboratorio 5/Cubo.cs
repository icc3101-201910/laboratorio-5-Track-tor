using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_5
{
    class Cubo : ICalcular
    {
        public int Calcular(int x)
        {
            return (x * x * x);
        }
    }
}
